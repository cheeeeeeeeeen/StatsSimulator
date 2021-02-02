namespace StatsSimulator.Objects
{
    /// <summary>
    /// Object that contains all the requirements to begin a simulation.
    /// Treat it like a character who has stats that determine their capabilities.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// The type of offensive capability this character has.
        /// </summary>
        public Offense.Basic offense;

        public Character()
        {
        }
    }
}