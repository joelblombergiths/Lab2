using System.Numerics;

namespace GeometricShapes
{
    public abstract class Shape
    {
        private enum Shapes
        {
            Rectangle,
            Square,
            Circle,
            Cuboid,
            Cube,
            Sphere,
            Triangle
        }

        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape() => GenerateShape(new((float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10));
        
        public static Shape GenerateShape(Vector3 position)
        {
            int randomShape = Random.Shared.Next(Enum.GetNames(typeof(Shapes)).Length);
            Shapes shapeType = (Shapes)randomShape;

            Vector3 randomSize = new((float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10);

            float randomFloat = (float)Random.Shared.NextDouble() * 10;

            Shape shape = shapeType switch
            {
                Shapes.Rectangle => new Rectangle(new Vector2(position.X, position.Y), new Vector2(randomSize.X, randomSize.Y)),
                Shapes.Square => new Rectangle(new Vector2(position.X, position.Y), randomFloat),
                Shapes.Circle => new Circle(new Vector2(position.X, position.Y), randomFloat),
                Shapes.Triangle => new Triangle(Vector2.One, Vector2.One * 2, Vector2.One * 4),
                Shapes.Cuboid => new Cuboid(position, randomSize),
                Shapes.Cube => new Cuboid(position, randomFloat),
                Shapes.Sphere => new Sphere(position, randomFloat),
                _ => throw new ArgumentOutOfRangeException("shapeType", "This should probably never happen :S"),
            };

            return shape;
        }
    }
}