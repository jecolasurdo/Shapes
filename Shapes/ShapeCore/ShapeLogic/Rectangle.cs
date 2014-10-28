using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCore.ShapeLogic
{
    public class Rectangle : ShapeBase
    {
        public override string ShapeType { get { return "Rectangle"; } }
        public override decimal Area { get { return Length*Width; } }
        public override sealed string Color { get; set; }
        public decimal Length { get; private set; }
        public decimal Width { get; private set; }

        public Rectangle(decimal length, decimal width, string color) {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}
