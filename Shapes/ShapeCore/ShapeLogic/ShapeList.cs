using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCore.ShapeLogic
{
    public class ShapeList : ShapeListBase
    {
        /// <summary>
        /// Exports the current list in a string with each item separated by line breaks.
        /// </summary>
        public override string ToString() {
            var output = string.Empty;
            foreach (var shape in this)
            {
                output += string.Format("{0}, {1}, {2}\n", shape.ShapeType, shape.Area.ToString("F2"), shape.Color);
            }
            return output;
        }

        /// <summary>
        /// Accepts a string and attempts to fill the list based on the values found within.
        /// </summary>
        public override void FillFromString() {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a subset of this list where the shape names are equal to the specified shape name.
        /// </summary>
        public override IShapeList GetSubListOfType(string shapeName) {
            throw new NotImplementedException();
        }
    }
}
