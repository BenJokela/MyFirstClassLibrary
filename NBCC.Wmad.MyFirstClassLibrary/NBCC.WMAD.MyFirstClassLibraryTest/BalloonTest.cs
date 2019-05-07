using Microsoft.VisualStudio.TestTools.UnitTesting;
using NBCC.Wmad.MyFirstClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC.WMAD.MyFirstClassLibraryTest
{
    [TestClass]
    public class BalloonTest
    {
        /// <summary>
        /// This is a positive test for Color red - GET
        /// </summary>
        [TestMethod]
        public void Color_Positive_GET()
        {
            Balloon target = new Balloon();
            string expected = "RED";
            target.Color = "RED";
            Assert.AreEqual(target.Color, expected);
        }
        /// <summary>
        /// testing the private field
        /// </summary>
        [TestMethod]
        public void Color_Field_Positive_GET()
        {
            Balloon target = new Balloon();
            //use the privateobject when testing the private field
            PrivateObject pObject = new PrivateObject(target);
            string expected = "RED";
            pObject.SetField("color", expected);
            Assert.AreEqual(expected, pObject.GetField("color"));
        }

        [TestMethod]
        public void Color_Positive_SET_Red()
        {
            Balloon target = new Balloon();
            string expected = "red";
            target.Color = expected;
            Assert.AreEqual(expected, target.Color);
        }
        [TestMethod]
        public void Color_Positive_SET_Blue()
        {
            Balloon target = new Balloon();
            string expected = "blue";
            target.Color = expected;
            Assert.AreEqual(expected, target.Color);
        }
        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void Color_Negative_Pink()
        {
            Balloon target = new Balloon();
            target.Color = "pink";
        }
        [TestMethod]
        public void Diameter_Positive_SET_RedMax()
        {
            Balloon testBalloon = new Balloon();
            int expected = 12;
            testBalloon.Color = "RED";
            testBalloon.Diameter = expected;
            Assert.AreEqual(expected, testBalloon.Diameter);
        }
        [TestMethod]
        public void Diameter_Positive_SET_RedMin()
        {
            Balloon testBalloon = new Balloon();
            //PrivateObject pObject = new PrivateObject(testBalloon);
            //pObject.SetField("color", "RED");
            testBalloon.Color = "RED";
            int expected = 1;
            testBalloon.Diameter = expected;
            Assert.AreEqual(testBalloon.Diameter, expected);
        }
        [TestMethod]
        public void Diameter_Positive_SET_BlueMax()
        {
            Balloon testBalloon = new Balloon();
            int expected = 10;
            testBalloon.Color = "BLUE";
            testBalloon.Diameter = expected;
            Assert.AreEqual(expected, testBalloon.Diameter);
        }
        [TestMethod]
        public void Diameter_Positive_SET_BlueMin()
        {
            Balloon testBalloon = new Balloon();
            int expected = 1;
            testBalloon.Color = "BLUE";
            testBalloon.Diameter = expected;
            Assert.AreEqual(testBalloon.Diameter, expected);
        }
        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void Diameter_Negative_RedMax()
        {
            Balloon testBalloon = new Balloon();
            testBalloon.Color = "RED";
            testBalloon.Diameter = 13;
        }
        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void Diameter_Negative_RedMin()
        {
            Balloon testBalloon = new Balloon();
            testBalloon.Color = "RED";
            testBalloon.Diameter = 0;
        }
        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void Diameter_Negative_BlueMax()
        {
            Balloon testBalloon = new Balloon();
            testBalloon.Color = "BLUE";
            testBalloon.Diameter = 11;
        }
        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void Diameter_Negative_BlueMin()
        {
            Balloon testBalloon = new Balloon();
            testBalloon.Color = "BLUE";
            testBalloon.Diameter = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void Diameter_Negative_NoColor()
        {
            Balloon testBalloon = new Balloon();
            testBalloon.Diameter = 5;
        }



    }
}
