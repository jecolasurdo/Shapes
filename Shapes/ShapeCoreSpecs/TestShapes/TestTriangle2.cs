using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.TestShapes
{
    public class TestTriangle2 : ShapeBase
    {
        public override string ShapeType { get { return "triangle"; } }
        public override decimal Area { get { return (decimal)15; } }
        public override string Color { get { return "yellow"; } set { throw new System.NotImplementedException(); } }
    }
}