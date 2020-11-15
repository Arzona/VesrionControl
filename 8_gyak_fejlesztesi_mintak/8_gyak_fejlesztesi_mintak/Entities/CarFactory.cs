﻿using _8_gyak_fejlesztesi_mintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_gyak_fejlesztesi_mintak.Entities
{
    class CarFactory : IToyFactory
    {

        public Color BallColor { get; set; }
        public Toy CreateNew()
        {
            return new Ball(BallColor);
        }

        public static implicit operator CarFactory(BallFactory v)
        {
            throw new NotImplementedException();
        }
    }
}
