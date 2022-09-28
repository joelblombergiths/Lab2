using System.Numerics;

namespace GeometricShapes
{
    public class Circle : Shape2D
    {
        private float _radius;
        private Vector3 _center;

        public override Vector3 Center => _center;
        public override float Area => MathF.PI * MathF.Pow(_radius, 2);
        public override float Circumference => 2 * MathF.PI * _radius;
        public override string ToString() => $"Circle @({_center.X:f2},{_center.Y:f2}: r = {_radius:f2})";

        public Circle(Vector2 center, float radius)
        {
            _center = new(center, 0.0f);
            _radius = radius;
        }
    }
}
