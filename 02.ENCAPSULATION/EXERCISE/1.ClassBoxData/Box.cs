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
                this.TrowIfInvalidateSide(value, nameof(this.Height));
                this.height = value;
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
                this.TrowIfInvalidateSide(value, nameof(this.Width));
                this.width = value;
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
                this.TrowIfInvalidateSide(value, nameof(Length));
                this.length = value;
            }

        }
        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea()
        {
            return (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }
        public double LateralSurfaceArea()
        {
            return (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }
        public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }
        private void TrowIfInvalidateSide(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }
    }
}
