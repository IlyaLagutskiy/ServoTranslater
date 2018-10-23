using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServoTranslater
{
    class Pulses
    {
        public double Alpha { get; protected set; } = 0;
        public double Gamma { get; protected set; } = 0;
        public double Fi { get; protected set; } = 0;
        public double Teta { get; protected set; } = 0;

        public double AlphaCorr { get; private set; } = 0;
        public double GammaCorr { get; private set; } = 0;
        public double FiCorr { get; private set; } = 0;
        public double TetaCorr { get; private set; } = 0;

        public double AlphaPW { get; private set; } = 0;
        public double GammaPW { get; private set; } = 0;
        public double FiPW { get; private set; } = 0;
        public double TetaPW { get; private set; } = 0;

        public short AlphaPWCorr { get; } = -16;
        public short GammaPWCorr { get; } = +36;
        public short FiPWCorr { get; } = 0;
        public short TetaPWCorr { get; } = 0;

        public Pulses()
        {
            AlphaCorr = 45.0d / 180.0d * Math.PI;
            GammaCorr = 45.0d / 180.0d * Math.PI;
            FiCorr = 45.0d / 180.0d * Math.PI;
            TetaCorr = 45.0d / 180.0d * Math.PI;
        }

        protected void AlphaPW_Calc()
        {
            double part = (Alpha - AlphaCorr)/ HSConfig.OperAngle;
            double width = part * (HSConfig.MaxPW - HSConfig.MinPW);
            double pw = HSConfig.MaxPW - width;
            AlphaPW = Math.Round(pw) + AlphaPWCorr;
        }

        protected void GammaPW_Calc()
        {
            double part = (Gamma - GammaCorr)/ HSConfig.OperAngle;
            double width = part * (HSConfig.MaxPW - HSConfig.MinPW);
            double pw = HSConfig.MaxPW - width;
            GammaPW = Math.Round(pw) + GammaPWCorr;
        }

        protected void FiPW_Calc()
        {
            double part = (Fi - FiCorr)/ HDConfig.OperAngle;
            double width = part * (HDConfig.MaxPW - HDConfig.MinPW);
            double pw = width + HDConfig.MinPW;
            FiPW = Math.Round(pw) + FiPWCorr;
        }

        protected void TetaPW_Calc()
        {
            double part = (Teta + TetaCorr)/ HDConfig.OperAngle;
            double width = part * (HDConfig.MaxPW - HDConfig.MinPW);
            double pw = width + HDConfig.MinPW;
            TetaPW = Math.Round(pw) + TetaPWCorr;
        }

    }

    static class HSConfig
    {
        public const ushort MinPW = 1500;
        public const ushort MaxPW = 1900;
        public const ushort PulseChange = 8;
        public const ushort StepCount = 50;
        public const double OperAngle = 45.0d / 180.0d * Math.PI;
        public const ushort Neutral = 1700;
    }

    static class HDConfig
    {
        public const ushort MinPW = 1000;
        public const ushort MaxPW = 2000;
        public const ushort PulseChange = 2;
        public const ushort StepCount = 500;
        public const double OperAngle = 90.0d / 180.0d * Math.PI;
        public const ushort Neutral = 1500;
    }


}
