using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ShapeCore.ComponentModel
{
    public interface IShapeList
    {
        string ToString();
        void FillFromString();
        IShapeList GetSubListOfType(string shapeName);
    }
}
