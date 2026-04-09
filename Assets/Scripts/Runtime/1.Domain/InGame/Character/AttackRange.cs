using System;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターの攻撃範囲を表す値オブジェクト。
    /// </summary>
    public readonly struct AttackRange
    {
        public AttackRange(float value)
        {
            if (value < 0)
            {
                throw new ArgumentException("AttackRange cannot be negative.", nameof(value));
            }

            if (!float.IsFinite(value))
            {
                throw new ArgumentException("AttackRange must be a finite number.", nameof(value));
            }

            _value = value;
        }

        /// <summary> 攻撃範囲を取得するプロパティ。 </summary>
        public float Value => _value;
        
        private readonly float _value;
    }
}