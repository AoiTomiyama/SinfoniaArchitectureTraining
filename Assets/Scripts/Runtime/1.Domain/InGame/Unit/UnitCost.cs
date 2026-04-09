using System;

namespace SSTraining.Runtime.Domain.InGame.Unit
{
    /// <summary>
    ///     ユニットを生産するコストを表す値オブジェクト。
    /// </summary>
    public readonly struct UnitCost
    {
        public UnitCost(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("UnitCost cannot be negative.", nameof(value));
            }

            _value = value;
        }
        
        public static UnitCost operator +(UnitCost a, UnitCost b) => new UnitCost(a.Value + b.Value);
        public static UnitCost operator -(UnitCost a, UnitCost b) => new UnitCost(a.Value - b.Value);
        public static bool operator >(UnitCost a, UnitCost b) => a.Value > b.Value;
        public static bool operator <(UnitCost a, UnitCost b) => a.Value < b.Value;
        public static bool operator >=(UnitCost a, UnitCost b) => a.Value >= b.Value;
        public static bool operator <=(UnitCost a, UnitCost b) => a.Value <= b.Value;
        
        /// <summary> ユニットコストを取得するプロパティ。 </summary>
        public int Value => _value;
        private readonly int _value;
    }
}