using UnityEngine;
using SSTraining.Runtime.Domain.InGame.Character;

namespace SSTraining.Runtime.Application.InGame.Character
{
    /// <summary>
    ///     キャラクターの移動に関する処理を担当するクラス。移動速度や移動方法など、キャラクターの移動に関連するロジックを実装する。
    /// </summary>
    public class CharacterMovement
    {
        public CharacterMovement(MovementParams movementParams)
        {
            _movementParams = movementParams;
        }

        /// <summary>
        ///     キャラクターを移動させるためのメソッド。ターゲットの位置とキャラクターの現在の位置を受け取り、移動の結果を返す。
        /// </summary>
        /// <param name="targetPosition"></param>
        /// <param name="characterPosition"></param>
        /// <returns></returns>
        public CharacterMovementResult Move(Vector3 targetPosition, Vector3 characterPosition)
        {
            float distance = Vector3.Distance(targetPosition, characterPosition);

            // 攻撃範囲外であれば、対称の座標に向けて移動する。
            if (distance > _movementParams.AttackRange.Value)
            {
                return new CharacterMovementResult(
                    true,
                    characterPosition,
                    _movementParams.MoveSpeed.Value
                );
            }

            // 攻撃範囲内であれば、移動は行わない。
            return new CharacterMovementResult(
                false,
                targetPosition,
                0f
            );
        }

        private readonly MovementParams _movementParams;
    }
}