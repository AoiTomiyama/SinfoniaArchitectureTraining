using UnityEngine;

namespace SSTraining.Runtime.InfraStructure.InGame.Character
{
    /// <summary>
    ///     キャラクターの基本的なデータを格納するためのScriptableObjectクラス。
    /// </summary>
    [CreateAssetMenu(fileName = nameof(CharacterDataAsset), menuName = "SSTraining/Scriptable Object/CharacterData")]
    public class CharacterDataAsset : ScriptableObject
    {
        [SerializeField, Tooltip("キャラクターの名前。")]
        private string _characterName;

        [SerializeField, Tooltip("キャラクターの最大体力。")]
        private float _maxHealth;

        [SerializeField, Tooltip("キャラクターの防御力。")]
        private float _defense;

        [SerializeField, Tooltip("キャラクターの移動速度。")]
        private float _moveSpeed;

        [SerializeField, Tooltip("キャラクターの攻撃力。")]
        private float _attackPower;

        [SerializeField, Tooltip("キャラクターの攻撃範囲。")]
        private float _attackRange;

        [SerializeField, Tooltip("キャラクターの攻撃速度。1秒あたりの攻撃回数を表す。")]
        private float _attackSpeed;

        [SerializeField, Tooltip("キャラクターのクリティカルヒットが発生する確率。範囲は0から100。")]
        private float _criticalChance;

        [SerializeField, Tooltip("キャラクターのクリティカルダメージ倍率。")]
        private float _criticalDamage;

        public string CharacterName => _characterName;
        public float MaxHealth => _maxHealth;
        public float Defense => _defense;
        public float MoveSpeed => _moveSpeed;
        public float AttackPower => _attackPower;
        public float AttackRange => _attackRange;
        public float AttackSpeed => _attackSpeed;
        public float CriticalChance => _criticalChance;
        public float CriticalDamage => _criticalDamage;
    }
}