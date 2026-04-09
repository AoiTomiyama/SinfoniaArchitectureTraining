using System;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターの防御力を表す値オブジェクト。
    /// </summary>
    public readonly struct Defense
    {
        public Defense(float value)
        {
            if (value < 1)
            {
                throw new ArgumentException("Defense must be >= 1", nameof(value));
            }

            if (!float.IsFinite(value))
            {
                throw new ArgumentException("Defense must be a finite number.", nameof(value));
            }

            _value = value;
        }

        public float Value => _value;
        private readonly float _value;
    }
}