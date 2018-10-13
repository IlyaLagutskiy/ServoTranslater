using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServoTranslater
{
    class Coordinate
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        public double Z { get; set; } = 0;

        public double Alpha { get; private set; } = 0;
        public double Gamma { get; private set; } = 0;
        public double Fi { get; private set; } = 0;
        public double Teta { get; set; } = 0;

        public Coordinate()
        {

        }
        
        public Coordinate(double x, double y, double z)
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
            dataGridViewRow.Cells["Alpha"].Value = Alpha;
            dataGridViewRow.Cells["Gamma"].Value = Gamma;
            dataGridViewRow.Cells["Fi"].Value = Fi;
            dataGridViewRow.Cells["Teta"].Value = Teta;

        }

    }
}
