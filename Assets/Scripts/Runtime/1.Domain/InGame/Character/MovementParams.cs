namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターの移動に関するパラメータを表す値オブジェクト。
    /// </summary>
    public readonly struct MovementParams
    {
        public MovementParams(MoveSpeed moveSpeed, AttackRange attackRange)
        {
            MoveSpeed = moveSpeed;
            AttackRange = attackRange;
        }

        /// <summary> キャラクターの移動速度を取得するプロパティ。 </summary>
        public MoveSpeed MoveSpeed { get; }

        /// <summary> キャラクターの攻撃範囲を取得するプロパティ。 </summary>
        public AttackRange AttackRange { get; }
    }
}