using System;
using SSTraining.Runtime.Domain.InGame.Battle;

namespace SSTraining.Runtime.Application.InGame.Battle
{
    /// <summary>
    ///     攻撃の処理を管理するクラス。攻撃の各ステップを順番に実行するためのパイプラインを提供する。
    /// </summary>
    public class AttackPipeline
    {
        public AttackPipeline(IAttackStep[] steps)
        {
            if (steps == null)
            {
                throw new ArgumentNullException(nameof(steps));
            }

            for (int i = 0; i < steps.Length; i++)
            {
                if (steps[i] == null)
                {
                    throw new ArgumentException($"attackSteps[{i}] is null.", nameof(steps));
                }
            }

            _steps = steps;
        }

        /// <summary>
        ///     攻撃の処理を実行するメソッド。
        ///     AttackContextを受け取り、各ステップを順番に実行して最終的なダメージを計算する。
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Damage Execute(in AttackContext context)
        {
            AttackContext currentContext = context;
            for (int i = 0; i < _steps.Length; i++)
            {
                currentContext = _steps[i].ExecuteStep(currentContext);
            }

            return currentContext.Damage;
        }

        private readonly IAttackStep[] _steps;
    }
}