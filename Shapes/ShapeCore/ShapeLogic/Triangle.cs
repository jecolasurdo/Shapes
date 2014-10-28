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
        public override string ShapeType { get { throw new NotImplementedException(); } }
        public override decimal Area { get { throw new NotImplementedException(); } }
        public override string Color { get; set; }
        public decimal BaseLength { get; private set; }
        public decimal Height { get; private set; }

        public Triangle(decimal baseLength, decimal height, string color) {
            throw new NotImplementedException();
        }
    }
}
