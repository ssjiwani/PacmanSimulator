using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PacmanSimulator;

namespace PacmanSimulatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_PlacePacman_Success()
        {
            bool expected = true;
            Pacman p = new Pacman();
            p.PlacePacman("2", "2", "NORTH");
            Assert.AreEqual(expected, p.IsPlaced);
        }

        [TestMethod]
        public void Test_PlacePacman_NegativeXIndex()
        {
            bool expected = false;
            Pacman p = new Pacman();
            p.PlacePacman("-2","2","NORTH");
            Assert.AreEqual(expected, p.IsPlaced);
        }

        [TestMethod]
        public void Test_PlacePacman_NonIntegerXIndex()
        {
            bool expected = false;
            Pacman p = new Pacman();
            p.PlacePacman("A", "2", "NORTH");
            Assert.AreEqual(expected, p.IsPlaced);
        }

        [TestMethod]
        public void Test_PlacePacman_OutOfGridXIndex()
        {
            bool expected = false;
            Pacman p = new Pacman();
            p.PlacePacman("26", "2", "NORTH");
            Assert.AreEqual(expected, p.IsPlaced);
        }

        [TestMethod]
        public void Test_PlacePacman_NegativeYIndex()
        {
            bool expected = false;
            Pacman p = new Pacman();
            p.PlacePacman("2", "-2", "NORTH");
            Assert.AreEqual(expected, p.IsPlaced);
        }

        [TestMethod]
        public void Test_PlacePacman_NonIntegerYIndex()
        {
            bool expected = false;
            Pacman p = new Pacman();
            p.PlacePacman("1", "D", "NORTH");
            Assert.AreEqual(expected, p.IsPlaced);
        }

        [TestMethod]
        public void Test_PlacePacman_OutOfGridYIndex()
        {
            bool expected = false;
            Pacman p = new Pacman();
            p.PlacePacman("2", "25", "NORTH");
            Assert.AreEqual(expected, p.IsPlaced);
        }

        [TestMethod]
        public void Test_PlacePacman_FaceOutofEnumIndex()
        {
            bool expected = false;
            Pacman p = new Pacman();
            p.PlacePacman("2", "2", "NORTHWEST");
            Assert.AreEqual(expected, p.IsPlaced);
        }

        [TestMethod]
        public void Test_Move()
        {
            int expected = 1;
            Pacman p = new Pacman();
            p.PlacePacman("0", "0", "NORTH");
            p.Move();
            Assert.AreEqual(expected, p.Y);
        }


        [TestMethod]
        public void Test_Move_OutOfGrid1()
        {
            int expected = 0;
            Pacman p = new Pacman();
            p.PlacePacman("0", "0", "WEST");
            p.Move();
            Assert.AreEqual(expected, p.X);
        }
        [TestMethod]
        public void Test_Move_OutOfGrid2()
        {
            int expected = 4;
            Pacman p = new Pacman();
            p.PlacePacman("4", "4", "NORTH");
            p.Move();
            Assert.AreEqual(expected, p.Y);
        }
        [TestMethod]
        public void Test_Right()
        {
            FACE expected = FACE.EAST;
            Pacman p = new Pacman();
            p.PlacePacman("4", "4", "NORTH");
            p.Right();
            Assert.AreEqual(expected, p.CurrentFace);
        }
        [TestMethod]
        public void Test_Left()
        {
            FACE expected = FACE.WEST;
            Pacman p = new Pacman();
            p.PlacePacman("4", "4", "NORTH");
            p.Left();
            Assert.AreEqual(expected, p.CurrentFace);
        }
    }
}
