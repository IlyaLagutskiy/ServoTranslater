using System;

namespace ServoTranslater
{
    static class Translater
    {
        public const double D = 6.59;
        public const double L = 71;
        public const double H = 149.34;
        //155,93

        public static double Psi(double y, double z) => Math.Atan2(y, z);

        public static double Dist(double y, double z) => Math.Sqrt(y * y + z * z);

        public static double Fi(double x, double y) => Math.Atan2(y, x);

        public static double Gamma(double x, double y, double z)
        {
            var denominator = D * D + H * H + 2 * H * L + L * L - x * x - y * y - z * z;
            var underRoot = D * D + H * H + 2 * H * L + L * L - x * x - y * y - z * z;
            underRoot *= D * D + H * H - 2 * H * L + L * L - x * x - y * y - z * z;
            underRoot *= (-4);
            underRoot += 16 * D * D * H * H;
            double root = Math.Sqrt(underRoot);
            var numerator = root / 2 - 2 * D * H;
            double atan = Math.Atan2(numerator, denominator);
            return 2 * atan;
        }

        public static double Alpha(double y, double z, double gamma)
        {
            double tan = Math.Tan(gamma);
            double sin = Math.Sin(gamma);
            double temp = (L + D/tan)* sin / Dist(y, z);
            double angle = Math.Acos(temp);
            angle += Psi(y, z);
            return angle;
        }

     }
}
