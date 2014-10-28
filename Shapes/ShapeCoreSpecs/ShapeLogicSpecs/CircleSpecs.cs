using System;
using NUnit.Framework;
using Shapes.ShapeCore.ShapeLogic;

namespace Shapes.ShapeCoreSpecs.ShapeLogicSpecs
{
    [TestFixture]
    public class CircleSpecs
    {
        [Test]
        public void Circle_Normally_CalculatesAreaCorrectly() {
            var aValueThatDoesntMatter = string.Empty;
            var radius = 3;
            var circle = new Circle(radius, aValueThatDoesntMatter);

            var actualResult = circle.Area;
            var expectedResult = (decimal) Math.PI*3*3;

            Assert.AreEqual(actualResult,expectedResult);
        }

        [Test]
        public void Circle_ShapeName_IsCircle() {
            var aStringThatDoesntMatter = string.Empty;
            var aDecimalThatDoesntMatter = 3;
            var circle = new Circle(aDecimalThatDoesntMatter, aStringThatDoesntMatter);

            var actualResult = circle.ShapeType;
            var expectedResult = "Circle";

            Assert.AreEqual(actualResult,expectedResult);
        }

        [Test]
        public void Circle_ShapeColor_GetsSet() {
            var aValueThatDoesntMatter = 3;
            var someColor = "blue";
            var circle = new Circle(aValueThatDoesntMatter, someColor);

            var actualColor = circle.Color;
            var expectedColor = someColor;

            Assert.AreEqual(expectedColor, actualColor);
        }
    }
}
