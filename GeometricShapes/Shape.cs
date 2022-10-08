using System.Numerics;

namespace GeometricShapes
{
    public abstract class Shape
    {
        private static readonly Random random = new();
        private static readonly int max = 10;

        private enum ShapeType
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

        public virtual string ShapeName => GetType().Name;

        public static Shape GenerateShape() => GenerateShape(random.NextVector3(-max, max));
        public static Shape GenerateShape(Vector3 position)
        {
            int randomShape = random.Next(Enum.GetNames(typeof(ShapeType)).Length);
            ShapeType shapeType = (ShapeType)randomShape;

            Shape shape;

            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    shape = new Rectangle(new Vector2(position.X, position.Y), random.NextVector2(max));
                    break;
                case ShapeType.Square:
                    shape = new Rectangle(new Vector2(position.X, position.Y), random.NextFloat(max));
                    break;
                case ShapeType.Cuboid:
                    shape = new Cuboid(position, random.NextVector3(max));
                    break;
                case ShapeType.Cube:
                    shape = new Cuboid(position, random.NextFloat(max));
                    break;
                case ShapeType.Circle:
                    shape = new Circle(new Vector2(position.X, position.Y), random.NextFloat(max));
                    break;
                case ShapeType.Sphere:
                    shape = new Sphere(position, random.NextFloat(max));
                    break;
                case ShapeType.Triangle:
                    Vector2 p1 = random.NextVector2(-max, max);
                    Vector2 p2 = random.NextVector2(-max, max);
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
