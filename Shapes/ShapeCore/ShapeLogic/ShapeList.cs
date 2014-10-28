using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
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
        public override void FillFromString(string stringToFillFrom) {
            var lines = stringToFillFrom.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var trimmedArgs in lines.Select(line => line.Split(',')).Select(TrimArgs))
            {
                switch (trimmedArgs[0])
                {
                    case "Circle":
                        AddCircle(trimmedArgs);
                        break;
                    case "Rectangle":
                        AddRectangle(trimmedArgs);
                        break;
                    case "Square":
                        AddSquare(trimmedArgs);
                        break;
                    case "Triangle":
                        AddTriangle(trimmedArgs);
                        break;
                    default:
                        throw new ArgumentException("The provided string contains a reference to an unknown shape type.",stringToFillFrom);
                }
            }
        }

        private void AddCircle(IList<string> args) {
            var radius = ParseDecimal(args[1]);
            var color = args[2];
            var circle = new Circle(radius, color);
            Add(circle);
        }

        private void AddRectangle(IList<string> args) {
            var length = ParseDecimal(args[1]);
            var width = ParseDecimal(args[2]);
            var color = args[3];
            var rectangle = new Rectangle(length, width, color);
            Add(rectangle);
        }

        private void AddSquare(IList<string> args)
        {
            var length = ParseDecimal(args[1]);
            var color = args[2];
            var square = new Square(length, color);
            Add(square);            
        }

        private void AddTriangle(IList<string> args)
        {
            var baseLength = ParseDecimal(args[1]);
            var height = ParseDecimal(args[2]);
            var color = args[3];
            var triangle = new Triangle(baseLength, height, color);
            Add(triangle);            
        }

        private List<string> TrimArgs(IEnumerable<string> args) {
            var trimmedArgs = args.Select(arg => arg.Trim()).ToList();
            return trimmedArgs;
        }

        private decimal ParseDecimal(string stringToParse) {
            decimal number;
            if (!decimal.TryParse(stringToParse, out number))
            {
                throw new ArgumentException("An error occured while attempting to parse part of the input string as a decimal.");
            }
            return number;
        }

        /// <summary>
        /// Returns a subset of this list where the shape names are equal to the specified shape name.
        /// </summary>
        public override IShapeList GetSubListOfType(string shapeName) {
            var subList = new ShapeList();
            subList.AddRange(this.Where(shape => shape.ShapeType == shapeName));
            return subList;
        }
    }
}
