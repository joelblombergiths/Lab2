using System.Numerics;

namespace GeometricShapes
{
    internal static class ExtensionMethods
    {
        public static float NextFloat(this Random random, bool signed, int maxDelta)
        {
            double significand = random.NextDouble() * 2.0;
            if (signed) significand -= 1.0;
            double exponent = Math.Pow(2.0, random.Next(maxDelta));
            return (float)(significand * exponent);
        }

        public static Vector2 NextVector2(this Random random, bool signed, int maxDelta) => new(random.NextFloat(signed, maxDelta), random.NextFloat(signed, maxDelta));
        public static Vector3 NextVector3(this Random random, bool signed, int maxDelta) => new(random.NextVector2(signed, maxDelta), random.NextFloat(signed, maxDelta));
    }
}
