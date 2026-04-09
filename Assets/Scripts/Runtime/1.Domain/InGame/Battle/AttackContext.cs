namespace SSTraining.Runtime.Domain.InGame.Battle
{
    /// <summary>
    ///     攻撃情報を表す値オブジェクト。攻撃の発動者、対象者、ダメージ量などの情報を含む。
    /// </summary>
    public struct AttackContext
    {
        public AttackContext(IAttacker attacker, IDefender defender, Damage damage)
        {
            Attacker = attacker;
            Defender = defender;
            Damage = damage;
        }

        /// <summary> 攻撃者を表すプロパティ。 </summary>
        public IAttacker Attacker { get; }

        /// <summary> 防御者を表すプロパティ。 </summary>
        public IDefender Defender { get; }

        /// <summary> ダメージ量を表すプロパティ。 </summary>
        public Damage Damage { get; }
    }
}