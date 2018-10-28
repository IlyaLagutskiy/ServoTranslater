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
    public partial class MainForm : Form
    {
        public MainForm()
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
                coordinate.Execute();
                coordinate.WriteGrid(dataGridView2);
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
                COM.Write(byteArray, 0, 2*txBuffer.Count());
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
            int length = 2 * txBuffer.Count();
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

    }
}
