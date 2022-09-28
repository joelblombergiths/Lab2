using GeometricShapes;
using System.Numerics;

Rectangle rectangle = new(Vector2.Zero, new Vector2(5.0f, 3.0f));
Triangle triangle = new(new(0.0f, 0.0f), new(3.0f, 3.0f), new(6.0f, 0.0f));
Circle circle = new(Vector2.Zero, 3f);

Cuboid cuboid = new(Vector3.Zero, 5);
Sphere sphere = new(Vector3.Zero, 5);

Console.WriteLine(rectangle);
Console.WriteLine(triangle);
Console.WriteLine(circle);
Console.WriteLine(cuboid);
Console.WriteLine(sphere);