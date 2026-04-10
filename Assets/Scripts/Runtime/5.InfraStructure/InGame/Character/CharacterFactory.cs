using SSTraining.Runtime.Domain.InGame.Battle;
using SSTraining.Runtime.Domain.InGame.Character;

namespace SSTraining.Runtime.InfraStructure.InGame.Character
{
    /// <summary>
    ///     キャラクターのファクトリークラス。CharacterDataをもとにCharacterEntityを生成する役割を担う。
    /// </summary>
    public static class CharacterFactory
    {
        /// <summary>
        ///     CharacterDataからCharacterEntityを生成する。
        /// </summary>
        /// <param name="dataAsset">　使用するデータ。 </param>
        /// <returns> 元データに基づいて生成されたCharacterEntity。 </returns>
        public static CharacterEntity Create(CharacterDataAsset dataAsset)
        {
            AttackParams attackParams = new AttackParams(
                new AttackPower(dataAsset.AttackPower),
                new AttackSpeed(dataAsset.AttackSpeed),
                new CriticalChance(dataAsset.CriticalChance),
                new CriticalDamage(dataAsset.CriticalDamage)
            );

            MovementParams movementParams = new MovementParams(
                new MoveSpeed(dataAsset.MoveSpeed),
                new AttackRange(dataAsset.AttackRange)
            );

            return new CharacterEntity(
                new CharacterName(dataAsset.CharacterName),
                new HealthEntity(dataAsset.MaxHealth),
                new Defense(dataAsset.Defense),
                attackParams,
                movementParams
            );
        }
    }
}