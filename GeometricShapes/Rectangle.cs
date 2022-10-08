using System.Numerics;

namespace GeometricShapes
{
    public class Rectangle : Shape2D
    {
        private Vector2 size;

        private Vector3 _center;
        public override Vector3 Center => _center;

        public override float Area => size.X * size.Y;
        public override float Circumference => 2 * (size.X + size.Y);
        public override string ToString() => $"{ShapeName} @({_center.X:f2}, {_center.Y:f2}): w = {size.X:f2}, h = {size.Y:f2}";

        public bool IsSquare => size.X == size.Y;
        public override string ShapeName => IsSquare ? "Square" : "Rectangle";

        public Rectangle(Vector2 center, float width) : this(center, new Vector2(width)) { }
        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = new(center, 0.0f);
            this.size = size;
        }
    }
}
