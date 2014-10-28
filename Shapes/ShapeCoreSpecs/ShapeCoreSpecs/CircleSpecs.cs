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
    public class CircleSpecs
    {
        [Test]
        public void Circle_Normally_CalculatesAreaCorrectly() {
            var radius = 3;
            var circle = new Circle(radius);

            var actualResult = circle.Area;
            var expectedResult = (decimal) Math.PI*3*3;

            Assert.AreEqual(actualResult,expectedResult);
        }

        [Test]
        public void Circle_ShapeName_IsCircle() {
            var aValueThatDoesntMatter = 3;
            var circle = new Circle(aValueThatDoesntMatter);

            var actualResult = circle.ShapeType;
            var expectedResult = "Circle";

            Assert.AreEqual(actualResult,expectedResult);
        }

        [Test]
        public void Circle_GivenANegativeRadius_ThrowsArgumentOutOfRangeException() {
            Assert.Inconclusive();
        }

        [Test]
        public void Circle_GivenAnEmptyColor_ThrowsInvalidArgumentException() {
            Assert.Inconclusive();
        }
    }
}
