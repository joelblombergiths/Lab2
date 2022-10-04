using System.Numerics;

namespace GeometricShapes
{
    public class Triangle : Shape2D
    {
        private Vector2 vertexA;
        private Vector2 vertexB;
        private Vector2 vertexC;

        private float SideA => (vertexB - vertexC).Length();
        private float SideB => (vertexC - vertexA).Length();
        private float SideC => (vertexB - vertexA).Length();
       
        public override Vector3 Center => new((vertexA.X + vertexB.X + vertexC.X) / 3, (vertexA.Y + vertexB.Y + vertexC.Y) / 3, 0);

        public override float Area
        {
            get
            {
                float s = (SideA + SideB + SideC) / 2;
                return MathF.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        public override float Circumference => SideA + SideB + SideC;
        
        public override string ToString() => $"Triangle @({Center.X:f2}, {Center.Y:f2}): p1({vertexA.X:f2}, {vertexA.Y:f2}), p2({vertexB.X:f2}, {vertexB.Y:f2}), p3({vertexC.X:f2}, {vertexC.Y:f2})";

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            vertexA = p1;
            vertexB = p2;
            vertexC = p3;
        }
    }
}
