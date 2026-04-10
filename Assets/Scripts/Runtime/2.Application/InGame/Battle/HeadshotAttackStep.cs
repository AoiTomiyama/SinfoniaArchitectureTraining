using System;
using SSTraining.Runtime.Domain.InGame.Battle;
using Random = UnityEngine.Random;

namespace SSTraining.Runtime.Application.InGame.Battle
{
    /// <summary>
    ///     弓兵の攻撃のうち、ヘッドショットが発生するかを計算するクラス。
    /// </summary>
    [Serializable]
    public class HeadshotAttackStep : IAttackStep
    {
        public AttackContext ExecuteStep(in AttackContext context)
        {
            float criticalChance = context.Attacker.CriticalChance.Value;
            float criticalDamageMultiplier = context.Attacker.CriticalDamage.Value;
            bool isCritical = Random.value <= criticalChance / 100f; // クリティカル発生確率を0-1の範囲に変換して判定。
            
            // クリティカルが発生しなかった場合は、そのまま返し次のステップへ。
            if (!isCritical)
            {
                return context;
            }

            // クリティカルが発生した場合、ダメージにクリティカル倍率を適用する。
            Damage criticalDamage = context.Damage * criticalDamageMultiplier;
            return new AttackContext(context.Attacker, context.Defender, criticalDamage);
        }
    }
}