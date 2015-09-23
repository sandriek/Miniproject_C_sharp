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
        Image groenstreepkrom3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep3.gif");
        Image groenrechtstreep3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep3r.gif");
        Image groenvliegerstreep3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerstreep2.gif");
        Image groenrechtstreep2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep2r.gif");
        Image groenstreepkrom2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep2.gif");
        Image groenvliegerstreep2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerstreep2.gif");
        Image groenstreepkrom1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep1.gif");
        Image groenrechtstreep1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep1r.gif");
        Image groenvliegerstreep1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerstreep1.gif");
        Image groenheelkrom3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel3r.gif");
        Image groenrechtheel3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel3.gif");
        Image groenvliegerheel3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerheel3.gif");
        Image groenheelkrom2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel2.gif");
        Image groenrechtheel2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel2r.gif");
        Image groenvliegerheel2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerheel2.gif");
        Image groenrechtheel1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel1r.gif");
        Image groenheelkrom1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel1.gif");
        Image groenvliegerheel1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerheel1.gif");
        Image groenleegkrom3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg3.gif");
        Image groenrechtleeg3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg3r.gif");
        Image groenvliegerleeg3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerleeg3.gif");
        Image groenrechtleeg2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg2r.gif");
        Image groenleegkrom2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg2.gif");
        Image groenvliegerleeg2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerleeg2.gif");
        Image groenleegkrom1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg1.gif");
        Image groenrechtleeg1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg1r.gif");
        Image groenvliegerleeg1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerleeg1.gif");

        Image roodstreepkrom3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep3.gif");
        Image roodrechtstreep3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep3r.gif");
        Image roodvliegerstreep3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerstreep2.gif");
        Image roodrechtstreep2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep2r.gif");
        Image roodstreepkrom2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep2.gif");
        Image roodvliegerstreep2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerstreep2.gif");
        Image roodstreepkrom1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep1.gif");
        Image roodrechtstreep1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep1r.gif");
        Image roodvliegerstreep1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerstreep1.gif");
        Image roodheelkrom3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel3r.gif");
        Image roodrechtheel3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel3.gif");
        Image roodvliegerheel3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerheel3.gif");
        Image roodheelkrom2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel2.gif");
        Image roodrechtheel2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel2r.gif");
        Image roodvliegerheel2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerheel2.gif");
        Image roodrechtheel1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel1r.gif");
        Image roodheelkrom1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel1.gif");
        Image roodvliegerheel1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerheel1.gif");
        Image roodleegkrom3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg3.gif");
        Image roodrechtleeg3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg3r.gif");
        Image roodvliegerleeg3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerleeg3.gif");
        Image roodrechtleeg2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg2r.gif");
        Image roodleegkrom2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg2.gif");
        Image roodvliegerleeg2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerleeg2.gif");
        Image roodleegkrom1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg1.gif");
        Image roodrechtleeg1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg1r.gif");
        Image roodvliegerleeg1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerleeg1.gif");

        Image paarsstreepkrom3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep3.gif");
        Image paarsrechtstreep3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep3r.gif");
        Image paarsvliegerstreep3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerstreep2.gif");
        Image paarsrechtstreep2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep2r.gif");
        Image paarsstreepkrom2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep2.gif");
        Image paarsvliegerstreep2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerstreep2.gif");
        Image paarsstreepkrom1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep1.gif");
        Image paarsrechtstreep1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep1r.gif");
        Image paarsvliegerstreep1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerstreep1.gif");
        Image paarsheelkrom3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel3r.gif");
        Image paarsrechtheel3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel3.gif");
        Image paarsvliegerheel3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerheel3.gif");
        Image paarsheelkrom2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel2.gif");
        Image paarsrechtheel2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel2r.gif");
        Image paarsvliegerheel2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerheel2.gif");
        Image paarsrechtheel1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel1r.gif");
        Image paarsheelkrom1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel1.gif");
        Image paarsvliegerheel1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerheel1.gif");
        Image paarsleegkrom3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg3.gif");
        Image paarsrechtleeg3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg3r.gif");
        Image paarsvliegerleeg3 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerleeg3.gif");
        Image paarsrechtleeg2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg2r.gif");
        Image paarsleegkrom2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg2.gif");
        Image paarsvliegerleeg2 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerleeg2.gif");
        Image paarsleegkrom1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg1.gif");
        Image paarsrechtleeg1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg1r.gif");
        Image paarsvliegerleeg1 = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerleeg1.gif");

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

            clientSocket.Connect(getIP(), 8888);
            ReadMessage(clientSocket);
            WriteMessage(clientSocket, "ready");
            
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
            //Button.image
            ///x1x1.Image = Resources
        }

        private void x2x1_Click(object sender, EventArgs e)
        {
            x2x1.Image = roodheelkrom1;
        }
       
    }
  }

