using System;
using System.Collections.Generic;
using System.Text;

namespace Exercsice
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        //3.Volume = lwh
        //2.Lateral Surface Area = 2lh + 2wh
        //1.Surface Area = 2lw + 2lh + 2wh
        public double SurfaceArea(Box box)
        {
            var result = (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
            return result;
        }
        public double LateralSurfaceArea(Box box)
        {
            var result = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
            return result;
        }
        public double Volume(Box box)
        {
            var result = this.Length * this.Width * this.Height;
            return result;
        }
        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }


    }
}
