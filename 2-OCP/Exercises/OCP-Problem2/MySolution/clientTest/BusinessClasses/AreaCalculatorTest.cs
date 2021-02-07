using Client.BusinessClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace clientTest.BusinessClasses
{
    [TestClass]
    public class AreaCalculatorTest
    {
        private AreaCalculator areaCalculator = new AreaCalculator();
        private Mock<IShape> shape = new Mock<IShape>();
               
        [TestMethod]
        public void TestAreaMessage_OneShape_ReturnMessage()
        {
            string Message = $"NameShape: 23.5";

            shape.Setup(x => x.ToString()).Returns(Message);

            Assert.AreEqual(Message, areaCalculator.AreaMessage(shape.Object));
        }

        [TestMethod]
        public void TestAreaMessage_TwoShapes_ReturnMessages()
        {
            var shape2 = new Mock<IShape>();

            string MessageShape1 = $"NameShape1: 23.5";
            string MessageShape2 = $"NameShape2: 593.8";

            List<IShape> ShapesList = new List<IShape>
            {
                shape.Object,
                shape2.Object
            };
                        
            shape.Setup(x => x.ToString()).Returns(MessageShape1);
            shape2.Setup(x => x.ToString()).Returns(MessageShape2);

            var messageList = areaCalculator.AreaMessage(ShapesList);

            Assert.AreEqual(2, messageList.Count);
            Assert.IsTrue(messageList.Exists(x => x.Equals(MessageShape1)));
            Assert.IsTrue(messageList.Exists(x => x.Equals(MessageShape2)));
        }
    }
}
