﻿using System.Numerics;

namespace GeometricShapes
{
    public class Cuboid : Shape3D
    {
        private Vector3 _center;
        private Vector3 _size;

        public override Vector3 Center => _center;
        public override float Area => (2 * _size.Z * _size.X) + (2 * _size.Z * _size.Y) + (2 * _size.Y * _size.X);
        public override float Volume => _size.X * _size.Y * _size.Z;
        public bool IsCube => Compare(_size.X, _size.Y, _size.Z);
        public override string ToString() => $"{nameof(Cuboid)} @({_center.X},{_center.Y}):w = {_size.X}{(IsCube ? " Cube" : $", h = {_size.Y}, l = {_size.Z}")}";

        public Cuboid(Vector3 center, float width): this(center, new Vector3(width)) { }
        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
        }

        private static bool Compare(params float[] sides)
        {
            return sides.All(x => x.Equals(sides.First()));
        }
    }
}
