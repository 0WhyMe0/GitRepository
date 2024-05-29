using Zad4_OOP;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(2);

        ShapeDisplay shapeDisplay = new ShapeDisplay(circle);

        shapeDisplay.Display();
    }
}