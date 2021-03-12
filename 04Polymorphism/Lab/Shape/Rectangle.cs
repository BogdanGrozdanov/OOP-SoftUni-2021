using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {

        public override double CalculateArea()
        {
            return this.height * this.widht;
        }

        public override double CalculatePerimeter()
        {
            return 2 * height + 2 * widht;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
        private readonly double height;

        private readonly double widht;

        public Rectangle(double height, double widht)
        {
            this.height = height;
            this.widht = widht;
        }


    }
}
