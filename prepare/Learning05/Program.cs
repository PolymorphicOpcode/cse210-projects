using System;
namespace Shapes {
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Circle circle = new Circle("Orange", 5);
            shapes.Add(circle);

            Rectangle rectangle = new Rectangle("Green", 4, 9);
            shapes.Add(rectangle);

            Square square = new Square("Purple", 9);
            shapes.Add(square);

            foreach (Shape shape in shapes)
            {
                string color = shape.GetColor();
                double area = shape.GetArea();
                Console.WriteLine($"The shape is {color} and has an area of {area}.");
            }
        }
    }
    public abstract class Shape
    {
        private string _color;

        public Shape(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }
        public abstract double GetArea();
    }
    public class Square : Shape
    {
        private double _side;

        public Square(string color, double side) : base (color)
        {
            _side = side;
        }
        public override double GetArea()
        {
            return _side * _side;
        }
    }
    public class Circle : Shape {
        private double _radius;

        public Circle(string color, double radius) : base (color)
        {
            _radius = radius;
        }
        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
    public class Rectangle : Shape
    {
        private double _length;
        private double _width;
        public Rectangle(string color, double length, double width) : base (color)
        {
            _length = length;
            _width = width;
        }
        public override double GetArea()
        {
            return _length * _width;
        }
    }
}