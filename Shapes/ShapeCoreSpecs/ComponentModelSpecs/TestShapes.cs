using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.ComponentModelSpecs
{
    public class Triangle1 : ShapeBase
    {
        public override string ShapeType { get { return "triangle"; } }
        public override decimal Area { get { return (decimal)15; } }
        public override string Color { get { return "green"; } set { throw new System.NotImplementedException(); } }
    }

    public class Triangle2 : ShapeBase
    {
        public override string ShapeType { get { return "triangle"; } }
        public override decimal Area { get { return (decimal)15; } }
        public override string Color { get { return "yellow"; } set { throw new System.NotImplementedException(); } }
    }

    public class Circle : ShapeBase
    {
        public override string ShapeType { get { return "circle"; } }
        public override decimal Area { get { return (decimal)28.27; } }
        public override string Color { get { return "blue"; } set { throw new System.NotImplementedException(); } }
    }

    public class Rectangle : ShapeBase
    {
        public override string ShapeType { get { return "rectangle"; } }
        public override decimal Area { get { return (decimal)50; } }
        public override string Color { get { return "purple"; } set { throw new System.NotImplementedException(); } }
    }

    public class Square : ShapeBase
    {
        public override string ShapeType { get { return "square"; } }
        public override decimal Area { get { return (decimal)64; } }
        public override string Color { get { return "purple"; } set { throw new System.NotImplementedException(); } }
    }


}
