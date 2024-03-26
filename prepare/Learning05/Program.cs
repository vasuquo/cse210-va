using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Console.WriteLine("From individual instances of Shape");

        Square square = new Square("Blue", 20.75f);        
        Console.WriteLine($"Color of Square = {square.GetColor()}");
        Console.WriteLine($"Area of Square = {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Yellow", 4f, 5f);
        Console.WriteLine($"Color of Rectangle = {rectangle.GetColor()}");
        Console.WriteLine($"Area of Rectangle = {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 6f);
        Console.WriteLine($"Color of Circle = {circle.GetColor()}");
        Console.WriteLine($"Area of Circle = {circle.GetArea()}");
        Console.WriteLine(" ");

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("From the List of Shape");

        foreach (Shape shape in shapes)
        {            
            Console.WriteLine($"Color of {shape.GetType().Name}  = {shape.GetColor()}");
            Console.WriteLine($"Area of {shape.GetType().Name} = {shape.GetArea()}");
            Console.WriteLine(" ");
        }

        

    }
}