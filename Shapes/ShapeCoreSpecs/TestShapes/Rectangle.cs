using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.TestShapes
{
    public class Rectangle : ShapeBase
    {
        public override string ShapeType { get { return "rectangle"; } }
        public override decimal Area { get { return (decimal)50; } }
        public override string Color { get { return "purple"; } set { throw new System.NotImplementedException(); } }
    }
}