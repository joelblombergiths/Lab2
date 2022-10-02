using System.Numerics;

namespace GeometricShapes
{
    public class Triangle : Shape2D
    {
        private Vector2 A;
        private Vector2 B;
        private Vector2 C;

        private float a => (B - C).Length();
        private float b => (C - A).Length();
        private float c => (B - A).Length();

        //private float A => MathF.Sqrt(MathF.Pow(_p2.X - _p1.X, 2) + MathF.Pow(_p2.Y - _p1.Y, 2));
        //private float B => MathF.Sqrt(MathF.Pow(_p3.X - _p2.X, 2) + MathF.Pow(_p3.Y - _p2.Y, 2));
        //private float C => MathF.Sqrt(MathF.Pow(_p3.X - _p1.X, 2) + MathF.Pow(_p3.Y - _p1.Y, 2));

        public override Vector3 Center => new((A.X + B.X + C.X) / 3, (A.Y + B.Y + C.Y) / 3, 0);

        public override float Area
        {
            get
            {
                float s = (a + b + c) / 2;
                return MathF.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }

        public override float Circumference => a + b + c;
        
        public override string ToString() => $"Triangle @({Center.X:f2}, {Center.Y:f2}): p1({A.X:f2}, {A.Y:f2}), p2({B.X:f2}, {B.Y:f2}), p3({C.X:f2}, {B.Y:f2})";

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            A = p1;
            B = p2;
            C = p3;
        }
    }
}

//cx = (x1 + x2 + x3) / 3
//3cx = (x1 + x2 + x3)
//3cx - x1 -x2 = x3
//Vector2 p3 = new(3 * center.X - p1.X - p2.X, 3 * center.Y - p1.Y - p2.Y);