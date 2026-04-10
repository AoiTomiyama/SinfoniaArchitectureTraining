using SSTraining.Runtime.Application.InGame.Battle;
using SymphonyFrameWork.Attribute;
using UnityEngine;

namespace SSTraining.Runtime.InfraStructure.InGame.Battle
{
    /// <summary>
    ///     攻撃の処理の流れを定義するScriptableObject。攻撃の各ステップを組み合わせて、攻撃の処理の流れを定義するためのもの。
    /// </summary>
    [CreateAssetMenu(fileName = nameof(AttackPipelineAsset), menuName = "SSTraining/Scriptable Object/AttackPipeline")]
    public class AttackPipelineAsset : ScriptableObject
    {
        /// <summary>
        ///     設定された攻撃ステップを基にした攻撃の処理の流れを表すAttackPipelineを生成するメソッド。
        /// </summary>
        /// <returns></returns>
        public AttackPipeline CreateAttackPipeline() => new(_attackSteps);

        [SerializeReference]
        [SubclassSelector]
        [Tooltip("攻撃の処理の流れを定義するステップのリスト。")]
        private IAttackStep[] _attackSteps;
    }
}