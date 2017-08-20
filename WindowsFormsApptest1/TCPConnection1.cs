using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApptest1
{
    class TCPConnection1
    {

             IPAddress AddressIP;
             int Port;
             TcpClient client;

             public TCPConnection1() 
             {
                 client = new TcpClient();

             }

             public string SimpleTCPconenction(IPAddress FormAddressIP, int formPort,string MSGtoServer)
             {

                 AddressIP = FormAddressIP;
                 Port = formPort;
                 string returndata="";
                 try
                 {
      //               using (TcpClient client = new TcpClient())
      //               {
                     if (!client.Connected)
                     {
                         client.Connect(AddressIP, Port);
                     }

                         NetworkStream serverStream = client.GetStream();

                         ///
                         byte[] outStream = Encoding.ASCII.GetBytes(MSGtoServer);

                         serverStream.Write(outStream, 0, outStream.Length);

                         serverStream.Flush();

                         byte[] inStream = new byte[10025];

                         serverStream.Read(inStream, 0, (int)client.ReceiveBufferSize);

                         returndata = System.Text.Encoding.ASCII.GetString(inStream);

             //        }

                 }
                 catch (Exception ex)
                 {

                     System.Windows.Forms.MessageBox.Show(ex.ToString());
                 }
                

                return returndata;
                
             }
    }
}
