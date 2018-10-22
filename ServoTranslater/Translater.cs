using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServoTranslater
{
    static class Translater
    {
        public const double d = 6.59;
        public const double l = 130.65;
        public const double h = 149.34;
        //155,93

        static public double Psi(double y, double z) => Math.Atan2(y, z);

        static public double D(double y, double z) => Math.Sqrt(y * y + z * z);

        static public double Fi(double x, double y) => Math.Atan2(y, x);

        static public double Gamma(double x, double y, double z)
        {
            double numerator;
            double denominator;
            double underRoot;
            denominator = d * d + h * h + 2 * h * l + l * l - x * x - y * y - z * z;
            underRoot = d * d + h * h + 2 * h * l + l * l - x * x - y * y - z * z;
            underRoot *= d * d + h * h - 2 * h * l + l * l - x * x - y * y - z * z;
            underRoot *= (-4);
            underRoot += 16 * d * d * h * h;
            double root = Math.Sqrt(underRoot);
            numerator = root / 2 - 2 * d * h;
            double atan = Math.Atan2(numerator, denominator);
            return 2 * atan;
        }

        static public double Alpha(double y, double z, double gamma)
        {
            double tan = Math.Tan(gamma);
            double sin = Math.Sin(gamma);
            double temp = (l + d/tan)* sin / D(y, z);
            double angle = Math.Acos(temp);
            angle += Psi(y, z);
            return angle;
        }

     }
}
