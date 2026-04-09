using System;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターの移動速度を表す値オブジェクト。
    /// </summary>
    public readonly struct MoveSpeed
    {
        public MoveSpeed(float value)
        {
            if (value < 1)
            {
                throw new ArgumentException("MoveSpeed must be >= 1", nameof(value));
            }

            if (!float.IsFinite(value))
            {
                throw new ArgumentException("MoveSpeed must be a finite number.", nameof(value));
            }

            _value = value;
        }

        public float Value => _value;
        private readonly float _value;
    }
}