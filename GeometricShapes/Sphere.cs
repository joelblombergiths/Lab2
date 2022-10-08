using System.Numerics;

namespace GeometricShapes
{
    public class Sphere : Shape3D
    {
        private float radius;

        public override Vector3 Center { get; }

        public override float Area => 4 * MathF.PI * MathF.Pow(radius, 2);
        public override float Volume => 4f / 3f * MathF.PI * MathF.Pow(radius, 3);

        public override string ToString() => $"{ShapeName} @({Center.X:f2}, {Center.Y:f2}, {Center.Z:f2}): r = {radius:f2}";
        
        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            this.radius = radius;
        }
    }
}
