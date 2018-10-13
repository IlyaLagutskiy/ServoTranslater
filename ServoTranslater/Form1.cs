using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServoTranslater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coordinate coordinate = new Coordinate();
            dataGridView2.Rows.Clear();
            while (dataGridView1.RowCount > 1)
            {
                coordinate.ReadGrid(dataGridView1);
                coordinate.ExecuteCalculations();
                coordinate.WriteGrid(dataGridView2);
            }
            MessageBox.Show("Calculations executed!", "Coordinate translation");
        }
    }
}
