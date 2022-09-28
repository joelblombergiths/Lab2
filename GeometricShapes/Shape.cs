using System.Numerics;

namespace GeometricShapes
{
    public abstract class Shape
    {
        private static readonly int _maxDelta = 100;
        private enum Shapes
        {
            Rectangle,
            Square,
            Cuboid,
            Cube,
            Circle,
            Sphere,
            Triangle
        }

        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape() => GenerateShape(RandomVector3());
        
        public static Shape GenerateShape(Vector3 position)
        {
            int randomShape = Random.Shared.Next(Enum.GetNames(typeof(Shapes)).Length);
            Shapes shapeType = (Shapes)randomShape;

            Shape shape;

            switch (shapeType)
            {
                case Shapes.Rectangle:
                    shape = new Rectangle(new Vector2(position.X, position.Y), RandomVector2());
                    break;
                case Shapes.Square:
                    shape = new Rectangle(new Vector2(position.X, position.Y), RandomSize());
                    break;
                case Shapes.Cuboid:
                    shape = new Cuboid(position, RandomVector3());
                    break;
                case Shapes.Cube:
                    shape = new Cuboid(position, RandomSize());
                    break;
                case Shapes.Circle:
                    shape = new Circle(new Vector2(position.X, position.Y), RandomSize());
                    break;
                case Shapes.Sphere:
                    shape = new Sphere(position, RandomSize());
                    break;
                case Shapes.Triangle:
                    Vector2 p1 = RandomVector2();
                    Vector2 p2 = RandomVector2();
                    Vector2 p3 = new(3 * position.X - p1.X - p2.X, 3 * position.Y - p1.Y - p2.Y);
                    shape = new Triangle(p1, p2, p3);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("shapeType", "This should probably never happen :S");
            }

            return shape;
        }

        private static float RandomSize() => (float)Random.Shared.NextDouble() * _maxDelta;
        private static Vector2 RandomVector2() => new ((float) Random.Shared.NextDouble() * _maxDelta, (float)Random.Shared.NextDouble() * _maxDelta);        
        private static Vector3 RandomVector3() => new ((float) Random.Shared.NextDouble() * _maxDelta, (float)Random.Shared.NextDouble() * _maxDelta, (float)Random.Shared.NextDouble() * _maxDelta);
    }
}
            //Shape shape = shapeType switch
            //{
            //    Shapes.Rectangle => new Rectangle(new Vector2(position.X, position.Y), new Vector2(randomSize.X, randomSize.Y)),
            //    Shapes.Square => new Rectangle(new Vector2(position.X, position.Y), randomFloat),
            //    Shapes.Cuboid => new Cuboid(position, randomSize),
            //    Shapes.Cube => new Cuboid(position, randomFloat),
            //    Shapes.Circle => new Circle(new Vector2(position.X, position.Y), randomFloat),
            //    Shapes.Sphere => new Sphere(position, randomFloat),
            //    Shapes.Triangle => new Triangle(Vector2.One, Vector2.One * 2, Vector2.One * 4),
            //    _ => throw new ArgumentOutOfRangeException("shapeType", "This should probably never happen :S"),
            //};