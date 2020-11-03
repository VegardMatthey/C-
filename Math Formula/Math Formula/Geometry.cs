using System;

namespace Math_Formula
{
    interface IGeometry
    {
        double Area();
        double Volume();
    }

    public class Cube : IGeometry
    {
        public Cube(double length)
        {
            Length = length;
        }
        public double Length { get; set; }
        public double Area()
        {
            return 6 * Length * Length;
        }

        public double Volume()
        {
            return Length * Length * Length;
        }
    }

    public class Sphere : IGeometry
    {
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public double Area()
        {
            return 4.0 * Math.PI * Radius * Radius;
        }

        public double Volume()
        {
            return 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
        }
    }
}
