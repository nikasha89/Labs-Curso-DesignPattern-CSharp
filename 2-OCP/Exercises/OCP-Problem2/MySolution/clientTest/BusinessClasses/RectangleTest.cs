using Client.BusinessClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace clientTest.BusinessClasses
{
    [TestClass]
    public class RectangleTest
    {
        private const double RectangleArea = 33.92;
        private readonly Rectangle RectangleShape = new Rectangle { Height = 5.3, Width = 6.4 };
               
        [TestMethod]
        public void TestAreaMessage_OneCircle_ReturnCircleArea()
        {
            Assert.AreEqual(RectangleArea, RectangleShape.Area());
        }

        [TestMethod]
        public void TestAreaMessage_OneCircle_ReturnCircleString()
        {
            Assert.AreEqual($"{Rectangle.ShapeName}: {RectangleArea}", RectangleShape.ToString());
        }
    }
}
