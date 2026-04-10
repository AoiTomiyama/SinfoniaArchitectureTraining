namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターの攻撃に関するパラメータを表す値オブジェクト。
    ///     攻撃力、攻撃速度、クリティカル発生確率、クリティカルダメージ倍率などの情報を含む。
    /// </summary>
    public readonly struct AttackParams
    {
        public AttackParams(
            AttackPower attackPower, 
            AttackSpeed attackSpeed, 
            CriticalChance criticalChance,
            CriticalDamage criticalDamage)
        {
            AttackPower = attackPower;
            AttackSpeed = attackSpeed;
            CriticalChance = criticalChance;
            CriticalDamage = criticalDamage;
        }

        /// <summary> キャラクターの攻撃力を取得するプロパティ。 </summary>
        public AttackPower AttackPower { get; }

        /// <summary> キャラクターのクリティカル発生確率を取得するプロパティ。 </summary>
        public CriticalChance CriticalChance { get; }

        /// <summary> キャラクターのクリティカル発生時の倍率を取得するプロパティ。 </summary>
        public CriticalDamage CriticalDamage { get; }

        /// <summary> キャラクターの攻撃速度を取得するプロパティ。 </summary>
        public AttackSpeed AttackSpeed { get; }
    }
}