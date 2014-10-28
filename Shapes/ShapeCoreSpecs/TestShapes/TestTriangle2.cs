using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.TestShapes
{
    public class TestTriangle2 : ShapeBase
    {
        public override string ShapeType { get { return "Triangle"; } }
        public override decimal Area { get { return (decimal)15; } }
        public override string Color { get { return "Yellow"; } set { throw new System.NotImplementedException(); } }
    }
}