using System.Numerics;

namespace GeometricShapes
{
    public class Rectangle : Shape2D
    {
        private Vector3 _center;
        private Vector2 _size;

        public override Vector3 Center => _center;
        public override float Area => _size.X * _size.Y;
        public override float Circumference => MathF.Pow(_size.X, 2) + MathF.Pow(_size.Y, 2);
        public override string ToString() => $"{nameof(Rectangle)} @({_center.X},{_center.Y}):w = {_size.X}{(IsSquare ? " Square" : $", h = {_size.Y}")}";
        public bool IsSquare => _size.X == _size.Y;

        public Rectangle(Vector2 center, float width) : this(center, new Vector2(width)) { }
        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = new(center, 0);
            _size = size;
        }
    }
}
