using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCore.ShapeLogic
{
    public class Circle : ShapeBase
    {
        public override string ShapeType { get { return "Circle"; } }
        public override decimal Area { get { throw new NotImplementedException(); } }
        public override string Color { get { throw new NotImplementedException(); } }
        public double Radius { get; private set; }
        
        public Circle(decimal radius) {
            throw new NotImplementedException();
        }
    }
}
