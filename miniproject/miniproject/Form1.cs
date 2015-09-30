using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace miniproject
{

    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        public String s;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadMessage(clientSocket);
            WriteMessage(clientSocket, "ready");
            int x = 1;
            while (x < 12)
            {
                ReadMessage(clientSocket);
                x++;
            }
            button1.Enabled = false;
        }


        private static void WriteMessage(TcpClient client, string message)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            client.GetStream().Write(bytes, 0, bytes.Length);
        }
        public static String getIP()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
        private string ReadMessage(TcpClient client)
        {
            byte[] buffer = new byte[256];
            int totalRead = 0;


            do
            {

                int read = client.GetStream().Read
                    (buffer, totalRead, buffer.Length - totalRead);

                totalRead += read;
            } while (client.GetStream().DataAvailable);

            return Encoding.Unicode.GetString(buffer, 0, totalRead);
        }

        private void x1x1_Click(object sender, EventArgs e)
        {

        }

        private void x1x2_Click(object sender, EventArgs e)
        {

        }

        private void x1x3_Click(object sender, EventArgs e)
        {

        }

        private void x2x1_Click(object sender, EventArgs e)
        {

        }

        private void x2x2_Click(object sender, EventArgs e)
        {

        }
        private void x2x3_Click(object sender, EventArgs e)
        {

        }
        private void x3x1_Click(object sender, EventArgs e)
        {

        }
        private void x3x2_Click(object sender, EventArgs e)
        {

        }
        private void x3x3_Click(object sender, EventArgs e)
        {

        }
        private void x4x1_Click(object sender, EventArgs e)
        {

        }
        private void x4x2_Click(object sender, EventArgs e)
        {

        }
        private void x4x3_Click(object sender, EventArgs e)
        {

        }
    }

    }


