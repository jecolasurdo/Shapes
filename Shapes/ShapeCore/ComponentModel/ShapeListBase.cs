using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ShapeCore.ComponentModel
{
    public abstract class ShapeListBase : List<IShape>, IShapeList
    {
        public new abstract string ToString();
        public abstract void FillFromString();
        public abstract IShapeList GetSubListOfType(string shapeName);
    }
}
