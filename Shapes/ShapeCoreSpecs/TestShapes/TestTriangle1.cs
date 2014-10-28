using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.TestShapes
{
    public class TestTriangle1 : ShapeBase
    {
        public override string ShapeType { get { return "Triangle"; } }
        public override decimal Area { get { return (decimal)15; } }
        public override string Color { get { return "Green"; } set { throw new System.NotImplementedException(); } }
    }
}
