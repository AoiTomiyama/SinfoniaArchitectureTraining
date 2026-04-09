using System;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターの攻撃速度を表す値オブジェクト。
    /// </summary>
    public readonly struct AttackSpeed
    {
        public AttackSpeed(float value)
        {
            if (value < 0)
            {
                throw new ArgumentException("AttackSpeed cannot be negative.", nameof(value));
            }

            if (!float.IsFinite(value))
            {
                throw new ArgumentException("AttackSpeed must be a finite number.", nameof(value));
            }

            _value = value;
        }
        
        /// <summary> 攻撃速度を取得するプロパティ。 </summary>
        public float Value => _value;
        
        private readonly float _value;
    }
}
