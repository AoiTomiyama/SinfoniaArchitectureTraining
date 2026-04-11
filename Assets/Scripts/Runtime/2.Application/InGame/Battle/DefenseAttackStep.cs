using System;
using SSTraining.Runtime.Domain.InGame.Battle;

namespace SSTraining.Runtime.Application.InGame.Battle
{
    /// <summary>
    ///     防御力の計算を担当するクラス。
    ///     攻撃者の攻撃力と防御者の防御力を考慮して、最終的なダメージ量を修正する役割を持つ。
    /// </summary>
    [Serializable]
    public class DefenseAttackStep : IAttackStep
    {
        public AttackContext ExecuteStep(in AttackContext context)
        {
            float defenderDefensePower = context.Defender.Defense.Value;
            
            // ダメージ量を防御力で割った値を計算する。
            Damage damageAfterDefense = context.Damage / defenderDefensePower;
            return new AttackContext(context.Attacker, context.Defender, damageAfterDefense);
        }
    }
}