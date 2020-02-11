using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCP_Server
{
    class Server
    {
        public static readonly IPAddress address = new IPAddress(new byte[] { 127, 0, 0, 1 });
        public TcpListener ServerListener { get; set; }      

        public Server(TcpListener listener)
        {
            ServerListener = listener;
        }

        public Server()
        {
            ServerListener = new TcpListener(address, 5403);
        }

        public void EstablishChatConnection()
        {
                while (true)
                {
                    Console.WriteLine("Waiting for a client");
                    ServerListener.Start();
                    TcpClient client = ServerListener.AcceptTcpClient();
                    Thread connectionHandler = new Thread(() => ChatHandler(client));
                    connectionHandler.Start();
                }
        }

        public void ChatHandler(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                while (client.Connected)
                {
                    byte[] bytes = new byte[client.SendBufferSize];
                    int recv = 0;
                    recv = stream.Read(bytes, 0, client.SendBufferSize);
                    string received = Encoding.ASCII.GetString(bytes, 0, recv);
                    Console.WriteLine(received);
                    byte[] response = Encoding.ASCII.GetBytes("Objects received");
                    stream.Write(response, 0, response.Length);
                }
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Client disconnected");
            }
        }

        static void Main(string[] args)
        {
            Server server = new Server();
            server.EstablishChatConnection();
        }

        public void ReceiveJsonFromJavaSocket()
        {
            byte[] adr = { 127, 0, 0, 1 };
            IPAddress ipAdr = new IPAddress(adr);
            TcpListener newSock = new TcpListener(ipAdr, 5403);
            newSock.Start();

            Console.WriteLine("Waiting for a client");

            TcpClient client = newSock.AcceptTcpClient();
            NetworkStream stream = client.GetStream();

            byte[] bytes = new byte[client.SendBufferSize];
            int recv = 0;

            recv = stream.Read(bytes, 0, client.SendBufferSize);
            string received = Encoding.ASCII.GetString(bytes, 0, recv);

            Console.WriteLine(received);

            byte[] response = Encoding.ASCII.GetBytes("Objects received");
            stream.Write(response, 0, response.Length);
            Console.ReadLine();
        }
    }
}