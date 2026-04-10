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
            Defense defense,
            AttackParams attackParams,
            MovementParams movementParams)
        {
            Name = name;
            HealthEntity = healthEntity;
            Defense = defense;
            AttackParams = attackParams;
            MovementParams = movementParams;
        }

        /// <summary> キャラクターの名前を取得するプロパティ。 </summary>
        public CharacterName Name { get; }

        /// <summary> キャラクターの体力値を管理するエンティティを取得するプロパティ。 </summary>
        public HealthEntity HealthEntity { get; }

        /// <summary> キャラクターの攻撃に関するパラメータを取得するプロパティ。 </summary>
        public AttackParams AttackParams { get; }

        /// <summary> キャラクターの移動に関するパラメータを取得するプロパティ。 </summary>
        public MovementParams MovementParams { get; }

        public AttackPower AttackPower => AttackParams.AttackPower;
        public CriticalChance CriticalChance => AttackParams.CriticalChance;
        public CriticalDamage CriticalDamage => AttackParams.CriticalDamage;
        public Health CurrentHealth => HealthEntity.CurrentHealth;
        public Health MaxHealth => HealthEntity.MaxHealth;
        public Defense Defense { get; }

        /// <summary>
        ///     被ダメージを受け取るメソッド。ダメージ量を引数として受け取り、体力値を減少させる処理を行う。
        ///     次の体力値が0未満になる場合は、0に設定される。
        /// </summary>
        /// <param name="damage"> 被ダメージの量 </param>
        public void TakeDamage(Damage damage)
        {
            float nextHealthValue = Mathf.Min(0, CurrentHealth.Value - damage.Value);
            Health nextHealth = new Health(nextHealthValue);
            HealthEntity.ChangeHealth(nextHealth);
        }
    }
}