using System;
using System.Collections.Generic;

namespace DesignPaterns_Visitor
{
    public interface IVisitor
    {
        void Visit(Rectangle rectangle);
        void Visit(Triangle triangle);
        void Visit(Circle circle);
    }

    public abstract class VisitorBase : IVisitor
    {
        protected VisitorBase()
        {
            Results = new Dictionary<object, double>();
        }

        public Dictionary<object, double> Results { get; }
        public abstract void Visit(Rectangle rectangle);

        public abstract void Visit(Triangle triangle);
        public abstract void Visit(Circle circle);
    }

    public class AreaVisitor : VisitorBase
    {
        public override void Visit(Rectangle rectangle)
        {
            Results.Add(rectangle, rectangle.Height * rectangle.Width);
        }

        public override void Visit(Triangle triangle)
        {
            Results.Add(triangle, triangle.Base / 2d * triangle.Height);
        }

        public override void Visit(Circle circle)
        {
            Results.Add(circle, 2 * Math.PI * Math.Pow(circle.Radius, 2));
        }
    }

    public class PerimeterVisitor : VisitorBase
    {
        public override void Visit(Rectangle rectangle)
        {
            Results.Add(rectangle, rectangle.Height * 2 + rectangle.Width * 2);
        }

        public override void Visit(Triangle triangle)
        {
            Results.Add(triangle, triangle.Ab + triangle.Bc + triangle.Ca);
        }

        public override void Visit(Circle circle)
        {
            Results.Add(circle, 2 * Math.PI * circle.Radius);
        }
    }

    public class HeightVisitor : VisitorBase
    {
        public override void Visit(Rectangle rectangle)
        {
            Results.Add(rectangle, rectangle.Height);
        }

        public override void Visit(Triangle triangle)
        {
            Results.Add(triangle, triangle.Height);
        }

        public override void Visit(Circle circle)
        {
            Results.Add(circle, 2 * circle.Radius);
        }
    }
}