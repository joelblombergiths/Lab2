using System.Numerics;

namespace GeometricShapes
{
    public abstract class Shape3D : Shape
    {
        public override Vector3 Center => throw new NotImplementedException();

        public override float Area => throw new NotImplementedException();

        public abstract float Volume { get; }
    }
}
