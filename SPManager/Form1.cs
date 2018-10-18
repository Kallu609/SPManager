using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SPManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupForm();
            LoadCOMPorts();
        }

        private void SetupForm()
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
        }

        private void LoadCOMPorts()
        {
            string[] ports = SerialPort.GetPortNames();
        }

        private void WriteOutput(string text, Color color)
        {
            txtOutput.AppendText(Environment.NewLine + text, color);
            txtOutput.SelectionStart = txtOutput.Text.Length;
            txtOutput.ScrollToCaret();
        }

        private void SerialDeviceOutput(string text)
        {
            WriteOutput(text, Color.Blue);
        }

        private void HostDeviceOutput(string text)
        {
            WriteOutput(text, Color.Purple);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtMessage.Text))
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    return;
                }

                HostDeviceOutput(txtMessage.Text);
                txtMessage.Text = "";

                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
