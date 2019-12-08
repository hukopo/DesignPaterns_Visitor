namespace DesignPaterns_Visitor
{
    public abstract class Figure
    {
        public abstract void Accept(IVisitor visitor);
    }

    public class Rectangle : Figure
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; }
        public int Height { get; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Triangle : Figure
    {
        public Triangle(int ab, int bc, int ca, int @base, int height)
        {
            Ab = ab;
            Bc = bc;
            Ca = ca;
            Base = @base;
            Height = height;
        }

        public int Ab { get; }
        public int Bc { get; }
        public int Ca { get; }
        public int Base { get; }
        public int Height { get; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Circle : Figure
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}