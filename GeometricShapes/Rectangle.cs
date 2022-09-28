using System.Numerics;

namespace GeometricShapes
{
    public class Rectangle : Shape2D
    {
        private Vector2 _size;
        private Vector3 _center;

        public override Vector3 Center => _center;
        public override float Area => _size.X * _size.Y;
        public override float Circumference => MathF.Pow(_size.X, 2) + MathF.Pow(_size.Y, 2);
        public bool IsSquare => _size.X == _size.Y;
        public override string ToString() => $"{(IsSquare ? "Square" : "Rectangle")} @({_center.X:f2}, {_center.Y:f2}): w = {_size.X:f2}, h = {_size.Y:f2}";

        public Rectangle(Vector2 center, float width) : this(center, new Vector2(width)) { }
        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = new(center, 0.0f);
            _size = size;
        }
    }
}
