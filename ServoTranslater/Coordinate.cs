using System;
using System.Windows.Forms;

namespace ServoTranslater
{
    class Coordinate : Pulses
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Coordinate()
        {

        }
        
        public Coordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public new void Execute()
        {
            Fi = Translater.Fi(X, Y);
            Gamma = Translater.Gamma(X, Y, Z);
            Alpha = Translater.Alpha(Y, Z, Gamma);
            Teta = Alpha - Gamma;
            base.Execute();
        }
            
        public void ReadGrid(DataGridView dataGridView)
        {
            X = Convert.ToDouble(dataGridView.Rows[0].Cells["X"].Value);
            Y = Convert.ToDouble(dataGridView.Rows[0].Cells["Y"].Value);
            Z = Convert.ToDouble(dataGridView.Rows[0].Cells["Z"].Value);
            dataGridView.Rows.Remove(dataGridView.Rows[0]);
        }

        public void WriteGrid(DataGridView dataGridView)
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
           
        }

    }
}
