using System;

namespace Program
{
    abstract class Shape
    {
        public abstract double calculateArea();
        public abstract double calculatePerimeter();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        static readonly double PI = 3.14;
        public override double calculateArea()
        {
            return PI * Radius * Radius;
        }

        public override double calculatePerimeter()
        {
            return 2 * PI * Radius;
        }
    }
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double calculateArea()
        {
            return Length * Width;
        }

        public override double calculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
    class Third
    {
        static void Main(String[] args)
        {
            Rectangle rect = new();
            Circle circ = new();

            rect.Width = 2.5; rect.Length = 5;
            circ.Radius = 3.5;

            Console.WriteLine("Rectangle:\n" +
                                "\tLength    - " + rect.Length + "\n" +
                                "\tWidth     - " + rect.Width + "\n" +
                                "\tPerimeter - " + rect.calculatePerimeter() + "\n" +
                                "\tArea      - " + rect.calculateArea() + "\n");
            Console.WriteLine("Circle:\n" +
                                "\tRadius    - " + circ.Radius + "\n" +
                                "\tPerimeter - " + circ.calculatePerimeter() + "\n" +
                                "\tArea      - " + circ.calculateArea());
        }
    }
}