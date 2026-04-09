using System;

namespace SSTraining.Runtime.Domain.InGame.Battle
{
    /// <summary>
    ///     体力を表す値オブジェクト。
    /// </summary>
    public readonly struct Health : IEquatable<Health>
    {
        public Health(float value)
        {
            if (value < 1)
            {
                throw new ArgumentException("Health must be >= 1", nameof(value));
            }

            if (!float.IsFinite(value))
            {
                throw new ArgumentException("Health must be a finite number.", nameof(value));
            }

            _value = value;
        }
        
        /// <summary> 体力を取得するプロパティ。 </summary>
        public float Value => _value;
        
        public static bool operator >(Health left, Health right) => left._value > right._value;
        public static bool operator <(Health left, Health right) => left._value < right._value;
        public static bool operator >=(Health left, Health right) => left._value >= right._value;
        public static bool operator <=(Health left, Health right) => left._value <= right._value;

        public bool Equals(Health other)
        {
            return _value.Equals(other._value);
        }

        private readonly float _value;
    }
}