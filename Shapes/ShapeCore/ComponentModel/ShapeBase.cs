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

        public abstract string ShapeType { get; }
        public abstract decimal Area { get; }
        public abstract string Color { get; }
    }
}
