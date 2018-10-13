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

        static public double Psi(double y, double z) => Math.Atan2(y, z);

        static public double D(double y, double z) => Math.Sqrt(y * y + z * z);

        static public double Fi(double x, double y) => Math.Atan2(y, x);

        static public double Gamma(double x, double y, double z)
        {
            double len = Math.Sqrt(x * x + y * y);
            double numerator;
            double denominator;
            double underRoot = 0;
            double temp1 = d * d + h * h + l * l - 2 * h * l - len * len - z * z;
            double temp2 = d * d + h * h + l * l + 2 * h * l - len * len - z * z;
            underRoot -= 4 * temp1 * temp2;
            underRoot += 16 * d * d * h * h;
            double Root = Math.Sqrt(underRoot);
            Root /= 2;
            numerator = -2 * d * h - Root;
            denominator = d * d + h * h + 2 * h * l + l * l - len * len - z * z;
            double atan = Math.Atan2(numerator, denominator);
            return 2 * atan;
        }

        static public double Alpha(double y, double z, double gamma)
        {
            double temp = (l +d/Math.Tan(gamma))* Math.Sin(gamma) / D(y, z);
            double angle = Math.Acos(temp);
            angle += Psi(y, z);
            return angle;
        }

     }
}
