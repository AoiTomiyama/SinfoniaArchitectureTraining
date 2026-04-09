using SSTraining.Runtime.Domain.InGame.Battle;

namespace SSTraining.Runtime.Application.InGame.Battle
{
    /// <summary>
    ///     攻撃の各ステップを表すインターフェース。
    ///     攻撃の処理を複数のステップに分割し、各ステップを独立して実装できるようにするためのもの。
    /// </summary>
    public interface IAttackStep
    {
        public AttackContext ExecuteStep(in AttackContext context);
    }
}