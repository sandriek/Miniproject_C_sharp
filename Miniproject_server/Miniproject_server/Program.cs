﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Miniproject_server
{
    class Program
    {
        public static List<TcpClient> client = new List<TcpClient>();
        
        static void Main(string[] args)
        {

            
              TcpListener serverSocket = new System.Net.Sockets.TcpListener(8888);
            TcpClient clientSocket1 = default(TcpClient);
            TcpClient clientSocket2 = default(TcpClient);
            serverSocket.Start();
                    Console.WriteLine(" >> Server Started");
                    clientSocket1 = serverSocket.AcceptTcpClient();
                    Console.WriteLine(" >> Accept connection from player 1");
                    Console.WriteLine(" >> Server Started");
                    clientSocket2 = serverSocket.AcceptTcpClient();
                    Console.WriteLine(" >> Accept connection from player 2");
            server_thread client = new server_thread();
            client.startClient(clientSocket1, clientSocket2);





            Console.WriteLine(" >> exit");
            Console.ReadLine();
        }
        public class server_thread
        {
            game a = new game();
            game b = new game();
            TcpClient clientSocket3 = null;
            TcpClient clientSocket4 = null;    
                public void startClient(TcpClient inClientSocket3, TcpClient inClientSocket4)
                {
                    this.clientSocket3 = inClientSocket3;
                    this.clientSocket4 = inClientSocket4;
                System.Threading.Thread ctThread = new System.Threading.Thread(doChat);
                ctThread.Start();
                System.Threading.Thread ctThread1 = new System.Threading.Thread(doChat1);
                ctThread1.Start();
            }
            private void doChat()
            {
                WriteMessage(clientSocket3, "voorbeeld");
                while (true)
                {

                       

                    try {
                        string player1 = ReadMessage(clientSocket3);
                        if ( player1 == "ready")
                        { Console.WriteLine("Ready");
                           List<string> list1 = a.CreateBoard();
                            foreach (string s in list1)
                            {
                                WriteMessage(clientSocket3, s );
                            }
                        }
                        else
                        {
                            string set1 = ReadMessage(clientSocket3);
                             string set2 = ReadMessage(clientSocket3);
                              string set3 = ReadMessage(clientSocket3);
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            private void doChat1()
            {
                WriteMessage(clientSocket4, "voorbeeld");
                while (true)
                {



                    try
                    {
                        string player2 = ReadMessage(clientSocket4);
                        if (player2 == "ready")
                        {
                            Console.WriteLine("Ready");
                            List<string> list2 = b.CreateBoard();
                            foreach (string s in list2)
                            {
                                WriteMessage(clientSocket4, s);
                            }
                        }
                        else
                        {
                              string set1 = ReadMessage(clientSocket4);
                               string set2  = ReadMessage(clientSocket4);
                                 string set3  = ReadMessage(clientSocket4);

                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
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
            private static void WriteMessage(TcpClient client, string message)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(message);
                client.GetStream().Write(bytes, 0, bytes.Length);
            }
            
        }
    }
}

