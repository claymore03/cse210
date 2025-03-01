//Name: Clayton Redding
//Professor: Brother Parrish
//Date: 03/01/2025
using System;

class Program
{
    static void Main(string[] args)
    {
        //New instance of Square class
        Square square = new Square();
        square.SetColor("Blue");
        square.SetSide(4);

        //New instance of Rectangle class
        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Red");
        rectangle.SetLength(8);
        rectangle.SetWidth(4);

        //New instance of Circle class
        Circle circle = new Circle();
        circle.SetColor("Green");
        circle.SetRadius(5);

        //List of shapes
        List<Shape> shape = new List<Shape>();
        shape.Add(square);
        shape.Add(rectangle);
        shape.Add(circle);

        foreach (Shape s in shape)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");
            Console.WriteLine();
            
        }
    }
}