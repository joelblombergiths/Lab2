using GeometricShapes;

Console.CursorVisible = false;

int numShapes = 20;
do
{
    Console.Clear();

    Console.WriteLine($"List of {numShapes} Randomly Generated Shapes:");
    Console.WriteLine();

    List<Shape> shapes = new();
    for (int i = 0; i < numShapes; i++)
    {
        Shape shape = Shape.GenerateShape();
        shapes.Add(shape);

        Console.WriteLine(shape);
    }
    Console.WriteLine();

    float averageArea = shapes.Average(shape => shape.Area);
    Console.WriteLine($"Average Area of all shapes in the list is {averageArea:f2}.");
    Console.WriteLine();

    float totalTriangleCirc = shapes.Where(shape => shape is Triangle).Sum(shape => ((Triangle)shape).Circumference);
    Console.WriteLine($"Total Circumference of all Triangles is {totalTriangleCirc:f2}.");
    Console.WriteLine();

    Shape3D shapeWithLargestVolume = (Shape3D)shapes.Where(shape => shape is Shape3D).OrderByDescending(shape => ((Shape3D)shape).Volume).First();
    Console.WriteLine($"The {shapeWithLargestVolume} has the largest volume with {shapeWithLargestVolume.Volume:f2}.");
    Console.WriteLine();

    var countShapes = shapes.GroupBy(shape => shape.GetType()).Select(group => new { Count = group.Count(), Type = group.Key }).OrderByDescending(group => group.Count).First();
    Console.WriteLine($"Shape \"{countShapes.Type.Name}\" has the most instances with {countShapes.Count} in the list.");
    Console.WriteLine();

    Console.WriteLine($"Press the Any key to randomize {numShapes} new shapes or ESC to Exit.");
}
while (Console.ReadKey(true).Key != ConsoleKey.Escape);
