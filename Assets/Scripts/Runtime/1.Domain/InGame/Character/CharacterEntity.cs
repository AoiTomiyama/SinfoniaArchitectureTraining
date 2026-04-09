using SSTraining.Runtime.Domain.InGame.Battle;
using UnityEngine;

namespace SSTraining.Runtime.Domain.InGame.Character
{
    /// <summary>
    ///     キャラクターの基本情報を持つエンティティクラス。
    /// </summary>
    public class CharacterEntity : IAttacker, IDefender
    {
        public CharacterEntity(
            CharacterName name,
            HealthEntity healthEntity,
            CharacterParameter parameter)
        {
            Name = name;
            HealthEntity = healthEntity;
            Parameter = parameter;
        }

        /// <summary> キャラクターの名前を取得するプロパティ。 </summary>
        public CharacterName Name { get; }

        /// <summary> キャラクターの体力値を管理するエンティティを取得するプロパティ。 </summary>
        public HealthEntity HealthEntity { get; }

        /// <summary> キャラクターの各パラメーターを取得するプロパティ。 </summary>
        public CharacterParameter Parameter { get; }

        /// <summary> キャラクターの現在体力値を取得するプロパティ。 </summary>
        public Health CurrentHealth => HealthEntity.CurrentHealth;

        /// <summary> キャラクターの最大体力値を取得するプロパティ。 </summary>
        public Health MaxHealth => HealthEntity.MaxHealth;

        public AttackPower AttackPower => Parameter.AttackPower;
        public CriticalChance CriticalChance => Parameter.CriticalChance;
        public CriticalDamage CriticalDamage => Parameter.CriticalDamage;
        public Defense Defense => Parameter.Defense;

        /// <summary>
        ///     被ダメージを受け取るメソッド。ダメージ量を引数として受け取り、体力値を減少させる処理を行う。
        ///     計算式は「次の体力値 = 現在体力値 - (ダメージ量 / 防御力)」とする。次の体力値が0未満になる場合は、0に設定される。
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(Damage damage)
        {
            float nextHealthValue = Mathf.Min(0, CurrentHealth.Value - damage.Value);
            Health nextHealth = new Health(nextHealthValue);
            HealthEntity.ChangeHealth(nextHealth);
        }
    }
}