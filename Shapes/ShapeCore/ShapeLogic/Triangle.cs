using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCore.ShapeLogic
{
    public class Triangle : ShapeBase
    {
        public override string ShapeType { get { return "Triangle"; } }
        public override decimal Area { get { return BaseLength * Height / 2; } }
        public override sealed string Color { get; set; }
        public decimal BaseLength { get; private set; }
        public decimal Height { get; private set; }

        public Triangle(decimal baseLength, decimal height, string color) {
            BaseLength = baseLength;
            Height = height;
            Color = color;
        }
    }
}
