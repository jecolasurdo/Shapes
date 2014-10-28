﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shapes.ShapeCore.ComponentModel;
using Shapes.ShapeCore.ShapeLogic;
using Shapes.ShapeCoreSpecs.TestShapes;

namespace Shapes.ShapeCoreSpecs.ShapeLogicSpecs
{
    [TestFixture]
    public class ShapeListSpecs
    {
        [Test]
        public void ToString_Normally_OutputsListToString() {
            var c = new TestCircle();
            var r = new TestRectangle();
            var s = new TestSquare();
            var t = new TestTriangle1();
            var shapeList = new ShapeList();
            shapeList.AddRange(new ShapeBase[] {c,r,s,t});

            var actualResult = shapeList.ToString();
            var expectedResult = "Circle, 28.27, Blue\n" +
                                 "Rectangle, 50.00, Purple\n" +
                                 "Square, 64.00, Purple\n" +
                                 "Triangle, 15.00, Green\n";

            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
