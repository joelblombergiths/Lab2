using System.Numerics;

namespace GeometricShapes
{
    public class Cuboid : Shape3D
    {
        private Vector3 size;

        public override Vector3 Center { get; }

        public override float Area => 2 * ((size.Z * size.X) + (size.X * size.Y) + (size.Z * size.Y));
        public override float Volume => size.X * size.Y * size.Z;
        public override string ToString() => $"{ShapeName} @({Center.X:f2}, {Center.Y:f2}): w = {size.X:f2}, h = {size.Y:f2}, l = {size.Z:f2}";

        public bool IsCube => size.X == size.Y && size.X == size.Z;
        public override string ShapeName => IsCube ? "Cube" : "Cuboid";

        public Cuboid(Vector3 center, float width): this(center, new Vector3(width)) { }
        public Cuboid(Vector3 center, Vector3 size)
        {
            Center = center;
            this.size = size;
        }  
    }
}
