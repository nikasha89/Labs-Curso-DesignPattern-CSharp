using Client.BusinessClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace clientTest.BusinessClasses
{
    [TestClass]
    public class CircleTest
    {
        private const double CircleArea = 88.24733763933729;
        private readonly Circle CircleShape = new Circle { Radius = 5.3 };
               
        [TestMethod]
        public void TestAreaMessage_OneCircle_ReturnCircleArea()
        {
            Assert.AreEqual(CircleArea, CircleShape.Area());
        }

        [TestMethod]
        public void TestAreaMessage_OneCircle_ReturnCircleString()
        {
            Assert.AreEqual($"{Circle.ShapeName}: {CircleArea}", CircleShape.ToString());
        }
    }
}
