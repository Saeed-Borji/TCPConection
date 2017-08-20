namespace WindowsFormsApptest1
{
    partial class POSSimulatorForm
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
            this.ServergroupBox = new System.Windows.Forms.GroupBox();
            this.PORTtxtBox = new System.Windows.Forms.TextBox();
            this.IPtxtBox = new System.Windows.Forms.TextBox();
            this.PORTlabel2 = new System.Windows.Forms.Label();
            this.IPlabel1 = new System.Windows.Forms.Label();
            this.SENDbutton = new System.Windows.Forms.Button();
            this.KeyInfogroupBox4 = new System.Windows.Forms.GroupBox();
            this.MAC_KEYtxtBox5 = new System.Windows.Forms.TextBox();
            this.PIN_KEYtxtBox6 = new System.Windows.Forms.TextBox();
            this.MAC_KEYlabel3 = new System.Windows.Forms.Label();
            this.PIN_KEYlabel4 = new System.Windows.Forms.Label();
            this.POSinfogroupBox = new System.Windows.Forms.GroupBox();
            this.TRACK2txtBox = new System.Windows.Forms.TextBox();
            this.TRACK2label8 = new System.Windows.Forms.Label();
            this.PINtxtBox = new System.Windows.Forms.TextBox();
            this.PINlabel7 = new System.Windows.Forms.Label();
            this.CARDNUMBERtxtBox = new System.Windows.Forms.TextBox();
            this.AMOUNTtextBox = new System.Windows.Forms.TextBox();
            this.CARDNUMBERlabel5 = new System.Windows.Forms.Label();
            this.AMOUNTlabel6 = new System.Windows.Forms.Label();
            this.RecivedtxtBox = new System.Windows.Forms.TextBox();
            this.RecivedBytesgroupBox = new System.Windows.Forms.GroupBox();
            this.RecParsBytestxtBox = new System.Windows.Forms.TextBox();
            this.RecParsBytesgroupBox = new System.Windows.Forms.GroupBox();
            this.SendBytesgroupBox = new System.Windows.Forms.GroupBox();
            this.SendBytestxtBox = new System.Windows.Forms.TextBox();
            this.TerminalInfogroupBox = new System.Windows.Forms.GroupBox();
            this.TerminalIDlabel = new System.Windows.Forms.Label();
            this.MerchantIDlabel = new System.Windows.Forms.Label();
            this.TerminalIDtextBox = new System.Windows.Forms.TextBox();
            this.MerchantIDtextBox = new System.Windows.Forms.TextBox();
            this.ServergroupBox.SuspendLayout();
            this.KeyInfogroupBox4.SuspendLayout();
            this.POSinfogroupBox.SuspendLayout();
            this.RecivedBytesgroupBox.SuspendLayout();
            this.RecParsBytesgroupBox.SuspendLayout();
            this.SendBytesgroupBox.SuspendLayout();
            this.TerminalInfogroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServergroupBox
            // 
            this.ServergroupBox.Controls.Add(this.PORTtxtBox);
            this.ServergroupBox.Controls.Add(this.IPtxtBox);
            this.ServergroupBox.Controls.Add(this.PORTlabel2);
            this.ServergroupBox.Controls.Add(this.IPlabel1);
            this.ServergroupBox.Location = new System.Drawing.Point(22, 12);
            this.ServergroupBox.Name = "ServergroupBox";
            this.ServergroupBox.Size = new System.Drawing.Size(233, 74);
            this.ServergroupBox.TabIndex = 0;
            this.ServergroupBox.TabStop = false;
            this.ServergroupBox.Text = "Server";
            this.ServergroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PORTtxtBox
            // 
            this.PORTtxtBox.Location = new System.Drawing.Point(87, 49);
            this.PORTtxtBox.Name = "PORTtxtBox";
            this.PORTtxtBox.Size = new System.Drawing.Size(122, 20);
            this.PORTtxtBox.TabIndex = 3;
            this.PORTtxtBox.TextChanged += new System.EventHandler(this.PORTtxtBox_TextChanged);
            // 
            // IPtxtBox
            // 
            this.IPtxtBox.Location = new System.Drawing.Point(87, 19);
            this.IPtxtBox.Name = "IPtxtBox";
            this.IPtxtBox.Size = new System.Drawing.Size(122, 20);
            this.IPtxtBox.TabIndex = 2;
            this.IPtxtBox.TextChanged += new System.EventHandler(this.IPtxtBox_TextChanged);
            // 
            // PORTlabel2
            // 
            this.PORTlabel2.AutoSize = true;
            this.PORTlabel2.Location = new System.Drawing.Point(7, 52);
            this.PORTlabel2.Name = "PORTlabel2";
            this.PORTlabel2.Size = new System.Drawing.Size(37, 13);
            this.PORTlabel2.TabIndex = 1;
            this.PORTlabel2.Text = "PORT";
            this.PORTlabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IPlabel1
            // 
            this.IPlabel1.AutoSize = true;
            this.IPlabel1.Location = new System.Drawing.Point(7, 29);
            this.IPlabel1.Name = "IPlabel1";
            this.IPlabel1.Size = new System.Drawing.Size(17, 13);
            this.IPlabel1.TabIndex = 0;
            this.IPlabel1.Text = "IP";
            // 
            // SENDbutton
            // 
            this.SENDbutton.Location = new System.Drawing.Point(32, 446);
            this.SENDbutton.Name = "SENDbutton";
            this.SENDbutton.Size = new System.Drawing.Size(75, 23);
            this.SENDbutton.TabIndex = 3;
            this.SENDbutton.Text = "SEND";
            this.SENDbutton.UseVisualStyleBackColor = true;
            this.SENDbutton.Click += new System.EventHandler(this.SENDbutton_Click);
            // 
            // KeyInfogroupBox4
            // 
            this.KeyInfogroupBox4.Controls.Add(this.MAC_KEYtxtBox5);
            this.KeyInfogroupBox4.Controls.Add(this.PIN_KEYtxtBox6);
            this.KeyInfogroupBox4.Controls.Add(this.MAC_KEYlabel3);
            this.KeyInfogroupBox4.Controls.Add(this.PIN_KEYlabel4);
            this.KeyInfogroupBox4.Location = new System.Drawing.Point(22, 93);
            this.KeyInfogroupBox4.Name = "KeyInfogroupBox4";
            this.KeyInfogroupBox4.Size = new System.Drawing.Size(233, 72);
            this.KeyInfogroupBox4.TabIndex = 5;
            this.KeyInfogroupBox4.TabStop = false;
            this.KeyInfogroupBox4.Text = "KeyInfo";
            // 
            // MAC_KEYtxtBox5
            // 
            this.MAC_KEYtxtBox5.Location = new System.Drawing.Point(99, 48);
            this.MAC_KEYtxtBox5.Name = "MAC_KEYtxtBox5";
            this.MAC_KEYtxtBox5.Size = new System.Drawing.Size(90, 20);
            this.MAC_KEYtxtBox5.TabIndex = 3;
            this.MAC_KEYtxtBox5.TextChanged += new System.EventHandler(this.MAC_KEYtxtBox5_TextChanged);
            // 
            // PIN_KEYtxtBox6
            // 
            this.PIN_KEYtxtBox6.Location = new System.Drawing.Point(99, 18);
            this.PIN_KEYtxtBox6.Name = "PIN_KEYtxtBox6";
            this.PIN_KEYtxtBox6.Size = new System.Drawing.Size(90, 20);
            this.PIN_KEYtxtBox6.TabIndex = 2;
            this.PIN_KEYtxtBox6.TextChanged += new System.EventHandler(this.PIN_KEYtxtBox6_TextChanged);
            // 
            // MAC_KEYlabel3
            // 
            this.MAC_KEYlabel3.AutoSize = true;
            this.MAC_KEYlabel3.Location = new System.Drawing.Point(7, 51);
            this.MAC_KEYlabel3.Name = "MAC_KEYlabel3";
            this.MAC_KEYlabel3.Size = new System.Drawing.Size(77, 13);
            this.MAC_KEYlabel3.TabIndex = 1;
            this.MAC_KEYlabel3.Text = "MAC_KEY No.";
            // 
            // PIN_KEYlabel4
            // 
            this.PIN_KEYlabel4.AutoSize = true;
            this.PIN_KEYlabel4.Location = new System.Drawing.Point(7, 18);
            this.PIN_KEYlabel4.Name = "PIN_KEYlabel4";
            this.PIN_KEYlabel4.Size = new System.Drawing.Size(72, 13);
            this.PIN_KEYlabel4.TabIndex = 0;
            this.PIN_KEYlabel4.Text = "PIN_KEY No.";
            this.PIN_KEYlabel4.Click += new System.EventHandler(this.label4_Click);
            // 
            // POSinfogroupBox
            // 
            this.POSinfogroupBox.Controls.Add(this.TRACK2txtBox);
            this.POSinfogroupBox.Controls.Add(this.TRACK2label8);
            this.POSinfogroupBox.Controls.Add(this.PINtxtBox);
            this.POSinfogroupBox.Controls.Add(this.PINlabel7);
            this.POSinfogroupBox.Controls.Add(this.CARDNUMBERtxtBox);
            this.POSinfogroupBox.Controls.Add(this.AMOUNTtextBox);
            this.POSinfogroupBox.Controls.Add(this.CARDNUMBERlabel5);
            this.POSinfogroupBox.Controls.Add(this.AMOUNTlabel6);
            this.POSinfogroupBox.Location = new System.Drawing.Point(22, 280);
            this.POSinfogroupBox.Name = "POSinfogroupBox";
            this.POSinfogroupBox.Size = new System.Drawing.Size(367, 160);
            this.POSinfogroupBox.TabIndex = 6;
            this.POSinfogroupBox.TabStop = false;
            this.POSinfogroupBox.Text = "POSInfo";
            this.POSinfogroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TRACK2txtBox
            // 
            this.TRACK2txtBox.Location = new System.Drawing.Point(99, 124);
            this.TRACK2txtBox.Name = "TRACK2txtBox";
            this.TRACK2txtBox.Size = new System.Drawing.Size(246, 20);
            this.TRACK2txtBox.TabIndex = 7;
            this.TRACK2txtBox.TextChanged += new System.EventHandler(this.TRACK2txtBox_TextChanged);
            // 
            // TRACK2label8
            // 
            this.TRACK2label8.AutoSize = true;
            this.TRACK2label8.Location = new System.Drawing.Point(7, 131);
            this.TRACK2label8.Name = "TRACK2label8";
            this.TRACK2label8.Size = new System.Drawing.Size(52, 13);
            this.TRACK2label8.TabIndex = 6;
            this.TRACK2label8.Text = "TRACK 2";
            this.TRACK2label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PINtxtBox
            // 
            this.PINtxtBox.Location = new System.Drawing.Point(99, 92);
            this.PINtxtBox.Name = "PINtxtBox";
            this.PINtxtBox.Size = new System.Drawing.Size(44, 20);
            this.PINtxtBox.TabIndex = 5;
            this.PINtxtBox.TextChanged += new System.EventHandler(this.PINtxtBox_TextChanged);
            // 
            // PINlabel7
            // 
            this.PINlabel7.AutoSize = true;
            this.PINlabel7.Location = new System.Drawing.Point(7, 99);
            this.PINlabel7.Name = "PINlabel7";
            this.PINlabel7.Size = new System.Drawing.Size(25, 13);
            this.PINlabel7.TabIndex = 4;
            this.PINlabel7.Text = "PIN";
            this.PINlabel7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CARDNUMBERtxtBox
            // 
            this.CARDNUMBERtxtBox.Location = new System.Drawing.Point(99, 58);
            this.CARDNUMBERtxtBox.Name = "CARDNUMBERtxtBox";
            this.CARDNUMBERtxtBox.Size = new System.Drawing.Size(134, 20);
            this.CARDNUMBERtxtBox.TabIndex = 3;
            this.CARDNUMBERtxtBox.TextChanged += new System.EventHandler(this.CARDNUMBERtxtBox_TextChanged);
            // 
            // AMOUNTtextBox
            // 
            this.AMOUNTtextBox.Location = new System.Drawing.Point(99, 19);
            this.AMOUNTtextBox.Name = "AMOUNTtextBox";
            this.AMOUNTtextBox.Size = new System.Drawing.Size(134, 20);
            this.AMOUNTtextBox.TabIndex = 2;
            this.AMOUNTtextBox.TextChanged += new System.EventHandler(this.AMOUNTtextBox_TextChanged);
            // 
            // CARDNUMBERlabel5
            // 
            this.CARDNUMBERlabel5.AutoSize = true;
            this.CARDNUMBERlabel5.Location = new System.Drawing.Point(7, 61);
            this.CARDNUMBERlabel5.Name = "CARDNUMBERlabel5";
            this.CARDNUMBERlabel5.Size = new System.Drawing.Size(87, 13);
            this.CARDNUMBERlabel5.TabIndex = 1;
            this.CARDNUMBERlabel5.Text = "CARD NUMBER";
            // 
            // AMOUNTlabel6
            // 
            this.AMOUNTlabel6.AutoSize = true;
            this.AMOUNTlabel6.Location = new System.Drawing.Point(7, 18);
            this.AMOUNTlabel6.Name = "AMOUNTlabel6";
            this.AMOUNTlabel6.Size = new System.Drawing.Size(54, 13);
            this.AMOUNTlabel6.TabIndex = 0;
            this.AMOUNTlabel6.Text = "AMOUNT";
            this.AMOUNTlabel6.Click += new System.EventHandler(this.label6_Click);
            // 
            // RecivedtxtBox
            // 
            this.RecivedtxtBox.Location = new System.Drawing.Point(23, 24);
            this.RecivedtxtBox.Multiline = true;
            this.RecivedtxtBox.Name = "RecivedtxtBox";
            this.RecivedtxtBox.Size = new System.Drawing.Size(413, 69);
            this.RecivedtxtBox.TabIndex = 1;
            this.RecivedtxtBox.TextChanged += new System.EventHandler(this.RecivedtxtBox_TextChanged);
            // 
            // RecivedBytesgroupBox
            // 
            this.RecivedBytesgroupBox.Controls.Add(this.RecivedtxtBox);
            this.RecivedBytesgroupBox.Location = new System.Drawing.Point(411, 174);
            this.RecivedBytesgroupBox.Name = "RecivedBytesgroupBox";
            this.RecivedBytesgroupBox.Size = new System.Drawing.Size(455, 121);
            this.RecivedBytesgroupBox.TabIndex = 8;
            this.RecivedBytesgroupBox.TabStop = false;
            this.RecivedBytesgroupBox.Text = "RecivedBytes";
            this.RecivedBytesgroupBox.Enter += new System.EventHandler(this.RecivedBytesgroupBox_Enter);
            // 
            // RecParsBytestxtBox
            // 
            this.RecParsBytestxtBox.Location = new System.Drawing.Point(23, 31);
            this.RecParsBytestxtBox.Multiline = true;
            this.RecParsBytestxtBox.Name = "RecParsBytestxtBox";
            this.RecParsBytestxtBox.Size = new System.Drawing.Size(413, 69);
            this.RecParsBytestxtBox.TabIndex = 1;
            this.RecParsBytestxtBox.TextChanged += new System.EventHandler(this.RecParsBytestxtBox_TextChanged);
            // 
            // RecParsBytesgroupBox
            // 
            this.RecParsBytesgroupBox.Controls.Add(this.RecParsBytestxtBox);
            this.RecParsBytesgroupBox.Location = new System.Drawing.Point(411, 307);
            this.RecParsBytesgroupBox.Name = "RecParsBytesgroupBox";
            this.RecParsBytesgroupBox.Size = new System.Drawing.Size(455, 121);
            this.RecParsBytesgroupBox.TabIndex = 8;
            this.RecParsBytesgroupBox.TabStop = false;
            this.RecParsBytesgroupBox.Text = "RecParsBytes";
            this.RecParsBytesgroupBox.Enter += new System.EventHandler(this.RecParsBytesgroupBox_Enter);
            // 
            // SendBytesgroupBox
            // 
            this.SendBytesgroupBox.Controls.Add(this.SendBytestxtBox);
            this.SendBytesgroupBox.Location = new System.Drawing.Point(411, 31);
            this.SendBytesgroupBox.Name = "SendBytesgroupBox";
            this.SendBytesgroupBox.Size = new System.Drawing.Size(455, 100);
            this.SendBytesgroupBox.TabIndex = 9;
            this.SendBytesgroupBox.TabStop = false;
            this.SendBytesgroupBox.Text = "SendBytes";
            // 
            // SendBytestxtBox
            // 
            this.SendBytestxtBox.Location = new System.Drawing.Point(24, 19);
            this.SendBytestxtBox.Multiline = true;
            this.SendBytestxtBox.Name = "SendBytestxtBox";
            this.SendBytestxtBox.Size = new System.Drawing.Size(412, 65);
            this.SendBytestxtBox.TabIndex = 0;
            this.SendBytestxtBox.TextChanged += new System.EventHandler(this.SendBytestxtBox_TextChanged);
            // 
            // TerminalInfogroupBox
            // 
            this.TerminalInfogroupBox.Controls.Add(this.MerchantIDtextBox);
            this.TerminalInfogroupBox.Controls.Add(this.TerminalIDtextBox);
            this.TerminalInfogroupBox.Controls.Add(this.MerchantIDlabel);
            this.TerminalInfogroupBox.Controls.Add(this.TerminalIDlabel);
            this.TerminalInfogroupBox.Location = new System.Drawing.Point(26, 174);
            this.TerminalInfogroupBox.Name = "TerminalInfogroupBox";
            this.TerminalInfogroupBox.Size = new System.Drawing.Size(363, 98);
            this.TerminalInfogroupBox.TabIndex = 10;
            this.TerminalInfogroupBox.TabStop = false;
            this.TerminalInfogroupBox.Text = "TerminalInfo";
            this.TerminalInfogroupBox.Enter += new System.EventHandler(this.groupBox1_Enter_2);
            // 
            // TerminalIDlabel
            // 
            this.TerminalIDlabel.AutoSize = true;
            this.TerminalIDlabel.Location = new System.Drawing.Point(20, 24);
            this.TerminalIDlabel.Name = "TerminalIDlabel";
            this.TerminalIDlabel.Size = new System.Drawing.Size(76, 13);
            this.TerminalIDlabel.TabIndex = 0;
            this.TerminalIDlabel.Text = "TERMINAL ID";
            this.TerminalIDlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MerchantIDlabel
            // 
            this.MerchantIDlabel.AutoSize = true;
            this.MerchantIDlabel.Location = new System.Drawing.Point(22, 62);
            this.MerchantIDlabel.Name = "MerchantIDlabel";
            this.MerchantIDlabel.Size = new System.Drawing.Size(82, 13);
            this.MerchantIDlabel.TabIndex = 1;
            this.MerchantIDlabel.Text = "MERCHANT ID";
            // 
            // TerminalIDtextBox
            // 
            this.TerminalIDtextBox.Location = new System.Drawing.Point(143, 20);
            this.TerminalIDtextBox.Name = "TerminalIDtextBox";
            this.TerminalIDtextBox.Size = new System.Drawing.Size(173, 20);
            this.TerminalIDtextBox.TabIndex = 2;
            this.TerminalIDtextBox.TextChanged += new System.EventHandler(this.TerminalIDtextBox_TextChanged);
            // 
            // MerchantIDtextBox
            // 
            this.MerchantIDtextBox.Location = new System.Drawing.Point(143, 54);
            this.MerchantIDtextBox.Name = "MerchantIDtextBox";
            this.MerchantIDtextBox.Size = new System.Drawing.Size(173, 20);
            this.MerchantIDtextBox.TabIndex = 3;
            this.MerchantIDtextBox.TextChanged += new System.EventHandler(this.MerchantIDtextBox_TextChanged);
            // 
            // POSSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 501);
            this.Controls.Add(this.TerminalInfogroupBox);
            this.Controls.Add(this.SendBytesgroupBox);
            this.Controls.Add(this.RecParsBytesgroupBox);
            this.Controls.Add(this.RecivedBytesgroupBox);
            this.Controls.Add(this.POSinfogroupBox);
            this.Controls.Add(this.KeyInfogroupBox4);
            this.Controls.Add(this.SENDbutton);
            this.Controls.Add(this.ServergroupBox);
            this.Name = "POSSimulatorForm";
            this.Text = "POSSimulator";
            this.Load += new System.EventHandler(this.POSSimulatorForm_Load);
            this.ServergroupBox.ResumeLayout(false);
            this.ServergroupBox.PerformLayout();
            this.KeyInfogroupBox4.ResumeLayout(false);
            this.KeyInfogroupBox4.PerformLayout();
            this.POSinfogroupBox.ResumeLayout(false);
            this.POSinfogroupBox.PerformLayout();
            this.RecivedBytesgroupBox.ResumeLayout(false);
            this.RecivedBytesgroupBox.PerformLayout();
            this.RecParsBytesgroupBox.ResumeLayout(false);
            this.RecParsBytesgroupBox.PerformLayout();
            this.SendBytesgroupBox.ResumeLayout(false);
            this.SendBytesgroupBox.PerformLayout();
            this.TerminalInfogroupBox.ResumeLayout(false);
            this.TerminalInfogroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ServergroupBox;
        private System.Windows.Forms.Label PORTlabel2;
        private System.Windows.Forms.Label IPlabel1;
        private System.Windows.Forms.Button SENDbutton;
        private System.Windows.Forms.GroupBox KeyInfogroupBox4;
        private System.Windows.Forms.TextBox MAC_KEYtxtBox5;
        private System.Windows.Forms.TextBox PIN_KEYtxtBox6;
        private System.Windows.Forms.Label MAC_KEYlabel3;
        private System.Windows.Forms.Label PIN_KEYlabel4;
        private System.Windows.Forms.GroupBox POSinfogroupBox;
        private System.Windows.Forms.TextBox CARDNUMBERtxtBox;
        private System.Windows.Forms.TextBox AMOUNTtextBox;
        private System.Windows.Forms.Label CARDNUMBERlabel5;
        private System.Windows.Forms.Label AMOUNTlabel6;
        private System.Windows.Forms.TextBox PINtxtBox;
        private System.Windows.Forms.Label PINlabel7;
        private System.Windows.Forms.Label TRACK2label8;
        private System.Windows.Forms.TextBox RecivedtxtBox;
        private System.Windows.Forms.GroupBox RecivedBytesgroupBox;
        private System.Windows.Forms.TextBox RecParsBytestxtBox;
        private System.Windows.Forms.GroupBox RecParsBytesgroupBox;
        private System.Windows.Forms.TextBox IPtxtBox;
        private System.Windows.Forms.TextBox PORTtxtBox;
        private System.Windows.Forms.TextBox TRACK2txtBox;
        private System.Windows.Forms.GroupBox SendBytesgroupBox;
        private System.Windows.Forms.TextBox SendBytestxtBox;
        private System.Windows.Forms.GroupBox TerminalInfogroupBox;
        private System.Windows.Forms.Label TerminalIDlabel;
        private System.Windows.Forms.TextBox MerchantIDtextBox;
        private System.Windows.Forms.TextBox TerminalIDtextBox;
        private System.Windows.Forms.Label MerchantIDlabel;
    }
}

