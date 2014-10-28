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
    public class SquareSpecs
    {
        [Test]
        public void Square_Normally_CalculatesAreaCorrectly()
        {
            var aValueThatDoesntMatter = string.Empty;
            var length = 3;
            var square = new Square(length, aValueThatDoesntMatter);

            var actualResult = square.Area;
            var expectedResult = length * length;

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Square_ShapeName_IsSquare()
        {
            var aStringThatDoesntMatter = string.Empty;
            var aDecimalThatDoesntMatter = 3;
            var square = new Square(aDecimalThatDoesntMatter, aStringThatDoesntMatter);

            var actualResult = square.ShapeType;
            var expectedResult = "Square";

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Square_ShapeColor_GetsSet()
        {
            var aValueThatDoesntMatter = 3;
            var someColor = "blue";
            var square = new Square(aValueThatDoesntMatter, someColor);

            var actualColor = square.Color;
            var expectedColor = someColor;

            Assert.AreEqual(expectedColor, actualColor);
        }
    }
}
