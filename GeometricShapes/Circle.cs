using System.Numerics;

namespace GeometricShapes
{
    public class Circle : Shape2D
    {
        private float radius;

        public override Vector3 Center { get; }

        public override float Area => MathF.PI * MathF.Pow(radius, 2);
        public override float Circumference => 2 * MathF.PI * radius;
        public override string ToString() => $"{ShapeName} @({Center.X:f2}, {Center.Y:f2}: r = {radius:f2})";

        public Circle(Vector2 center, float radius)
        {
            Center = new(center, 0.0f);
            this.radius = radius;
        }
    }
}
