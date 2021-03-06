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

        [Test]
        public void FillFromString_Normally_FillsTheListFromAString() {
            var c = new Circle(3,"Blue");
            var r = new Rectangle(10,5,"Purple");
            var s = new Square(8,"Purple");
            var t = new Triangle(5,6,"Green");
            var expectedShapeList = new ShapeList();
            expectedShapeList.AddRange(new ShapeBase[] { c, r, s, t });

            var stringToFillFrom = "Circle, 3, Blue\n" +
                                 "Rectangle, 10, 5, Purple\n" +
                                 "Square, 8, Purple\n" +
                                 "Triangle, 5, 6, Green\n";
            var actualShapeList = new ShapeList();
            actualShapeList.FillFromString(stringToFillFrom);

            Assert.IsTrue(actualShapeList.SequenceEqual(expectedShapeList));
        }

        [Test]
        public void FillFromString_StringIsMalformed_ThrowsAnInvalidArgumentException() {
            var malFormedString = "Circle, t, Blue\n" +
                                 "Rectangle, 10, 5, Purple\n" +
                                 "Square, 8, Purple\n" +
                                 "Triangle, 5, 6, Green\n";
            var shapeList = new ShapeList();
            Assert.Throws<ArgumentException>(() => shapeList.FillFromString(malFormedString));
        }

        [Test]
        public void FillFromString_ListIsInitiallyFilled_ReplacesExistingValuesWithNew() {
            var c = new Circle(3, "Blue");
            var r = new Rectangle(10, 5, "Purple");
            var s = new Square(8, "Purple");
            var t = new Triangle(5, 6, "Green");
            var shapeList = new ShapeList();
            shapeList.AddRange(new ShapeBase[] { c, r, s, t });

            var expectedShapeList = new ShapeList();
            expectedShapeList.Add(new Square(7,"Turnip"));
            var stringToFillFrom = "Square, 7, Turnip\n";
            shapeList.FillFromString(stringToFillFrom);
            var actualShapeList = shapeList;

            Assert.IsTrue(actualShapeList.SequenceEqual(expectedShapeList));
        }

        [Test]
        public void GetSubListOfType_Normally_ReturnsTheExpectedSubList() {
            var c = new Circle(3, "Blue");
            var r1 = new Rectangle(10, 5, "Purple");
            var s = new Square(8, "Purple");
            var t = new Triangle(5, 6, "Green");
            var r2 = new Rectangle(10, 5, "Orange");
            var shapeList = new ShapeList();
            shapeList.AddRange(new ShapeBase[] { c, r1, s, t, r2 });

            var expectedResult = new ShapeList();
            expectedResult.AddRange(new ShapeBase[] { r1, r2 });
            var actualResult = (ShapeList)shapeList.GetSubListOfType("Rectangle");

            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));
        }
    }
}
