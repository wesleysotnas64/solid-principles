using OCP_Open_Closed_Priciple;

Console.WriteLine("OCP - Open/Closed Principle.");

Circle circle = new()
{
    Radius = 10
};

Rectangle rectangle = new()
{
    Width = 4,
    Height = 10
};

Console.WriteLine($"Circle Area: {AreaCalculator.CalculateArea(circle)}");
Console.WriteLine($"Rectangle Area: {AreaCalculator.CalculateArea(rectangle)}");