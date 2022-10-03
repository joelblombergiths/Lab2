using System.Numerics;

namespace GeometricShapes
{
    public abstract class Shape
    {
        private static readonly Random random = new();
        private static readonly int maxDelta = 10;
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

        public static Shape GenerateShape() => GenerateShape(random.NextVector3(true, maxDelta));

        public static Shape GenerateShape(Vector3 position)
        {
            int randomShape = random.Next(Enum.GetNames(typeof(Shapes)).Length);
            Shapes shapeType = (Shapes)randomShape;

            Shape shape;

            switch (shapeType)
            {
                case Shapes.Rectangle:
                    shape = new Rectangle(new Vector2(position.X, position.Y), random.NextVector2(false, maxDelta));
                    break;
                case Shapes.Square:
                    shape = new Rectangle(new Vector2(position.X, position.Y), random.NextFloat(false, maxDelta));
                    break;
                case Shapes.Cuboid:
                    shape = new Cuboid(position, random.NextVector3(false, maxDelta));
                    break;
                case Shapes.Cube:
                    shape = new Cuboid(position, random.NextFloat(false, maxDelta));
                    break;
                case Shapes.Circle:
                    shape = new Circle(new Vector2(position.X, position.Y), random.NextFloat(false, maxDelta));
                    break;
                case Shapes.Sphere:
                    shape = new Sphere(position, random.NextFloat(false, maxDelta));
                    break;
                case Shapes.Triangle:
                    Vector2 p1 = random.NextVector2(true, maxDelta);
                    Vector2 p2 = random.NextVector2(true, maxDelta);
                    Vector2 p3 = new(3 * position.X - p1.X - p2.X, 3 * position.Y - p1.Y - p2.Y);
                    shape = new Triangle(p1, p2, p3);
                    break;               
                default:
                    throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, "Shape not implemented");
            }

            return shape;
        }      
    }
}
