using System.Numerics;

namespace GeometricShapes
{
    public class Sphere : Shape3D
    {
        private Vector3 _center;
        private float _radius;

        public override Vector3 Center => _center;
        public override float Area => 4 * MathF.PI * MathF.Pow(_radius, 2);
        public override float Volume => 4 / 3 * MathF.PI * MathF.Pow(_radius, 3);
        public override string ToString() => $"Sphere @({_center.X:f2},{_center.Y:f2},{_center.Z:f2}): r = {_radius}";
        
        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
        }
    }
}
