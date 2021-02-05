namespace StatsSimulator.Objects.Offense
{
    /// <summary>
    /// Object that contains the basic information required for offensive capability.
    /// </summary>
    public class Basic
    {
        /// <summary>
        /// Defines the basic attack power.
        /// </summary>
        public float attackValue;

        /// <summary>
        /// Constructor of the class to input the attack power.
        /// </summary>
        /// <param name="attack">Attack power base value</param>
        public Basic(float attackValue)
        {
            this.attackValue = attackValue;
        }

        /// <summary>
        /// Public interface to use to perform an attack towards a target.
        /// </summary>
        /// <param name="target">The target affected of the action</param>
        /// <returns>The final damage value dealt</returns>
        public float Perform(Character target)
        {
            float damage = 0f;
            try
            {
                damage = PerformAction(target);
            }
            catch
            {
                damage = FallbackAction(target);
            }
            return damage;
        }

        /// <summary>
        /// Interface to use for implementing the process of the attack.
        /// </summary>
        /// <param name="target">The target affected of the action</param>
        /// <returns>The damage output dealt</returns>
        protected virtual float PerformAction(Character target)
        {
            return attackValue - target.defenseCapability.defenseValue;
        }

        /// <summary>
        /// Interface to use for implementing the process of the attack.
        /// When the target is incompatible, fallback action will be used.
        /// Implementation here should be compatible with Offense.Basic.
        /// </summary>
        /// <param name="target">The target affected of the action</param>
        /// <returns>The damage output dealt</returns>
        protected virtual float FallbackAction(Character target)
        {
            return 0f;
        }
    }
}