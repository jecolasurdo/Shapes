using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shapes.ShapeCore.ShapeLogic;

namespace Shapes.ShapeCoreSpecs.ShapeCoreSpecs
{
    [TestFixture]
    public class RectangleSpecs
    {
        [Test]
        public void Rectangle_Name_IsRectangle() {
            var aValueThatDoesntMatter = 3;
            var rectangle = new Rectangle(aValueThatDoesntMatter, aValueThatDoesntMatter);

            var actualResult = rectangle.ShapeType;
            var expectedResult = "Rectangle";

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Rectangle_Area_CalculatesCorrectly() {
            var length = 3;
            var width = 5;
            var rectangle = new Rectangle(length, width);

            var actualResult = rectangle.Area;
            var expectedResult = length * width;

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
