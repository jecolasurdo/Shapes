using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.TestShapes
{
    public class TestSquare : ShapeBase
    {
        public override string ShapeType { get { return "Square"; } }
        public override decimal Area { get { return (decimal)64; } }
        public override string Color { get { return "Purple"; } set { throw new System.NotImplementedException(); } }
    }
}