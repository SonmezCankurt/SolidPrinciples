using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();

            Rectangle rectangle = new Rectangle(3, 5);
            Console.WriteLine($"Rectangle ({rectangle.Height}, {rectangle.Width}) Area : {areaCalculator.GetArea(rectangle)}");
            Console.WriteLine("----------");

            Circle circle = new Circle(7);
            Console.WriteLine($"Circle ({circle.Radius}) Area : {areaCalculator.GetArea(circle)}");

            Console.ReadLine();
        }
    }





    // Good Design

    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class AreaCalculator
    {
        public double GetArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }



    // Bad Design

    /*
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class Circle
    {
        public double Radius { get; set; }
    }

    public class AreaCalculator
    {
        public double GetRectangleArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }

        public double GetCircleArea(Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
    }
    */
}
