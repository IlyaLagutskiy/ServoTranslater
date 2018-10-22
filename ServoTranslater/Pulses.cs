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

        public double AlphaPW { get; private set; } = 0;
        public double GammaPW { get; private set; } = 0;
        public double FiPW { get; private set; } = 0;
        public double TetaPW { get; private set; } = 0;

        public double AlphaCorr { get; } = 45;
        public double GammaCorr { get; } = 45;
        public double FiCorr { get; } = 0;
        public double TetaCorr { get; } = 0;

        public Pulses()
        {

        }

        protected void AlphaPW_Calc()
        {
            double part = (Alpha - AlphaCorr)/ HSConfig.OperAngle;
            double width = part * (HSConfig.MaxPW - HSConfig.MinPW);
            double pw = width + HSConfig.MinPW;
            AlphaPW = Math.Round(pw);
        }

        protected void GammaPW_Calc()
        {
            double part = (Gamma - GammaCorr)/ HSConfig.OperAngle;
            double width = part * (HSConfig.MaxPW - HSConfig.MinPW);
            double pw = width + HSConfig.MinPW;
            GammaPW = Math.Round(pw);
        }

        protected void FiPW_Calc()
        {
            double part = (Fi - FiCorr)/ HDConfig.OperAngle;
            double width = part * (HDConfig.MaxPW - HDConfig.MinPW);
            double pw = width + HDConfig.MinPW;
            FiPW = Math.Round(pw);
        }

        protected void TetaPW_Calc()
        {
            double part = (Teta - TetaCorr)/ HDConfig.OperAngle;
            double width = part * (HDConfig.MaxPW - HDConfig.MinPW);
            double pw = width + HDConfig.MinPW;
            TetaPW = Math.Round(pw);
        }

    }

    static class HSConfig
    {
        public const ushort MinPW = 1500;
        public const ushort MaxPW = 1900;
        public const ushort PulseChange = 8;
        public const ushort StepCount = 50;
        public const ushort OperAngle = 45;
        public const ushort Neutral = 1700;
    }

    static class HDConfig
    {
        public const ushort MinPW = 1000;
        public const ushort MaxPW = 2000;
        public const ushort PulseChange = 2;
        public const ushort StepCount = 500;
        public const ushort OperAngle = 90;
        public const ushort Neutral = 1500;
    }


}
