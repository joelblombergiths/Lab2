using System.Numerics;

namespace GeometricShapes
{
    internal class Tetrahedron : Shape3D
    {
        private float _length;
        public override Vector3 Center => throw new NotImplementedException();
        public override float Area => MathF.Sqrt(3 * MathF.Pow(_length, 2));
        public override float Volume => throw new NotImplementedException();

        public Tetrahedron(Vector3 center, float length)
        {
            _length = length;
        }
    }
}
