using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicDefense = StatsSimulator.Objects.Defense.Basic;
using BasicOffense = StatsSimulator.Objects.Offense.Basic;
using CharacterObject = StatsSimulator.Objects.Character;

namespace StatsSimulator.Test.Objects.Offense
{
    [TestClass]
    public class Basic
    {
        [TestMethod]
        public void Perform_CalculatesDamage_WithProperSpecifications()
        {
            BasicOffense offense = new BasicOffense(10);
            BasicDefense defense = new BasicDefense(3);
            CharacterObject target = new CharacterObject(offense, defense);

            float result = offense.Perform(target);

            Assert.AreEqual(7, result);
        }

        public void Perform_CalculatesDamage_WithoutProperSpecifications()
        {
            // Pending, not enough implementation

            Assert.IsTrue(true);
        }
    }
}