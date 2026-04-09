using System;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターのクリティカルダメージ倍率を表す値オブジェクト。
    /// </summary>
    public readonly struct CriticalDamage
    {
        public CriticalDamage(float value)
        {
            if (value < 1)
            {
                throw new ArgumentException("CriticalDamage must be >= 1", nameof(value));
            }

            if (!float.IsFinite(value))
            {
                throw new ArgumentException("CriticalDamage must be a finite number.", nameof(value));
            }

            _value = value;
        }
        
        public float Value => _value;
        private readonly float _value;
    }
}