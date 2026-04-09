namespace SSTraining.Runtime.Domain.InGame.Battle
{
    /// <summary>
    ///     現在体力値と最大体力値を表すエンティティクラス。
    /// </summary>
    public class HealthEntity
    {
        public HealthEntity(float health)
        {
            CurrentHealth = new Health(health);
            MaxHealth = new Health(health);
        }

        public Health CurrentHealth { get; private set; }
        public readonly Health MaxHealth;

        /// <summary>
        ///     現在体力値を変更するメソッド。最大体力値を超える場合は、最大体力値に設定される。
        /// </summary>
        /// <param name="value"> 変更後の体力値 </param>
        public void ChangeHealth(Health value)
        {
            if (value > MaxHealth)
            {
                value = MaxHealth;
            }

            CurrentHealth = value;
        }
    }
}