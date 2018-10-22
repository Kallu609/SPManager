namespace SPManager
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFlowControl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCRLF = new System.Windows.Forms.Label();
            this.lblLF = new System.Windows.Forms.Label();
            this.lblCR = new System.Windows.Forms.Label();
            this.radioSentCRLF = new System.Windows.Forms.RadioButton();
            this.radioSentLF = new System.Windows.Forms.RadioButton();
            this.radioSentCR = new System.Windows.Forms.RadioButton();
            this.radioSentNone = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkStayOnTop = new System.Windows.Forms.CheckBox();
            this.chkQuitEsc = new System.Windows.Forms.CheckBox();
            this.chkAutocomplete = new System.Windows.Forms.CheckBox();
            this.radioSentPrintLocally = new System.Windows.Forms.CheckBox();
            this.chkRememberHistory = new System.Windows.Forms.CheckBox();
            this.chkCloseInactive = new System.Windows.Forms.CheckBox();
            this.cmbLocale = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRefreshRate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFlowControl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbParity);
            this.groupBox1.Controls.Add(this.cmbStopBits);
            this.groupBox1.Controls.Add(this.cmbDataBits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBaudrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sarjaportin asetukset";
            // 
            // cmbFlowControl
            // 
            this.cmbFlowControl.FormattingEnabled = true;
            this.cmbFlowControl.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cmbFlowControl.Location = new System.Drawing.Point(81, 154);
            this.cmbFlowControl.Name = "cmbFlowControl";
            this.cmbFlowControl.Size = new System.Drawing.Size(71, 21);
            this.cmbFlowControl.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Flow control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stop bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data bits";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "none",
            "RTS/CTS",
            "DTR/DSR",
            "XON/XOFF"});
            this.cmbParity.Location = new System.Drawing.Point(81, 127);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(71, 21);
            this.cmbParity.TabIndex = 7;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopBits.Location = new System.Drawing.Point(81, 100);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(71, 21);
            this.cmbStopBits.TabIndex = 6;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(81, 73);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(71, 21);
            this.cmbDataBits.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baudinopeus";
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cmbBaudrate.Location = new System.Drawing.Point(81, 46);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(71, 21);
            this.cmbBaudrate.TabIndex = 3;
            this.cmbBaudrate.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Portti";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(81, 19);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(71, 21);
            this.cmbPort.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSentPrintLocally);
            this.groupBox2.Controls.Add(this.lblCRLF);
            this.groupBox2.Controls.Add(this.lblLF);
            this.groupBox2.Controls.Add(this.lblCR);
            this.groupBox2.Controls.Add(this.radioSentCRLF);
            this.groupBox2.Controls.Add(this.radioSentLF);
            this.groupBox2.Controls.Add(this.radioSentCR);
            this.groupBox2.Controls.Add(this.radioSentNone);
            this.groupBox2.Location = new System.Drawing.Point(169, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lähetetty data";
            // 
            // lblCRLF
            // 
            this.lblCRLF.AutoSize = true;
            this.lblCRLF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRLF.Location = new System.Drawing.Point(94, 90);
            this.lblCRLF.Name = "lblCRLF";
            this.lblCRLF.Size = new System.Drawing.Size(35, 14);
            this.lblCRLF.TabIndex = 6;
            this.lblCRLF.Text = "\\r\\n";
            // 
            // lblLF
            // 
            this.lblLF.AutoSize = true;
            this.lblLF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLF.Location = new System.Drawing.Point(94, 67);
            this.lblLF.Name = "lblLF";
            this.lblLF.Size = new System.Drawing.Size(21, 14);
            this.lblLF.TabIndex = 5;
            this.lblLF.Text = "\\n";
            // 
            // lblCR
            // 
            this.lblCR.AutoSize = true;
            this.lblCR.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCR.Location = new System.Drawing.Point(94, 44);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(21, 14);
            this.lblCR.TabIndex = 4;
            this.lblCR.Text = "\\r";
            // 
            // radioSentCRLF
            // 
            this.radioSentCRLF.AutoSize = true;
            this.radioSentCRLF.Location = new System.Drawing.Point(6, 88);
            this.radioSentCRLF.Name = "radioSentCRLF";
            this.radioSentCRLF.Size = new System.Drawing.Size(91, 17);
            this.radioSentCRLF.TabIndex = 3;
            this.radioSentCRLF.Text = "Lisää loppuun";
            this.radioSentCRLF.UseVisualStyleBackColor = true;
            // 
            // radioSentLF
            // 
            this.radioSentLF.AutoSize = true;
            this.radioSentLF.Checked = true;
            this.radioSentLF.Location = new System.Drawing.Point(6, 65);
            this.radioSentLF.Name = "radioSentLF";
            this.radioSentLF.Size = new System.Drawing.Size(91, 17);
            this.radioSentLF.TabIndex = 2;
            this.radioSentLF.TabStop = true;
            this.radioSentLF.Text = "Lisää loppuun";
            this.radioSentLF.UseVisualStyleBackColor = true;
            // 
            // radioSentCR
            // 
            this.radioSentCR.AutoSize = true;
            this.radioSentCR.Location = new System.Drawing.Point(6, 42);
            this.radioSentCR.Name = "radioSentCR";
            this.radioSentCR.Size = new System.Drawing.Size(91, 17);
            this.radioSentCR.TabIndex = 1;
            this.radioSentCR.Text = "Lisää loppuun";
            this.radioSentCR.UseVisualStyleBackColor = true;
            // 
            // radioSentNone
            // 
            this.radioSentNone.AutoSize = true;
            this.radioSentNone.Location = new System.Drawing.Point(6, 19);
            this.radioSentNone.Name = "radioSentNone";
            this.radioSentNone.Size = new System.Drawing.Size(98, 17);
            this.radioSentNone.TabIndex = 0;
            this.radioSentNone.Text = "Älä lisää mitään";
            this.radioSentNone.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtRefreshRate);
            this.groupBox3.Location = new System.Drawing.Point(169, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 44);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saapuva data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Päivitystaajuus: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cmbLocale);
            this.groupBox5.Controls.Add(this.chkCloseInactive);
            this.groupBox5.Controls.Add(this.chkRememberHistory);
            this.groupBox5.Controls.Add(this.chkAutocomplete);
            this.groupBox5.Controls.Add(this.chkQuitEsc);
            this.groupBox5.Controls.Add(this.chkStayOnTop);
            this.groupBox5.Location = new System.Drawing.Point(327, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(164, 182);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Yleiset";
            // 
            // chkStayOnTop
            // 
            this.chkStayOnTop.AutoSize = true;
            this.chkStayOnTop.Location = new System.Drawing.Point(6, 20);
            this.chkStayOnTop.Name = "chkStayOnTop";
            this.chkStayOnTop.Size = new System.Drawing.Size(122, 17);
            this.chkStayOnTop.TabIndex = 5;
            this.chkStayOnTop.Text = "Pysy päällimmäisenä";
            this.chkStayOnTop.UseVisualStyleBackColor = true;
            // 
            // chkQuitEsc
            // 
            this.chkQuitEsc.AutoSize = true;
            this.chkQuitEsc.Checked = true;
            this.chkQuitEsc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuitEsc.Location = new System.Drawing.Point(6, 43);
            this.chkQuitEsc.Name = "chkQuitEsc";
            this.chkQuitEsc.Size = new System.Drawing.Size(102, 17);
            this.chkQuitEsc.TabIndex = 6;
            this.chkQuitEsc.Text = "Lopeta ESC:istä";
            this.chkQuitEsc.UseVisualStyleBackColor = true;
            // 
            // chkAutocomplete
            // 
            this.chkAutocomplete.AutoSize = true;
            this.chkAutocomplete.Checked = true;
            this.chkAutocomplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutocomplete.Location = new System.Drawing.Point(6, 66);
            this.chkAutocomplete.Name = "chkAutocomplete";
            this.chkAutocomplete.Size = new System.Drawing.Size(145, 17);
            this.chkAutocomplete.TabIndex = 7;
            this.chkAutocomplete.Text = "Automaattinen täydennys";
            this.chkAutocomplete.UseVisualStyleBackColor = true;
            // 
            // radioSentPrintLocally
            // 
            this.radioSentPrintLocally.AutoSize = true;
            this.radioSentPrintLocally.Checked = true;
            this.radioSentPrintLocally.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radioSentPrintLocally.Location = new System.Drawing.Point(6, 111);
            this.radioSentPrintLocally.Name = "radioSentPrintLocally";
            this.radioSentPrintLocally.Size = new System.Drawing.Size(117, 17);
            this.radioSentPrintLocally.TabIndex = 8;
            this.radioSentPrintLocally.Text = "Tulosta paikallisesti";
            this.radioSentPrintLocally.UseVisualStyleBackColor = true;
            // 
            // chkRememberHistory
            // 
            this.chkRememberHistory.AutoSize = true;
            this.chkRememberHistory.Checked = true;
            this.chkRememberHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRememberHistory.Location = new System.Drawing.Point(6, 89);
            this.chkRememberHistory.Name = "chkRememberHistory";
            this.chkRememberHistory.Size = new System.Drawing.Size(93, 17);
            this.chkRememberHistory.TabIndex = 8;
            this.chkRememberHistory.Text = "Muista historia";
            this.chkRememberHistory.UseVisualStyleBackColor = true;
            // 
            // chkCloseInactive
            // 
            this.chkCloseInactive.AutoSize = true;
            this.chkCloseInactive.Location = new System.Drawing.Point(6, 112);
            this.chkCloseInactive.Name = "chkCloseInactive";
            this.chkCloseInactive.Size = new System.Drawing.Size(153, 17);
            this.chkCloseInactive.TabIndex = 9;
            this.chkCloseInactive.Text = "Sulje yhteys epäaktiivisena";
            this.chkCloseInactive.UseVisualStyleBackColor = true;
            // 
            // cmbLocale
            // 
            this.cmbLocale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocale.FormattingEnabled = true;
            this.cmbLocale.Items.AddRange(new object[] {
            "Finnish",
            "English"});
            this.cmbLocale.Location = new System.Drawing.Point(6, 156);
            this.cmbLocale.Name = "cmbLocale";
            this.cmbLocale.Size = new System.Drawing.Size(145, 21);
            this.cmbLocale.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Käyttöliittymän kieli";
            // 
            // txtRefreshRate
            // 
            this.txtRefreshRate.Location = new System.Drawing.Point(89, 19);
            this.txtRefreshRate.Name = "txtRefreshRate";
            this.txtRefreshRate.Size = new System.Drawing.Size(36, 20);
            this.txtRefreshRate.TabIndex = 0;
            this.txtRefreshRate.Text = "100";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 193);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asetukset";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFlowControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCRLF;
        private System.Windows.Forms.Label lblLF;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.RadioButton radioSentCRLF;
        private System.Windows.Forms.RadioButton radioSentLF;
        private System.Windows.Forms.RadioButton radioSentCR;
        private System.Windows.Forms.RadioButton radioSentNone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkAutocomplete;
        private System.Windows.Forms.CheckBox chkQuitEsc;
        private System.Windows.Forms.CheckBox chkStayOnTop;
        private System.Windows.Forms.CheckBox radioSentPrintLocally;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLocale;
        private System.Windows.Forms.CheckBox chkCloseInactive;
        private System.Windows.Forms.CheckBox chkRememberHistory;
        private System.Windows.Forms.TextBox txtRefreshRate;
    }
}