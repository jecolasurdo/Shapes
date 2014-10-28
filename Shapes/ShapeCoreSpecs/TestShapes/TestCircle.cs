using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.TestShapes
{
    public class TestCircle : ShapeBase
    {
        public override string ShapeType { get { return "Circle"; } }
        public override decimal Area { get { return (decimal)28.27; } }
        public override string Color { get { return "Blue"; } set { throw new System.NotImplementedException(); } }
    }
}