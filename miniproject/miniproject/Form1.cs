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
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            clientSocket.Connect("145.48.231.46", 8888);
            WriteMessage(clientSocket, "derp");
00

            


            
        }
        private static void WriteMessage(TcpClient client, string message)
        {

            //make sure the other end decodes with the same format!
            byte[] bytes = Encoding.Unicode.GetBytes(message);

            client.GetStream().Write(bytes, 0, bytes.Length);
        }

    }
    }

