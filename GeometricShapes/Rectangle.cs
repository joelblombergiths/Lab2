using System.Numerics;

namespace GeometricShapes
{
    public class Rectangle : Shape2D
    {
        private Vector2 size;

        public override Vector3 Center { get; }

        public override float Area => size.X * size.Y;
        public override float Circumference => 2 * (size.X + size.Y);
        public override string ToString() => $"{ShapeName} @({Center.X:f2}, {Center.Y:f2}): w = {size.X:f2}, h = {size.Y:f2}";

        public bool IsSquare => size.X == size.Y;
        public override string ShapeName => IsSquare ? "Square" : "Rectangle";

        public Rectangle(Vector2 center, float width) : this(center, new Vector2(width)) { }
        public Rectangle(Vector2 center, Vector2 size)
        {
            Center = new(center, 0.0f);
            this.size = size;
        }
    }
}
