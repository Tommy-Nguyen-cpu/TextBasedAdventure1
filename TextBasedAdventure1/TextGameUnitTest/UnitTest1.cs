using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TextBasedAdventure1;

namespace TextGameUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        // Example generation method. Should be removed once actual method has been implemented.
        public (bool, bool) generatedoor()
        {
            // TODO: Generate random values.
            return (false, true);
        }

        // Example player choice method. Should be removed once actual method has been implemented.
        public bool PlayerChoice(int doorChoice)
        {

            return true;
        }

        /// <summary>
        /// Tests the door generation method.
        /// 1 door should be obstacle and 1 door should be 
        /// </summary>
        [TestMethod]
        public void TestDoorsGeneration()
        {
            // TODO: Replace with actual door generation method signature.
            (bool leftDoor, bool rightDoor) = Program.GenerateDoor();


            // Checks to see that leftDoor and rightDoor ARE NOT the same value.
            Assert.IsTrue(leftDoor != rightDoor);
        }

        [TestMethod]
        public void TestPlayerChoice()
        {

            // TODO: replae with actual player choice method signature.
            bool result = PlayerChoice(1);
            Assert.IsTrue(result != null);

        }

        /// <summary>
        /// Tests method responsible for result after player chooses a door.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
