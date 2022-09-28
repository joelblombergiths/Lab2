using GeometricShapes;

List<Shape> shapes = new();

Console.WriteLine("20 Randomly Generated Shapes:");

foreach (int _ in Enumerable.Range(0,20))
{
    Shape shape = Shape.GenerateShape();
    shapes.Add(shape);
    
    Console.WriteLine(shape);
}
Console.WriteLine();

float averageArea = shapes.Average(s => s.Area);
Console.WriteLine($"Average Area of all shapes in the list is {averageArea:f2}.");
Console.WriteLine();

float totalTriangleCirc = shapes.Where(s => s is Triangle).Sum(x => ((Triangle)x).Circumference);
Console.WriteLine($"Total Circumference of all Triangles is {totalTriangleCirc:f2}.");
Console.WriteLine();

Shape3D shapeWithLargestVolume = (Shape3D)shapes.Where(s => s is Shape3D).OrderByDescending(o => ((Shape3D)o).Volume).First();
Console.WriteLine($"{shapeWithLargestVolume} has the largest volume with {shapeWithLargestVolume.Volume:f2}.");
Console.WriteLine();

var count = shapes.GroupBy(s => s.GetType()).Select(x => new { Count = x.Count(), Type = x.Key }).OrderByDescending(o => o.Count).First();
Console.WriteLine($"Shape \"{count.Type.Name}\" has most instances with {count.Count} in the list.");
Console.WriteLine();

Console.WriteLine("Press the Any key to Exit");
Console.ReadKey(true);
