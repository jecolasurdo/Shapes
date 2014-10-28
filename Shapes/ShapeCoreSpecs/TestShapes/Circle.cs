using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.TestShapes
{
    public class Circle : ShapeBase
    {
        public override string ShapeType { get { return "circle"; } }
        public override decimal Area { get { return (decimal)28.27; } }
        public override string Color { get { return "blue"; } set { throw new System.NotImplementedException(); } }
    }
}