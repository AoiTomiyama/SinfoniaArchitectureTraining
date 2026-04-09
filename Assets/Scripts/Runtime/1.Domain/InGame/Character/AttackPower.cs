using System;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターの攻撃力を表す値オブジェクト。
    /// </summary>
    public readonly struct AttackPower
    {
        public AttackPower(float value)
        {
            if (value < 0)
            {
                throw new ArgumentException("AttackPower cannot be negative.", nameof(value));
            }

            if (!float.IsFinite(value))
            {
                throw new ArgumentException("AttackPower must be a finite number.", nameof(value));
            }

            _value = value;
        }

        /// <summary> 攻撃力を取得するプロパティ。 </summary>
        public float Value => _value;
        
        private readonly float _value;
    }
}