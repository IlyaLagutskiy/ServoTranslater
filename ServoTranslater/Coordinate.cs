using System;
using System.Windows.Forms;

namespace ServoTranslater
{
    class Coordinate : Pulses
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        private readonly bool _isXYZ;
        private readonly DataGridView _fromDataGridView;
        private readonly DataGridView _toDataGridView;
        private readonly ushort _position;

        public Coordinate(bool isXYZ, DataGridView from, DataGridView to, ushort position)
        {
            _isXYZ = isXYZ;
            _fromDataGridView = from;
            _toDataGridView = to;
            _position = position;
        }

        public new void Execute()
        {
            ReadGrid();
            if (_isXYZ)
            {
                Fi = Translater.Fi(X, Y);
                Gamma = Translater.Gamma(X, Y, Z);
                Alpha = Translater.Alpha(Y, Z, Gamma);
                Teta = Alpha - Gamma;
            }
            base.Execute();
            WriteGrid();
        }
            
        public void ReadGrid()
        {
            if (_isXYZ)
            {
                X = Convert.ToDouble(_fromDataGridView.Rows[0].Cells["X"].Value);
                Y = Convert.ToDouble(_fromDataGridView.Rows[0].Cells["Y"].Value);
                Z = Convert.ToDouble(_fromDataGridView.Rows[0].Cells["Z"].Value);
            }
            else
            {
                Alpha = Convert.ToDouble(_fromDataGridView.Rows[0].Cells["Alpha"].Value) / 180 * Math.PI;
                Gamma = Convert.ToDouble(_fromDataGridView.Rows[0].Cells["Gamma"].Value) / 180 * Math.PI;
                Teta = Convert.ToDouble(_fromDataGridView.Rows[0].Cells["Teta"].Value) / 180 * Math.PI;
                Fi = Convert.ToDouble(_fromDataGridView.Rows[0].Cells["Fi"].Value) / 180 * Math.PI;
            }
        }

        public void WriteGrid()
        {
            DataGridViewRow from = _fromDataGridView.Rows[_position];
            if (_isXYZ)
            {
                from.Cells["Alpha"].Value = 180 / Math.PI * Alpha;
                from.Cells["Gamma"].Value = 180 / Math.PI * Gamma;
                from.Cells["Teta"].Value = 180 / Math.PI * Teta;
                from.Cells["Fi"].Value = 180 / Math.PI * Fi;
            }
            else
            {
                from.Cells["X"].Value = "NaN";
                from.Cells["Y"].Value = "NaN";
                from.Cells["Z"].Value = "Nan";
            }
            DataGridViewRow to = _toDataGridView.Rows[_position];
            to.Cells["AlphaPW"].Value = AlphaPW;
            to.Cells["GammaPW"].Value = GammaPW;
            to.Cells["FiPW"].Value = FiPW;
            to.Cells["TetaPW"].Value = TetaPW;
           
        }

    }
}
