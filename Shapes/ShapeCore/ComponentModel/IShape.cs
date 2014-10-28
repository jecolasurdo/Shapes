using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ShapeCore.ComponentModel
{
    public interface IShape : IComparable<IShape>, IEquatable<IShape>
    {
        string ShapeType { get; }
        decimal Area { get; }
        string Color { get; }
    }
}
