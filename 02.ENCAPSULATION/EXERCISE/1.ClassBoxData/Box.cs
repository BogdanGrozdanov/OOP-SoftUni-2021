using System;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (ValidateData(value))
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
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
                if (ValidateData(value))
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }
        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (ValidateData(value))
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                    
                }
            }

        }
        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea(Box box)
        {
            return (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }
        public double LateralSurfaceArea(Box box)
        {
            return (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }
        public double Volume(Box box)
        {
            return this.Length * this.Width * this.Height;
        }
        private bool ValidateData(double data)
        {
            return data > 0;
        }
    }
}
