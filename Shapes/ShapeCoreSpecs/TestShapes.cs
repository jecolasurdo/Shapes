﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs
{
    public class Triangle1 : ShapeBase
    {
        public override string ShapeType { get { return "triangle"; } }
        public override decimal Area { get { return (decimal)15; } }
        public override string Color { get { return "yellow"; } }
    }

    public class Square : ShapeBase
    {
        public override string ShapeType { get { return "square"; } }
        public override decimal Area { get { return (decimal)64; } }
        public override string Color { get { return "red"; } }
    }

    public class Circle : ShapeBase
    {
        public override string ShapeType { get { return "circle"; } }
        public override decimal Area { get { return (decimal)9; } }
        public override string Color { get { return "blue"; } }
    }

    public class Triangle2 : ShapeBase
    {
        public override string ShapeType { get { return "triangle"; } }
        public override decimal Area { get { return (decimal)15; } }
        public override string Color { get { return "green"; } }
    }

    public class Rectangle : ShapeBase
    {
        public override string ShapeType { get { return "rectangle"; } }
        public override decimal Area { get { return (decimal)50; } }
        public override string Color { get { return "purple"; } }
    }
}
