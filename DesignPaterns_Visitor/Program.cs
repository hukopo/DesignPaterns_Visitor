using System;
using System.Drawing;

namespace DesignPaterns_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(1,1,1,1,1);
            var rectangle = new Rectangle(1, 1);
            var circle = new Circle(1);
            var areaVisitor = new AreaVisitor();
            rectangle.Accept(areaVisitor);
            triangle.Accept(areaVisitor);
            circle.Accept(areaVisitor);
            var perimeterVisitor = new PerimeterVisitor();
            rectangle.Accept(perimeterVisitor);
            triangle.Accept(perimeterVisitor);
            circle.Accept(perimeterVisitor);
            var heightVisitor = new HeightVisitor();
            rectangle.Accept(heightVisitor);
            triangle.Accept(heightVisitor);
            circle.Accept(heightVisitor);
            
            Console.WriteLine($"area - r: {areaVisitor.Results[rectangle]} t: {areaVisitor.Results[triangle]} c: {areaVisitor.Results[circle]}");
            Console.WriteLine($"perimeter - r: {perimeterVisitor.Results[rectangle]} t: {perimeterVisitor.Results[triangle]} c: {perimeterVisitor.Results[circle]}");
            Console.WriteLine($"height - r: {heightVisitor.Results[rectangle]} t: {heightVisitor.Results[triangle]} c: {heightVisitor.Results[circle]}");
            
        }
    }
}