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
            this.MerchantIDtextBox = new System.Windows.Forms.TextBox();
            this.TerminalIDtextBox = new System.Windows.Forms.TextBox();
            this.MerchantIDlabel = new System.Windows.Forms.Label();
            this.TerminalIDlabel = new System.Windows.Forms.Label();
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
            this.ServergroupBox.Location = new System.Drawing.Point(40, 22);
            this.ServergroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ServergroupBox.Name = "ServergroupBox";
            this.ServergroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ServergroupBox.Size = new System.Drawing.Size(427, 137);
            this.ServergroupBox.TabIndex = 0;
            this.ServergroupBox.TabStop = false;
            this.ServergroupBox.Text = "Server";
            this.ServergroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PORTtxtBox
            // 
            this.PORTtxtBox.Location = new System.Drawing.Point(160, 90);
            this.PORTtxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PORTtxtBox.Name = "PORTtxtBox";
            this.PORTtxtBox.Size = new System.Drawing.Size(220, 29);
            this.PORTtxtBox.TabIndex = 3;
            this.PORTtxtBox.TextChanged += new System.EventHandler(this.PORTtxtBox_TextChanged);
            // 
            // IPtxtBox
            // 
            this.IPtxtBox.Location = new System.Drawing.Point(160, 35);
            this.IPtxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IPtxtBox.Name = "IPtxtBox";
            this.IPtxtBox.Size = new System.Drawing.Size(220, 29);
            this.IPtxtBox.TabIndex = 1;
            this.IPtxtBox.TextChanged += new System.EventHandler(this.IPtxtBox_TextChanged);
            // 
            // PORTlabel2
            // 
            this.PORTlabel2.AutoSize = true;
            this.PORTlabel2.Location = new System.Drawing.Point(13, 96);
            this.PORTlabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PORTlabel2.Name = "PORTlabel2";
            this.PORTlabel2.Size = new System.Drawing.Size(67, 25);
            this.PORTlabel2.TabIndex = 2;
            this.PORTlabel2.Text = "PORT";
            this.PORTlabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IPlabel1
            // 
            this.IPlabel1.AutoSize = true;
            this.IPlabel1.Location = new System.Drawing.Point(13, 54);
            this.IPlabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IPlabel1.Name = "IPlabel1";
            this.IPlabel1.Size = new System.Drawing.Size(30, 25);
            this.IPlabel1.TabIndex = 0;
            this.IPlabel1.Text = "IP";
            // 
            // SENDbutton
            // 
            this.SENDbutton.Location = new System.Drawing.Point(59, 823);
            this.SENDbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SENDbutton.Name = "SENDbutton";
            this.SENDbutton.Size = new System.Drawing.Size(138, 42);
            this.SENDbutton.TabIndex = 4;
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
            this.KeyInfogroupBox4.Location = new System.Drawing.Point(40, 172);
            this.KeyInfogroupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KeyInfogroupBox4.Name = "KeyInfogroupBox4";
            this.KeyInfogroupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KeyInfogroupBox4.Size = new System.Drawing.Size(427, 133);
            this.KeyInfogroupBox4.TabIndex = 1;
            this.KeyInfogroupBox4.TabStop = false;
            this.KeyInfogroupBox4.Text = "KeyInfo";
            // 
            // MAC_KEYtxtBox5
            // 
            this.MAC_KEYtxtBox5.Location = new System.Drawing.Point(182, 89);
            this.MAC_KEYtxtBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MAC_KEYtxtBox5.Name = "MAC_KEYtxtBox5";
            this.MAC_KEYtxtBox5.Size = new System.Drawing.Size(162, 29);
            this.MAC_KEYtxtBox5.TabIndex = 3;
            this.MAC_KEYtxtBox5.TextChanged += new System.EventHandler(this.MAC_KEYtxtBox5_TextChanged);
            // 
            // PIN_KEYtxtBox6
            // 
            this.PIN_KEYtxtBox6.Location = new System.Drawing.Point(182, 33);
            this.PIN_KEYtxtBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PIN_KEYtxtBox6.Name = "PIN_KEYtxtBox6";
            this.PIN_KEYtxtBox6.Size = new System.Drawing.Size(162, 29);
            this.PIN_KEYtxtBox6.TabIndex = 1;
            this.PIN_KEYtxtBox6.TextChanged += new System.EventHandler(this.PIN_KEYtxtBox6_TextChanged);
            // 
            // MAC_KEYlabel3
            // 
            this.MAC_KEYlabel3.AutoSize = true;
            this.MAC_KEYlabel3.Location = new System.Drawing.Point(13, 94);
            this.MAC_KEYlabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MAC_KEYlabel3.Name = "MAC_KEYlabel3";
            this.MAC_KEYlabel3.Size = new System.Drawing.Size(144, 25);
            this.MAC_KEYlabel3.TabIndex = 2;
            this.MAC_KEYlabel3.Text = "MAC_KEY No.";
            // 
            // PIN_KEYlabel4
            // 
            this.PIN_KEYlabel4.AutoSize = true;
            this.PIN_KEYlabel4.Location = new System.Drawing.Point(13, 33);
            this.PIN_KEYlabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PIN_KEYlabel4.Name = "PIN_KEYlabel4";
            this.PIN_KEYlabel4.Size = new System.Drawing.Size(130, 25);
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
            this.POSinfogroupBox.Location = new System.Drawing.Point(40, 517);
            this.POSinfogroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.POSinfogroupBox.Name = "POSinfogroupBox";
            this.POSinfogroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.POSinfogroupBox.Size = new System.Drawing.Size(673, 295);
            this.POSinfogroupBox.TabIndex = 3;
            this.POSinfogroupBox.TabStop = false;
            this.POSinfogroupBox.Text = "POSInfo";
            this.POSinfogroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TRACK2txtBox
            // 
            this.TRACK2txtBox.Location = new System.Drawing.Point(182, 229);
            this.TRACK2txtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TRACK2txtBox.Name = "TRACK2txtBox";
            this.TRACK2txtBox.Size = new System.Drawing.Size(448, 29);
            this.TRACK2txtBox.TabIndex = 7;
            this.TRACK2txtBox.TextChanged += new System.EventHandler(this.TRACK2txtBox_TextChanged);
            // 
            // TRACK2label8
            // 
            this.TRACK2label8.AutoSize = true;
            this.TRACK2label8.Location = new System.Drawing.Point(13, 242);
            this.TRACK2label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TRACK2label8.Name = "TRACK2label8";
            this.TRACK2label8.Size = new System.Drawing.Size(97, 25);
            this.TRACK2label8.TabIndex = 6;
            this.TRACK2label8.Text = "TRACK 2";
            this.TRACK2label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PINtxtBox
            // 
            this.PINtxtBox.Location = new System.Drawing.Point(182, 170);
            this.PINtxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PINtxtBox.Name = "PINtxtBox";
            this.PINtxtBox.Size = new System.Drawing.Size(77, 29);
            this.PINtxtBox.TabIndex = 5;
            this.PINtxtBox.TextChanged += new System.EventHandler(this.PINtxtBox_TextChanged);
            // 
            // PINlabel7
            // 
            this.PINlabel7.AutoSize = true;
            this.PINlabel7.Location = new System.Drawing.Point(13, 183);
            this.PINlabel7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PINlabel7.Name = "PINlabel7";
            this.PINlabel7.Size = new System.Drawing.Size(44, 25);
            this.PINlabel7.TabIndex = 4;
            this.PINlabel7.Text = "PIN";
            this.PINlabel7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CARDNUMBERtxtBox
            // 
            this.CARDNUMBERtxtBox.Location = new System.Drawing.Point(182, 107);
            this.CARDNUMBERtxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CARDNUMBERtxtBox.Name = "CARDNUMBERtxtBox";
            this.CARDNUMBERtxtBox.Size = new System.Drawing.Size(242, 29);
            this.CARDNUMBERtxtBox.TabIndex = 3;
            this.CARDNUMBERtxtBox.TextChanged += new System.EventHandler(this.CARDNUMBERtxtBox_TextChanged);
            // 
            // AMOUNTtextBox
            // 
            this.AMOUNTtextBox.Location = new System.Drawing.Point(182, 35);
            this.AMOUNTtextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AMOUNTtextBox.Name = "AMOUNTtextBox";
            this.AMOUNTtextBox.Size = new System.Drawing.Size(242, 29);
            this.AMOUNTtextBox.TabIndex = 0;
            this.AMOUNTtextBox.TextChanged += new System.EventHandler(this.AMOUNTtextBox_TextChanged);
            // 
            // CARDNUMBERlabel5
            // 
            this.CARDNUMBERlabel5.AutoSize = true;
            this.CARDNUMBERlabel5.Location = new System.Drawing.Point(13, 113);
            this.CARDNUMBERlabel5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CARDNUMBERlabel5.Name = "CARDNUMBERlabel5";
            this.CARDNUMBERlabel5.Size = new System.Drawing.Size(157, 25);
            this.CARDNUMBERlabel5.TabIndex = 2;
            this.CARDNUMBERlabel5.Text = "CARD NUMBER";
            // 
            // AMOUNTlabel6
            // 
            this.AMOUNTlabel6.AutoSize = true;
            this.AMOUNTlabel6.Location = new System.Drawing.Point(13, 33);
            this.AMOUNTlabel6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AMOUNTlabel6.Name = "AMOUNTlabel6";
            this.AMOUNTlabel6.Size = new System.Drawing.Size(100, 25);
            this.AMOUNTlabel6.TabIndex = 0;
            this.AMOUNTlabel6.Text = "AMOUNT";
            this.AMOUNTlabel6.Click += new System.EventHandler(this.label6_Click);
            // 
            // RecivedtxtBox
            // 
            this.RecivedtxtBox.Location = new System.Drawing.Point(42, 44);
            this.RecivedtxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RecivedtxtBox.Multiline = true;
            this.RecivedtxtBox.Name = "RecivedtxtBox";
            this.RecivedtxtBox.Size = new System.Drawing.Size(754, 124);
            this.RecivedtxtBox.TabIndex = 0;
            this.RecivedtxtBox.TextChanged += new System.EventHandler(this.RecivedtxtBox_TextChanged);
            // 
            // RecivedBytesgroupBox
            // 
            this.RecivedBytesgroupBox.Controls.Add(this.RecivedtxtBox);
            this.RecivedBytesgroupBox.Location = new System.Drawing.Point(754, 321);
            this.RecivedBytesgroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RecivedBytesgroupBox.Name = "RecivedBytesgroupBox";
            this.RecivedBytesgroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RecivedBytesgroupBox.Size = new System.Drawing.Size(834, 223);
            this.RecivedBytesgroupBox.TabIndex = 6;
            this.RecivedBytesgroupBox.TabStop = false;
            this.RecivedBytesgroupBox.Text = "RecivedBytes";
            this.RecivedBytesgroupBox.Enter += new System.EventHandler(this.RecivedBytesgroupBox_Enter);
            // 
            // RecParsBytestxtBox
            // 
            this.RecParsBytestxtBox.Location = new System.Drawing.Point(42, 57);
            this.RecParsBytestxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RecParsBytestxtBox.Multiline = true;
            this.RecParsBytestxtBox.Name = "RecParsBytestxtBox";
            this.RecParsBytestxtBox.Size = new System.Drawing.Size(754, 124);
            this.RecParsBytestxtBox.TabIndex = 0;
            this.RecParsBytestxtBox.TextChanged += new System.EventHandler(this.RecParsBytestxtBox_TextChanged);
            // 
            // RecParsBytesgroupBox
            // 
            this.RecParsBytesgroupBox.Controls.Add(this.RecParsBytestxtBox);
            this.RecParsBytesgroupBox.Location = new System.Drawing.Point(754, 567);
            this.RecParsBytesgroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RecParsBytesgroupBox.Name = "RecParsBytesgroupBox";
            this.RecParsBytesgroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RecParsBytesgroupBox.Size = new System.Drawing.Size(834, 223);
            this.RecParsBytesgroupBox.TabIndex = 7;
            this.RecParsBytesgroupBox.TabStop = false;
            this.RecParsBytesgroupBox.Text = "RecParsBytes";
            this.RecParsBytesgroupBox.Enter += new System.EventHandler(this.RecParsBytesgroupBox_Enter);
            // 
            // SendBytesgroupBox
            // 
            this.SendBytesgroupBox.Controls.Add(this.SendBytestxtBox);
            this.SendBytesgroupBox.Location = new System.Drawing.Point(754, 57);
            this.SendBytesgroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SendBytesgroupBox.Name = "SendBytesgroupBox";
            this.SendBytesgroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SendBytesgroupBox.Size = new System.Drawing.Size(834, 185);
            this.SendBytesgroupBox.TabIndex = 5;
            this.SendBytesgroupBox.TabStop = false;
            this.SendBytesgroupBox.Text = "SendBytes";
            // 
            // SendBytestxtBox
            // 
            this.SendBytestxtBox.Location = new System.Drawing.Point(44, 35);
            this.SendBytestxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SendBytestxtBox.Multiline = true;
            this.SendBytestxtBox.Name = "SendBytestxtBox";
            this.SendBytestxtBox.Size = new System.Drawing.Size(752, 117);
            this.SendBytestxtBox.TabIndex = 0;
            this.SendBytestxtBox.TextChanged += new System.EventHandler(this.SendBytestxtBox_TextChanged);
            // 
            // TerminalInfogroupBox
            // 
            this.TerminalInfogroupBox.Controls.Add(this.MerchantIDtextBox);
            this.TerminalInfogroupBox.Controls.Add(this.TerminalIDtextBox);
            this.TerminalInfogroupBox.Controls.Add(this.MerchantIDlabel);
            this.TerminalInfogroupBox.Controls.Add(this.TerminalIDlabel);
            this.TerminalInfogroupBox.Location = new System.Drawing.Point(48, 321);
            this.TerminalInfogroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TerminalInfogroupBox.Name = "TerminalInfogroupBox";
            this.TerminalInfogroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TerminalInfogroupBox.Size = new System.Drawing.Size(666, 181);
            this.TerminalInfogroupBox.TabIndex = 2;
            this.TerminalInfogroupBox.TabStop = false;
            this.TerminalInfogroupBox.Text = "TerminalInfo";
            this.TerminalInfogroupBox.Enter += new System.EventHandler(this.groupBox1_Enter_2);
            // 
            // MerchantIDtextBox
            // 
            this.MerchantIDtextBox.Location = new System.Drawing.Point(262, 100);
            this.MerchantIDtextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MerchantIDtextBox.Name = "MerchantIDtextBox";
            this.MerchantIDtextBox.Size = new System.Drawing.Size(314, 29);
            this.MerchantIDtextBox.TabIndex = 3;
            this.MerchantIDtextBox.TextChanged += new System.EventHandler(this.MerchantIDtextBox_TextChanged);
            // 
            // TerminalIDtextBox
            // 
            this.TerminalIDtextBox.Location = new System.Drawing.Point(262, 37);
            this.TerminalIDtextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TerminalIDtextBox.Name = "TerminalIDtextBox";
            this.TerminalIDtextBox.Size = new System.Drawing.Size(314, 29);
            this.TerminalIDtextBox.TabIndex = 1;
            this.TerminalIDtextBox.TextChanged += new System.EventHandler(this.TerminalIDtextBox_TextChanged);
            // 
            // MerchantIDlabel
            // 
            this.MerchantIDlabel.AutoSize = true;
            this.MerchantIDlabel.Location = new System.Drawing.Point(40, 114);
            this.MerchantIDlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MerchantIDlabel.Name = "MerchantIDlabel";
            this.MerchantIDlabel.Size = new System.Drawing.Size(149, 25);
            this.MerchantIDlabel.TabIndex = 2;
            this.MerchantIDlabel.Text = "MERCHANT ID";
            // 
            // TerminalIDlabel
            // 
            this.TerminalIDlabel.AutoSize = true;
            this.TerminalIDlabel.Location = new System.Drawing.Point(37, 44);
            this.TerminalIDlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TerminalIDlabel.Name = "TerminalIDlabel";
            this.TerminalIDlabel.Size = new System.Drawing.Size(136, 25);
            this.TerminalIDlabel.TabIndex = 0;
            this.TerminalIDlabel.Text = "TERMINAL ID";
            this.TerminalIDlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // POSSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 925);
            this.Controls.Add(this.TerminalInfogroupBox);
            this.Controls.Add(this.SendBytesgroupBox);
            this.Controls.Add(this.RecParsBytesgroupBox);
            this.Controls.Add(this.RecivedBytesgroupBox);
            this.Controls.Add(this.POSinfogroupBox);
            this.Controls.Add(this.KeyInfogroupBox4);
            this.Controls.Add(this.SENDbutton);
            this.Controls.Add(this.ServergroupBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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

