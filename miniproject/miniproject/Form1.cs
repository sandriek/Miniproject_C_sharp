﻿using System;
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
        Image gs3s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep3.gif");
        Image gs3o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep3r.gif");
        Image gs3d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerstreep3.gif");
        Image gs2o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep2r.gif");
        Image gs2s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep2.gif");
        Image gs2d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerstreep2.gif");
        Image gs1s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep1.gif");
        Image gs1o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenstreep1r.gif");
        Image gs1d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerstreep1.gif");
        Image gf3s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel3r.gif");
        Image gf3o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel3.gif");
        Image gf3d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerheel3.gif");
        Image gf2s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel2.gif");
        Image gf2o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel2r.gif");
        Image gf2d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerheel2.gif");
        Image gf1o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel1r.gif");
        Image gf1s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenheel1.gif");
        Image gf1d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerheel1.gif");
        Image ge3s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg3.gif");
        Image ge3o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg3r.gif");
        Image ge3d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerleeg3.gif");
        Image ge2o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg2r.gif");
        Image ge2s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg2.gif");
        Image ge2d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerleeg2.gif");
        Image ge1s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg1.gif");
        Image ge1o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenleeg1r.gif");
        Image ge1d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Groenvliegerleeg1.gif");

        Image rs3s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep3.gif");
        Image rs3o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep3r.gif");
        Image rs3d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerstreep3.gif");
        Image rs2o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep2r.gif");
        Image rs2s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep2.gif");
        Image rs2d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerstreep2.gif");
        Image rs1s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep1.gif");
        Image rs1o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodstreep1r.gif");
        Image rs1d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerstreep1.gif");
        Image rf3o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel3r.gif");
        Image rf3s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel3.gif");
        Image rf3d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerheel3.gif");
        Image rf2s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel2.gif");
        Image rf2o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel2r.gif");
        Image rf2d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerheel2.gif");
        Image rf1o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel1r.gif");
        Image rf1s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodheel1.gif");
        Image rf1d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerheel1.gif");
        Image re3s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg3.gif");
        Image re3o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg3r.gif");
        Image re3d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerleeg3.gif");
        Image re2o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg2r.gif");
        Image re2s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg2.gif");
        Image re2d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerleeg2.gif");
        Image re1s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg1.gif");
        Image re1o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodleeg1r.gif");
        Image re1d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Roodvliegerleeg1.gif");

        Image ps3s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep3.gif");
        Image ps3o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep3r.gif");
        Image ps3d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerstreep3.gif");
        Image ps2o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep2r.gif");
        Image ps2s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep2.gif");
        Image ps2d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerstreep2.gif");
        Image ps1s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep1.gif");
        Image ps1o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsstreep1r.gif");
        Image ps1d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerstreep1.gif");
        Image pf3o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel3r.gif");
        Image pf3s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel3.gif");
        Image pf3d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerheel3.gif");
        Image pf2s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel2.gif");
        Image pf2o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel2r.gif");
        Image pf2d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerheel2.gif");
        Image pf1o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel1r.gif");
        Image pf1s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsheel1.gif");
        Image pf1d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerheel1.gif");
        Image pe3s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg3.gif");
        Image pe3o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg3r.gif");
        Image pe3d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerleeg3.gif");
        Image pe2o = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg2r.gif");
        Image pe2s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg2.gif");
        Image pe2d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerleeg2.gif");
        Image pe1s = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg1.gif");
        Image pe1o= Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsleeg1r.gif");
        Image pe1d = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\Paarsvliegerleeg1.gif");
        string[] tiles = new string[12];

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        string[] plaatjes = new string[12];
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
            for(int i = 0; i < tiles.Length; i++)
            {
                tiles[i] = ReadMessage(clientSocket);
            }
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

        public void moetvervangenworden()
        {
            //foreach () ;
        }

        public void plaatjesSchrijven()
        {
            foreach(String plaatje in tiles)
            {
                x1x1.Image = Image.FromFile("C:\\Users\\martijn\\Documents\\GitHub\\Miniproject_C_sharp\\miniproject\\Pictures\\C#\\"+plaatje+".gif");
            }
        }



        private void x1x1_Click(object sender, EventArgs e)
        {
            //Button.image
            ///x1x1.Image = Resources
        }

        private void x2x1_Click(object sender, EventArgs e)
        {
            x2x1.Image = ge1s;
        }
       
    }
  }

