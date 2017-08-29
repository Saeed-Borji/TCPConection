using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using NLog;


namespace WindowsFormsApptest1
{
    public partial class POSSimulatorForm : Form
    {
        LVString CreateLV = new LVString();
        TCPConnection1 SimpleConenction = new TCPConnection1();
        string msgRev="";
        //
        private static Logger logger = LogManager.GetCurrentClassLogger();


        //Logger logger = LogManager.GetLogger("POSSimulatorForm");

        public POSSimulatorForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void SENDbutton_Click(object sender, EventArgs e)
        {
            //create LVstring and sendBytebox display
            logger.Trace("Sample trace message");
            logger.Debug("Sample debug message");
            logger.Info("Sample informational message");
            logger.Warn("Sample warning message");
            logger.Error("Sample error message");
            logger.Fatal("Sample fatal error message");

            CreateLV.CreateLVString();
            this.Invoke(new EventHandler(DisplayText));
            //

            //TCP connection

            IPAddress addressIP;
            int port;
            try
            {
                addressIP = IPAddress.Parse(IPtxtBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("An invalid IP address was specified.");
                return;

            }

            try
            {
                port = int.Parse(PORTtxtBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Input string was not in a correct format");
                return;
            }


             msgRev=SimpleConenction.SimpleTCPconenction(addressIP, port, CreateLV.Wholestring);
           // DisplaymsgREV(msgRev);

            this.Invoke(new EventHandler(DisplaymsgREV));
           
             
        }

        private void IPtxtBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void PIN_KEYtxtBox6_TextChanged(object sender, EventArgs e)
        {
            CreateLV.PINKeyNo = PIN_KEYtxtBox6.Text;
           

        }

        private void PORTtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MAC_KEYtxtBox5_TextChanged(object sender, EventArgs e)
        {
            CreateLV.MACKeyNo = MAC_KEYtxtBox5.Text;

        }

        private void AMOUNTtextBox_TextChanged(object sender, EventArgs e)
        {
            CreateLV.Amount = AMOUNTtextBox.Text;

        }

        private void CARDNUMBERtxtBox_TextChanged(object sender, EventArgs e)
        {
            CreateLV.CardNumber = CARDNUMBERtxtBox.Text;

        }

        private void PINtxtBox_TextChanged(object sender, EventArgs e)
        {
            CreateLV.CardPIN = PINtxtBox.Text;
        }

        private void TRACK2txtBox_TextChanged(object sender, EventArgs e)
        {
            CreateLV.CardTrack2 = TRACK2txtBox.Text;
        }

        private void SendBytestextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecivedtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecParsBytestxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecParsBytesgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void RecivedBytesgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void POSSimulatorForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void SendBytestxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TerminalIDtextBox_TextChanged(object sender, EventArgs e)
        {
            CreateLV.TerminalID = TerminalIDtextBox.Text;
        }

        private void MerchantIDtextBox_TextChanged(object sender, EventArgs e)
        {
            CreateLV.MerchantID = MerchantIDtextBox.Text;
        }


        private void DisplayText(object sender, EventArgs e)
        {
            SendBytestxtBox.Clear();
            SendBytestxtBox.AppendText(CreateLV.Wholestring);
        }

        public void DisplaymsgREV(object sender, EventArgs e)
        {
            RecivedtxtBox.Clear();
            RecivedtxtBox.AppendText(msgRev);
        } 
    }
}
