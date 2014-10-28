using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.TestShapes
{
    public class TestRectangle : ShapeBase
    {
        public override string ShapeType { get { return "Rectangle"; } }
        public override decimal Area { get { return (decimal)50; } }
        public override string Color { get { return "Purple"; } set { throw new System.NotImplementedException(); } }
    }
}