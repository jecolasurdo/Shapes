using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCoreSpecs.TestShapes
{
    public class Square : ShapeBase
    {
        public override string ShapeType { get { return "square"; } }
        public override decimal Area { get { return (decimal)64; } }
        public override string Color { get { return "purple"; } set { throw new System.NotImplementedException(); } }
    }
}