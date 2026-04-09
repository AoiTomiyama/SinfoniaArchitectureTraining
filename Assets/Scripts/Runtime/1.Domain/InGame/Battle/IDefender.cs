using SSTraining.Runtime.Domain.InGame.Character;

namespace SSTraining.Runtime.Domain.InGame.Battle
{
    /// <summary>
    ///     攻撃対象者を表すインターフェース。攻撃の対象者として、体力値、防御力やダメージの受け取り処理などを提供するためのもの。
    /// </summary>
    public interface IDefender
    {
        /// <summary> 現在体力値を表すプロパティ。 </summary>
        public Health CurrentHealth { get; }

        /// <summary> 最大体力値を表すプロパティ。 </summary>
        public Health MaxHealth { get; }

        /// <summary> 防御力を表すプロパティ。 </summary>
        public Defense Defense { get; }

        /// <summary>
        /// 攻撃を受け取るメソッド。ダメージ量を引数として受け取り、体力値を減少させる処理を行う。
        /// </summary>
        /// <param name="damage"> ダメージ量 </param>
        public void TakeDamage(Damage damage);
    }
}