using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SPManager
{
    public partial class FormMain : Form
    {
        FormSettings settingsForm;

        public FormMain()
        {
            InitializeComponent();
            SetupForm();
            LoadCOMPorts();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            WriteOutput($"{ProductName} v{ProductVersion} käynnistetty");
        }

        private void SetupForm()
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
        }

        private void LoadCOMPorts()
        {
            string[] ports = SerialPort.GetPortNames();
        }

        private void WriteOutput(string text, Color? color = null)
        {
            string newLine = !string.IsNullOrEmpty(txtOutput.Text) ? Environment.NewLine : "";

            txtOutput.AppendText(newLine + text, color ?? Color.Black);
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new FormSettings(this);
                settingsForm.ShowDialog(this);
                return;
            }

            // Good behaviour? yes? no?
            settingsForm.ShowDialog(this);
            settingsForm.Activate();
        }
    }
}
