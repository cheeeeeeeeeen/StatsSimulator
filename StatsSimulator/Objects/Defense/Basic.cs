namespace StatsSimulator.Objects.Defense
{
    /// <summary>
    /// Object that contains the basic information required for defensive capability.
    /// </summary>
    public class Basic
    {
        /// <summary>
        /// Defines the basic defense power.
        /// </summary>
        public float defenseValue;

        /// <summary>
        /// Constructor of the class to input the defense power.
        /// </summary>
        /// <param name="defense">Defense power base value</param>
        public Basic(float defenseValue)
        {
            this.defenseValue = defenseValue;
        }

        /// <summary>
        /// Public interface to use to perform a defense from an attacker.
        /// </summary>
        /// <param name="attacker">The attacker of the action</param>
        /// <returns>The final damage value received</returns>
        public float Perform(Character attacker)
        {
            float damageTaken = attacker.offenseCapability.attackValue;
            try
            {
                damageTaken = PerformAction(attacker);
            }
            catch
            {
                damageTaken = FallbackAction(attacker);
            }
            return damageTaken;
        }

        /// <summary>
        /// Interface to use for implementing the process of the defense.
        /// </summary>
        /// <param name="attacker">The attacker of the action</param>
        /// <returns>The damage output received</returns>
        protected virtual float PerformAction(Character attacker)
        {
            return attacker.offenseCapability.attackValue - defenseValue;
        }

        /// <summary>
        /// Interface to use for implementing the process of the defense.
        /// When the attacker is incompatible, fallback action will be used.
        /// Implementation here should be compatible with Defense.Basic.
        /// </summary>
        /// <param name="attacker">The attacker of the action</param>
        /// <returns>The damage output received</returns>
        protected virtual float FallbackAction(Character attacker)
        {
            return 0f;
        }
    }
}