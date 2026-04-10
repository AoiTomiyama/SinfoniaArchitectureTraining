using UnityEngine;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターが移動する際の計算結果を表す値オブジェクト。
    ///     移動が成功したかどうか、移動の目標位置、移動速度などを含む。
    /// </summary>
    public struct CharacterMovementResult
    {
        public CharacterMovementResult(bool isSuccessful, Vector3 targetPosition, float movementSpeed)
        {
            IsSuccessful = isSuccessful;
            TargetPosition = targetPosition;
            MovementSpeed = movementSpeed;
        }

        /// <summary> 移動が成功したかどうかを表すプロパティ。 </summary>
        public bool IsSuccessful { get; }

        /// <summary> 移動の目標位置を表すプロパティ。 </summary>
        public Vector3 TargetPosition { get; }
        
        /// <summary> 移動速度を表すプロパティ。 </summary>
        public float MovementSpeed { get; }
    }
}