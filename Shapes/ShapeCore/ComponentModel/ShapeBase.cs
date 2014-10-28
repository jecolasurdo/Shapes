using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ShapeCore.ComponentModel
{
    public abstract class ShapeBase : IShape
    {
        public int CompareTo(IShape other) {
            throw new NotImplementedException();
        }

        public string ShapeType { get; private set; }
        public decimal Area { get; private set; }
        public string Color { get; private set; }
    }
}
