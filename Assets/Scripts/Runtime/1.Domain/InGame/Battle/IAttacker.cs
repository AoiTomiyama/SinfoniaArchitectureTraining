using SSTraining.Runtime.Domain.InGame.Character;

namespace SSTraining.Runtime.Domain.InGame.Battle
{
    /// <summary>
    ///     攻撃を行うキャラクターを表すインターフェース。攻撃の発動者として、攻撃力とクリティカル関連の情報を提供するためのもの。
    /// </summary>
    public interface IAttacker
    {
        /// <summary> 攻撃力を表すプロパティ。 </summary>
        public AttackPower AttackPower { get; }
        
        /// <summary> クリティカルの発生確率を表すプロパティ。 </summary>
        public CriticalChance CriticalChance { get; }
        
        /// <summary> クリティカル発生時の倍率を表すプロパティ。 </summary>
        public CriticalDamage CriticalDamage { get; }
    }
}