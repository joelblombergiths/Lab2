using System.Numerics;

namespace GeometricShapes
{
    public class Cuboid : Shape3D
    {
        private Vector3 size;

        private Vector3 _center;
        public override Vector3 Center => _center;

        public override float Area => (2 * size.Z * size.X) + (2 * size.Z * size.Y) + (2 * size.Y * size.X);
        public override float Volume => size.X * size.Y * size.Z;
        public override string ToString() => $"{(IsCube ? "Cube" : "Cuboid")} @({_center.X:f2}, {_center.Y:f2}): w = {size.X:f2}, h = {size.Y:f2}, l = {size.Z:f2}";

        public bool IsCube => size.X == size.Y && size.X == size.Z;

        public Cuboid(Vector3 center, float width): this(center, new Vector3(width)) { }
        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            this.size = size;
        }  
    }
}
