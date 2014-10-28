using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute.Core;
using NUnit.Framework;
using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs
{

    [TestFixture]
    public class ShapeBaseSpecs
    {
        [Test]
        public void ShapeBase_Comparer_SortsFirstByAreaThenByColor() {
            var t1 = new Triangle1();
            var s = new Square();
            var c = new Circle();
            var t2 = new Triangle2();
            var r = new Rectangle();
            var shapeList = new List<ShapeBase>();
            
            shapeList.AddRange(new ShapeBase[] {t1, s, c, t2, r});
            shapeList.Sort();

            var actualResult = shapeList;
            var expectedResult = new ShapeBase[] {t2, t1, c, r, s};
            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));
        }
    }
}
