using System;
using SSTraining.Runtime.Domain.InGame.Battle;
using Random = UnityEngine.Random;

namespace SSTraining.Runtime.Application.InGame.Battle
{
    /// <summary>
    ///     クリティカル攻撃の処理を担当するクラス。
    ///     攻撃者のクリティカル発生確率とクリティカルダメージ倍率を考慮して、攻撃のダメージを修正する役割を持つ。
    /// </summary>
    [Serializable]
    public class CriticalAttackStep : IAttackStep
    {
        public AttackContext ExecuteStep(in AttackContext context)
        {
            float criticalChance = context.Attacker.CriticalChance.Value;
            float criticalDamageMultiplier = context.Attacker.CriticalDamage.Value;
            bool isCritical = Random.value <= criticalChance / 100f; // クリティカル発生確率を0-1の範囲に変換して判定
            
            // クリティカルが発生しなかった場合は、そのまま返す
            if (!isCritical)
            {
                return context;
            }

            // クリティカルが発生した場合、ダメージにクリティカル倍率を適用
            Damage criticalDamage = context.Damage * criticalDamageMultiplier;
            return new AttackContext(context.Attacker, context.Defender, criticalDamage);
        }
    }
}