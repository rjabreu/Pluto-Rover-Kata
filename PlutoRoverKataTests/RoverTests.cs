using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoRoverKata;

namespace PlutoRoverKataTests
{
    [TestClass]
    public class RoverTests
    {
        Rover rover;

        [TestInitialize]
        public void SetupTest()
        {
            rover = new Rover();
        }



        [TestMethod]
        public void CanMoveY()
        {
            rover.IncreasePosY();

            Assert.IsTrue(rover.PositionY == 1);
        }

        [TestMethod]
        public void CanMoveX()
        {
            rover.IncreasePosX();
            Assert.IsTrue(rover.PositionX == 1);
        }

        [TestMethod]
        public void MoveForward()
        {


        }

        [TestMethod]
        public void RoverIsNorth()
        {
            Assert.IsTrue(rover.Heading == "N");
        }

        [TestMethod]
        public void MoveBackward()
        {
        }

        [TestMethod]
        public void TurnLeft()
        {
        }

        [TestMethod]
        public void TurnRight()
        {
        }
    }
}
