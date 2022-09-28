using GeometricShapes;
using System.Numerics;

List<Shape> shapes = new();

for (int i = 0; i < 10; i++)
{
    shapes.Add(Shape.GenerateShape());
}

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape);
}