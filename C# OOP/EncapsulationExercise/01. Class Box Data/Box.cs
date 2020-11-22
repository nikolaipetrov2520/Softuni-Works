using System;
using System.Text;

namespace ClassBoxData
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

        public double Length {
            get
            {
                return this.length;
            }
            private set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }

        //Surface Area = 2lw + 2lh + 2wh
        public double GetSurfaceArea()
        {
            double surfaceArea = 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
            return surfaceArea;
        }

        //Lateral Surface Area = 2lh + 2wh
        public double GetLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * this.length * this.height + 2 * this.width * this.height;
            return lateralSurfaceArea;
        }
        //Volume = lwh
        public double GetVolume()
        {
            double volume = this.length * this.width * this.height;
            return volume;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {GetSurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {GetLateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {GetVolume():f2}");
            

            return sb.ToString().TrimEnd();
        }
    }
}
