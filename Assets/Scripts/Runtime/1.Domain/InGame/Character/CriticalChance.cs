using System;
using UnityEngine;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターのクリティカルヒットの確率を表す値オブジェクト。
    /// </summary>
    public readonly struct CriticalChance
    {
        public CriticalChance(float value)
        {
            if (!float.IsFinite(value))
            {
                throw new ArgumentException("AttackSpeed must be a finite number.", nameof(value));
            }

            _value = Mathf.Clamp01(value);
        }
        
        public float Value => _value;
        private readonly float _value;
    }
}