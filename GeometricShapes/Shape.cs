using System.Numerics;

namespace GeometricShapes
{
    public abstract class Shape
    {
        private static readonly int _maxDelta = 10;
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

        public static Shape GenerateShape() => GenerateShape(RandomVector3(true));

        public static Shape GenerateShape(Vector3 position)
        {
            int randomShape = Random.Shared.Next(Enum.GetNames(typeof(Shapes)).Length);
            Shapes shapeType = (Shapes)randomShape;

            Shape shape;

            switch (shapeType)
            {
                case Shapes.Rectangle:
                    shape = new Rectangle(new Vector2(position.X, position.Y), RandomVector2(false));
                    break;
                case Shapes.Square:
                    shape = new Rectangle(new Vector2(position.X, position.Y), RandomFloat(false));
                    break;
                case Shapes.Cuboid:
                    shape = new Cuboid(position, RandomVector3(false));
                    break;
                case Shapes.Cube:
                    shape = new Cuboid(position, RandomFloat(false));
                    break;
                case Shapes.Circle:
                    shape = new Circle(new Vector2(position.X, position.Y), RandomFloat(false));
                    break;
                case Shapes.Sphere:
                    shape = new Sphere(position, RandomFloat(false));
                    break;
                case Shapes.Triangle:
                    Vector2 p1 = RandomVector2(true);
                    Vector2 p2 = RandomVector2(true);
                    Vector2 p3 = new(3 * position.X - p1.X - p2.X, 3 * position.Y - p1.Y - p2.Y);
                    shape = new Triangle(p1, p2, p3);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("shapeType", "This should probably never happen :S");
            }

            return shape;
        }

        private static float RandomFloat(bool signed)
        {
            double significand = (Random.Shared.NextDouble() * 2.0);
            if (signed) significand -= 1.0;
            double exponent = Math.Pow(2.0, Random.Shared.Next(_maxDelta));
            return (float)(significand * exponent);
        }

        private static Vector2 RandomVector2(bool signed) => new(RandomFloat(signed), RandomFloat(signed));
        private static Vector3 RandomVector3(bool signed) => new(RandomVector2(signed), RandomFloat(signed));
    }
}
