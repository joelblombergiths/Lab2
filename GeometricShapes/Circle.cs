using System.Numerics;

namespace GeometricShapes
{
    public class Circle : Shape2D
    {
        private float _radius;
        private Vector3 _center;

        public override float Circumference => 2 * MathF.PI * _radius;
        public override float Area => MathF.PI * MathF.Pow(_radius, 2);
        public override Vector3 Center => _center;
        public override string ToString() => $"{nameof(Circle)} @({_center.X},{_center.Y}: r = {_radius})";

        public Circle(Vector2 center, float radius)
        {
            _center = new(center, 0);
            _radius = radius;
        }
    }
}
