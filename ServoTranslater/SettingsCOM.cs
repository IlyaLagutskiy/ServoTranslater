using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace ServoTranslater
{
    public partial class SettingsCom : Form
    {
        public SettingsCom()
        {
            InitializeComponent();
        }

        private void SettingsCOM_Load(object sender, EventArgs e)
        {
            comboBox1_DropDown(sender, e);
            comboBox1.SelectedItem = SettCom.Default.Port;
            comboBox2.SelectedItem = SettCom.Default.BaudRate.ToString();
            comboBox3.SelectedItem = SettCom.Default.DataBits.ToString();
            comboBox4.SelectedItem = SettCom.Default.Parity.ToString();
            comboBox5.SelectedItem = SettCom.Default.StopBits.ToString();
            textBox1.Text = SettCom.Default.ReadTimeout.ToString();
            textBox2.Text = SettCom.Default.WriteTimeout.ToString();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ports);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettCom.Default.Port = COM.PortName;
            SettCom.Default.BaudRate = COM.BaudRate;
            SettCom.Default.DataBits = COM.DataBits;
            SettCom.Default.ReadTimeout = COM.ReadTimeout;
            SettCom.Default.WriteTimeout = COM.WriteTimeout;
            SettCom.Default.Parity = COM.Parity;
            SettCom.Default.StopBits = COM.StopBits;
            SettCom.Default.Save();
            button1.Enabled = false;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            bool isException = false;
            try
            {
                COM.PortName = comboBox1.SelectedItem.ToString();
                COM.BaudRate = int.Parse(comboBox2.SelectedItem.ToString());
                COM.DataBits = int.Parse(comboBox3.SelectedItem.ToString());
                COM.ReadTimeout = int.Parse(textBox1.Text);
                COM.WriteTimeout = int.Parse(textBox2.Text);
                switch (comboBox4.SelectedItem)
                {
                    case "None":
                        COM.Parity = Parity.None;
                        break;
                    case "Even":
                        COM.Parity = Parity.Even;
                        break;
                    case "Odd":
                        COM.Parity = Parity.Odd;
                        break;
                    case "Mark":
                        COM.Parity = Parity.Mark;
                        break;
                    case "Space":
                        COM.Parity = Parity.Space;
                        break; 
                }
                switch (comboBox5.SelectedItem)
                {
                    case "One":
                        COM.StopBits = StopBits.One;
                        break;
                    case "OnePointFive":
                        COM.StopBits = StopBits.OnePointFive;
                        break;
                    case "Two":
                        COM.StopBits = StopBits.Two;
                        break;
                }
                COM.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Открытие невозможно : " + ex.Message);
                isException = true;
            }
            finally
            {
                if(COM.IsOpen)
                {
                    COM.Close();
                }
                if(!isException)
                {
                    button1.Enabled = true;
                    MessageBox.Show("Succesfull opened COM-port. Save settings");
                }
            }
        }
    }
}
