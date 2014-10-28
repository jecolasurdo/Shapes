using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ShapeCore.ComponentModel
{
    public abstract class ShapeBase : IShape
    {
        public int CompareTo(IShape other) {
            if (Area == other.Area)
            {
                return new CaseInsensitiveComparer().Compare(Color, other.Color);
            }
            if (Area > other.Area)
            {
                return 1;
            }
            return -1;
        }

        public abstract string ShapeType { get; }
        public abstract decimal Area { get; }
        public abstract string Color { get; }
    }
}
