using System;
using System.Windows.Forms;

namespace ServoTranslater
{
    public partial class MainForm : Form
    {
        private bool _isXYZ = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var count = dataGridView1.RowCount - 1;
            Coordinate[] coordinate = new Coordinate[count];
            dataGridView2.Rows.Clear();
            for (ushort i = 0; i < count; i++)
            {
                coordinate[i]= new Coordinate(_isXYZ, dataGridView1, dataGridView2, i);
                dataGridView2.Rows.Add();
            }
            foreach (Coordinate c in coordinate)
            {
                c.Execute();
            }
            MessageBox.Show(@"Calculations executed!", @"Coordinate translation");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ushort[] txBuffer = { 1500, 2000, 1000, 1400 };
            byte[] byteArray = GetByteArray(txBuffer);
            COM.PortName = SettCom.Default.Port;
            COM.BaudRate = SettCom.Default.BaudRate;
            COM.DataBits = SettCom.Default.DataBits;
            COM.ReadTimeout = SettCom.Default.ReadTimeout;
            COM.WriteTimeout = SettCom.Default.WriteTimeout;
            COM.Parity = SettCom.Default.Parity;
            COM.StopBits = SettCom.Default.StopBits;
            try
            {
                COM.Open();
                COM.Write(byteArray, 0, 2*txBuffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (COM.IsOpen)
                {
                    COM.Close();
                }
            }
        }

        private static byte[] GetByteArray(ushort[] txBuffer)
        {
            int length = 2 * txBuffer.Length;
            byte[] bytes = new byte[length];
            for (int i = 0; i < length/2; i++)
            {
                BitConverter.GetBytes(txBuffer[i]).CopyTo(bytes, 2*i);
            }
            return bytes;
        }

        private void настройкиCOMпортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SettingsCom();
            form.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dataGridView1.Columns[0].ReadOnly = false;
                dataGridView1.Columns[1].ReadOnly = false;
                dataGridView1.Columns[2].ReadOnly = false;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                _isXYZ = true;

            }
            else
            {
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = false;
                dataGridView1.Columns[4].ReadOnly = false;
                dataGridView1.Columns[5].ReadOnly = false;
                _isXYZ = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
