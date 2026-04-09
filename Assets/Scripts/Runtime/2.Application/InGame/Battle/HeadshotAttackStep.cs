using SSTraining.Runtime.Domain.InGame.Battle;

namespace SSTraining.Runtime.Application.InGame.Battle
{
    /// <summary>
    ///     弓兵の攻撃のうち、ヘッドショットが発生した場合の攻撃処理を表すクラス。
    ///     
    /// </summary>
    public class HeadshotAttackStep : IAttackStep
    {
        public AttackContext ExecuteStep(in AttackContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}