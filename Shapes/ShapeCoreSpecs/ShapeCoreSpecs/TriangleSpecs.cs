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
    public class TriangleSpecs
    {
        [Test]
        public void Triangle_Name_IsTriangle()
        {
            var aStringThatDoesntMatter = string.Empty;
            var aValueThatDoesntMatter = 3;
            var triangle = new Triangle(aValueThatDoesntMatter, aValueThatDoesntMatter, aStringThatDoesntMatter);

            var actualResult = triangle.ShapeType;
            var expectedResult = "Triangle";

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Triangle_Area_CalculatesCorrectly()
        {
            var aStringThatDoesntMatter = string.Empty;
            var baseLength = 3;
            var height = 10;
            var triangle = new Triangle(baseLength, height, aStringThatDoesntMatter);

            var actualResult = triangle.Area;
            var expectedResult = baseLength * height / 2;

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Triangle_ShapeColor_GetsSet()
        {
            var aValueThatDoesntMatter = 3;
            var someColor = "blue";
            var triangle = new Triangle(aValueThatDoesntMatter, aValueThatDoesntMatter, someColor);

            var actualColor = triangle.Color;
            var expectedColor = someColor;

            Assert.AreEqual(expectedColor, actualColor);
        }
    }
}
