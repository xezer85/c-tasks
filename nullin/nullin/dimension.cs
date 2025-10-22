using System;

namespace ProductDemo
{
    public class Dimensions
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public Dimensions(double width, double height, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

        public override string ToString()
        {
            return $"{Width}×{Height}×{Depth}";
        }
    }
}
