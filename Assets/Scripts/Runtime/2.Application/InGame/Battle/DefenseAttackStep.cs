using SSTraining.Runtime.Domain.InGame.Battle;
using UnityEngine;

namespace SSTraining.Runtime.Application.InGame.Battle
{
    /// <summary>
    ///     防御力の計算を担当するクラス。
    ///     攻撃者の攻撃力と防御者の防御力を考慮して、最終的なダメージ量を修正する役割を持つ。
    /// </summary>
    public class DefenseAttackStep : IAttackStep
    {
        public AttackContext ExecuteStep(in AttackContext context)
        {
            float defenderDefensePower = context.Defender.Defense.Value;
            
            // ダメージ量から防御力を引いた値を計算（最小値は0）
            Damage damageAfterDefense = Mathf.Min(0f, context.Damage.Value - defenderDefensePower);
            return new AttackContext(context.Attacker, context.Defender, damageAfterDefense);
        }
    }
}