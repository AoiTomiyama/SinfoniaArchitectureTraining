using SSTraining.Runtime.Domain.InGame.Battle;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターのパラメーターを表すクラス。
    ///     体力値、攻撃力、防御力、クリティカル関連の情報など、キャラクターの基本的な能力値をまとめて管理するためのもの。
    /// </summary>
    public class CharacterParameter
    {
        public CharacterParameter(
            AttackPower attackPower,
            CriticalChance criticalChance,
            CriticalDamage criticalDamage,
            AttackRange attackRange,
            AttackSpeed attackSpeed,
            Defense defense,
            MoveSpeed moveSpeed)
        {
            AttackPower = attackPower;
            CriticalChance = criticalChance;
            CriticalDamage = criticalDamage;
            AttackRange = attackRange;
            AttackSpeed = attackSpeed;
            Defense = defense;
            MoveSpeed = moveSpeed;
        }

        /// <summary> キャラクターの攻撃力を取得するプロパティ。 </summary>
        public AttackPower AttackPower { get; }

        /// <summary> キャラクターのクリティカル発生確率を取得するプロパティ。 </summary>
        public CriticalChance CriticalChance { get; }

        /// <summary> キャラクターのクリティカル発生時の倍率を取得するプロパティ。 </summary>
        public CriticalDamage CriticalDamage { get; }

        /// <summary> キャラクターの攻撃範囲を取得するプロパティ。 </summary>
        public AttackRange AttackRange { get; }

        /// <summary> キャラクターの攻撃速度を取得するプロパティ。 </summary>
        public AttackSpeed AttackSpeed { get; }

        /// <summary> キャラクターの防御力を取得するプロパティ。 </summary>
        public Defense Defense { get; }

        /// <summary> キャラクターの移動速度を取得するプロパティ。 </summary>
        public MoveSpeed MoveSpeed { get; }
    }
}