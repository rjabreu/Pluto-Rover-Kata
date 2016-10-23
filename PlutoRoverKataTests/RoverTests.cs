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
        public void CanMoveUpY()
        {
            rover.IncreasePosY();

            Assert.IsTrue(rover.PositionY == 1);
        }

        [TestMethod]
        public void CanMoveUpX()
        {
            rover.IncreasePosX();
            Assert.IsTrue(rover.PositionX == 1);
        }

        [TestMethod]
        public void CanMoveDownX()
        {
            rover.IncreasePosX();
            rover.DecreasePosX();
            Assert.IsTrue(rover.PositionX == 0);
        }

        [TestMethod]
        public void CanMoveDownY()
        {
            rover.IncreasePosY();
            rover.DecreasePosY();
            Assert.IsTrue(rover.PositionY == 0);
        }



        [TestMethod]
        public void RoverIsNorth()
        {
            Assert.IsTrue(rover.Heading == "N");
        }

        [TestMethod]
        public void MoveForward()
        {
            rover = new Rover();
            rover.Move("F");
            Assert.IsTrue(rover.PositionY == 1);

        }



        [TestMethod]
        public void MoveBackward()
        {
            rover = new Rover();
            rover.Move("F,B");
            Assert.IsTrue(rover.PositionY == 0);
        }

        [TestMethod]
        public void TurnLeft()
        {
            rover = new Rover();
            rover.Move("L");
            Assert.IsTrue(rover.Heading == "E");
        }

        [TestMethod]
        public void TurnRight()
        {
            rover = new Rover();
            rover.Move("R");
            Assert.IsTrue(rover.Heading == "W");
        }

        [TestMethod]
        public void TestCase1()
        {
            rover.Move("F,F,R,F,F");
            Assert.IsTrue(rover.PositionX == 2 && rover.PositionY == 2);
        }
    }
}
