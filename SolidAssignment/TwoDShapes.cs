using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidAssignment
{
    // Creating an abstract class
    public abstract class TwoDShapes
    {
        public float Length { get; set; }
        public float Breadth { get; set; }
        public abstract double CalculateArea(float Length, float Breadth);
    }

    // Square inherites class TwoDshapes and calculates the area of a square
    public class Square : TwoDShapes
    {
        public override double CalculateArea(float Length, float Breadth)
        {

            return (Length * Breadth);
        }
    }
    // Rectangle inherites class TwoDshapes and calculates the area of a Rectangle
    public class Rectangle : TwoDShapes
    {

        public override double CalculateArea(float Length, float Breadth)
        {
            return (Length * Breadth);
        }
    }

    // Rhombus inherites class TwoDshapes and calculates the area of a Rhombus
    public class Rhombus : TwoDShapes
    {
        public override double CalculateArea(float Length, float Breadth)
        {
            return ((Length * Breadth) / 2);
        }
    }
}

