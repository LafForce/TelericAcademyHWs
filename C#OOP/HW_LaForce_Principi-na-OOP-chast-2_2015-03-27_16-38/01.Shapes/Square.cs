﻿namespace Shapes
{
    using System;

    class Square : Shape
    {
        
        public Square(double side)
            : base(side, side)
        {
        }

       
        public override double CalculateSurface()
        {
            return (this.Width * this.Height);
        }
    }
}
