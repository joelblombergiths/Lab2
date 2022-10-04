using System.Numerics;

namespace GeometricShapes
{
    public static class ExtensionMethods
    {
        public static float NextFloat(this Random random, float max) => random.NextFloat(0, max);
        public static float NextFloat(this Random random, float min, float max) => random.NextSingle() * (max - min) + min;


        public static Vector2 NextVector2(this Random random, float max) => random.NextVector2(0, max);
        public static Vector2 NextVector2(this Random random, float min, float max) => new(random.NextFloat(min, max), random.NextFloat(min, max));


        public static Vector3 NextVector3(this Random random, float max) => random.NextVector3(0, max);
        public static Vector3 NextVector3(this Random random, float min, float max) => new(random.NextVector2(min, max), random.NextFloat(min, max));
    }
}