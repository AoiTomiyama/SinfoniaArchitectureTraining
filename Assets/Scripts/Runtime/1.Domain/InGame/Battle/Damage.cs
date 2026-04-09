using System;

namespace SSTraining.Runtime.Domain.InGame.Battle
{
    /// <summary>
    ///     ダメージを表す値オブジェクト。
    /// </summary>
    public readonly struct Damage
    {
        public Damage(float value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Damage cannot be negative. ", nameof(value));
            }

            if (!float.IsFinite(value))
            {
                throw new ArgumentException("Damage must be a finite number.", nameof(value));
            }

            _value = value;
        }

        /// <summary> ダメージを取得するプロパティ。 </summary>
        public float Value => _value;
        
        public static Damage operator +(Damage a, float b) => new Damage(a.Value + b);
        public static Damage operator -(Damage a, float b) => new Damage(a.Value - b);
        public static Damage operator *(Damage a, float multiplier) => new Damage(a.Value * multiplier);
        public static Damage operator /(Damage a, float divisor) => new Damage(a.Value / divisor);
        public static implicit operator Damage(float value) => new(value);
        
        private readonly float _value;
    }
}