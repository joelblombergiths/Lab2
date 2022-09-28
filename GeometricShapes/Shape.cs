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

        public static Shape GenerateShape()
        {
            int randomShape = Random.Shared.Next(Enum.GetNames(typeof(Shapes)).Length);
            Shapes shapeType = (Shapes)randomShape;

            Vector2 randomPositionVector2 = new((float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10);
            Vector3 randomPositionVector3 = new((float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10);

            Vector2 randomSizeVector2 = new((float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10);
            Vector3 randomSizeVector3 = new((float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10, (float)Random.Shared.NextDouble() * 10);

            float randomFloat = (float)Random.Shared.NextDouble() * 10;

            Shape shape = shapeType switch
            {
                Shapes.Rectangle => new Rectangle(randomPositionVector2, randomSizeVector2),
                Shapes.Square => new Rectangle(randomPositionVector2, randomFloat),
                Shapes.Circle => new Circle(randomPositionVector2, randomFloat),
                Shapes.Cuboid => new Cuboid(randomPositionVector3, randomSizeVector3),
                Shapes.Cube => new Cuboid(randomPositionVector3, randomFloat),
                Shapes.Sphere => new Sphere(randomPositionVector3, randomFloat),
                Shapes.Triangle => new Triangle(Vector2.One, Vector2.One * 2, Vector2.One * 4),
                _ => throw new ArgumentOutOfRangeException("shapeType", "This should probably never happen :S"),
            };

            return shape;
        }
    }
}