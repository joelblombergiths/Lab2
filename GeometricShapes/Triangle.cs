using System.Numerics;

namespace GeometricShapes
{
    public class Triangle : Shape2D
    {
        private Vector2 _p1;
        private Vector2 _p2;
        private Vector2 _p3;
        private float a;
        private float b;
        private float c;

        public override Vector3 Center => new((_p1.X + _p2.X + _p3.X) / 3, (_p1.Y + _p2.Y + _p3.Y) / 3, 0);
        public override float Area 
        {
            get
            {
                float s = (a + b + c) / 2;
                return MathF.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }
        public override float Circumference => a + b + c;

        public override string ToString() => $"Triangle @({Center.X:f2},{Center.Y:f2}): p1({_p1.X:f2},{_p1.Y:f2}), p2({_p2.X:f2},{_p2.Y:f2}), p3({_p3.X:f2},{_p2.Y:f2})";

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            _p1 = p1;
            _p2 = p2;
            _p3 = p3;

            //a = (p2 - p1).Length();

            a = MathF.Sqrt(MathF.Pow(_p2.X - _p1.X, 2) + MathF.Pow(_p2.Y - _p1.Y, 2));
            b = MathF.Sqrt(MathF.Pow(_p3.X - _p2.X, 2) + MathF.Pow(_p3.Y - _p2.Y, 2));
            c = MathF.Sqrt(MathF.Pow(_p3.X - _p1.X, 2) + MathF.Pow(_p3.Y - _p1.Y, 2));
        }
    }
}
