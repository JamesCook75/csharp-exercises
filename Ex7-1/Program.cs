using System;

namespace Ex7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle Circle1 = new Circle(4);
            Rectangle Rectangle1 = new Rectangle(5, 2);
            Square Square1 = new Square(3);

            Console.WriteLine(Circle1.Id);
            Console.WriteLine(Circle1.Area());
            Console.WriteLine(Rectangle1.Id);
            Console.WriteLine(Rectangle1.Area());
            Console.WriteLine(Square1.Id);
            Console.WriteLine(Square1.Area());

            Console.ReadLine();

        }
    }

    public abstract class AbstractEntity
    {
        public int Id { get; set; }
        static int newId = 0;

        public AbstractEntity(int id)
        {
            Id = id;
        }

        public AbstractEntity() : this(newId)
        {
            newId += 1;
        }

    }

    public abstract class Shape : AbstractEntity
    {
        public int Sides { get; set; }

        public Shape(int sides)
        {
            Sides = sides;
        }

        public abstract double Area();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, int sides) : base(sides)
        {
            Radius = radius;
        }

        public Circle(double radius) : this(radius, 1) { }

        public override double Area()
        {
            double area = 3.14 * Radius * Radius;
            return area;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width, int sides) : base(sides)
        {
            Length = length;
            Width = width;
        }


        public Rectangle(double length, double width) : this(length, width, 4) { }

        public override double Area()
        {
            double area = Length * Width;
            return area;
        }

    }

    class Square : Rectangle
    {
        public double Side { get; set; }

        public Square(double side, double length, double width, int sides) : base(length, width, sides)
        {
            Side = side;
        }

        public Square(double side) : this(side, side, side, 4) { }
    }

}
