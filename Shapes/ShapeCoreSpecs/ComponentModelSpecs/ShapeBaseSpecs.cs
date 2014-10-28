using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Shapes.ShapeCore.ComponentModel;
using Shapes.ShapeCoreSpecs.TestShapes;

namespace Shapes.ShapeCoreSpecs.ComponentModelSpecs
{

    [TestFixture]
    public class ShapeBaseSpecs
    {
        [Test]
        public void ShapeBase_Comparer_SortsFirstByAreaThenByColor() {
            var t1 = new TestTriangle1();
            var s = new TestSquare();
            var c = new TestCircle();
            var t2 = new TestTriangle2();
            var r = new TestRectangle();
            var shapeList = new List<ShapeBase>();
            
            shapeList.AddRange(new ShapeBase[] {s, t1, c, t2, r});
            shapeList.Sort();

            var actualResult = shapeList;
            var expectedResult = new ShapeBase[] {t1, t2, c, r, s};
            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));
        }
    }
}
