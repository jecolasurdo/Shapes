﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ShapeCore.ComponentModel;

namespace Shapes.ShapeCore.ShapeLogic
{
    public class Square : ShapeBase
    {
        public override string ShapeType { get { throw new NotImplementedException(); } }
        public override decimal Area { get { throw new NotImplementedException(); } }
        public override string Color { get; set; }
        public decimal Length { get; private set; }

        public Square(decimal length) {
            throw new NotImplementedException();
        }
    }
}