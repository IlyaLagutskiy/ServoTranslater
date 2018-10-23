using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServoTranslater
{
    class Coordinate : Pulses
    {
        public double X { get; private set; } = 0;
        public double Y { get; private set; } = 0;
        public double Z { get; private set; } = 0;

        public Coordinate() : base()
        {

        }
        
        public Coordinate(double x, double y, double z) : base()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void ExecuteCalculations ()
        {
            Fi = Translater.Fi(X, Y);
            Gamma = Translater.Gamma(X, Y, Z);
            Alpha = Translater.Alpha(Y, Z, Gamma);
            Teta = Alpha - Gamma;
            AlphaPW_Calc();
            GammaPW_Calc();
            TetaPW_Calc();
            FiPW_Calc();
        }
            
        public void ReadGrid(DataGridView dataGridView)
        {
            X = Convert.ToDouble(dataGridView.Rows[0].Cells["X"].Value);
            Y = Convert.ToDouble(dataGridView.Rows[0].Cells["Y"].Value);
            Z = Convert.ToDouble(dataGridView.Rows[0].Cells["Z"].Value);
            dataGridView.Rows.Remove(dataGridView.Rows[0]);
        }

        public void WriteGrid(DataGridView dataGridView, RichTextBox richTextBox)
        {
            dataGridView.Rows.Add();
            DataGridViewRow dataGridViewRow = dataGridView.Rows[dataGridView.RowCount - 1];
            dataGridViewRow.Cells["Alpha"].Value = 180 / Math.PI * Alpha;
            dataGridViewRow.Cells["Gamma"].Value = 180 / Math.PI * Gamma;
            dataGridViewRow.Cells["Fi"].Value = 180 / Math.PI * Fi;
            dataGridViewRow.Cells["Teta"].Value = 180 / Math.PI * Teta;
            dataGridViewRow.Cells["XX"].Value = X;
            dataGridViewRow.Cells["YY"].Value = Y;
            dataGridViewRow.Cells["ZZ"].Value = Z;
            dataGridViewRow.Cells["AlphaPW"].Value = AlphaPW;
            dataGridViewRow.Cells["GammaPW"].Value = GammaPW;
            dataGridViewRow.Cells["FiPW"].Value = FiPW;
            dataGridViewRow.Cells["TetaPW"].Value = TetaPW;
            richTextBox.AppendText(Environment.NewLine + 
                $"config[{dataGridView.RowCount - 1}] = (PositionConfig){{ {AlphaPW}, {GammaPW}, {TetaPW}, {FiPW} }};");

        }

    }
}
