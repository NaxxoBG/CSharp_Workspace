using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Client
{
    class Client
    {
        public string ClientName { get; set; }

        public Client(string name)
        {
            ClientName = name;
        }

        public void WriteToServer()
        {
            string message = "";
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 5403);
                NetworkStream stream = client.GetStream();

                while (client.Client != null && !message.Equals("quit"))
                {
                    Console.WriteLine("Enter a message to the server");
                    message = string.Concat(ClientName + ": " + Console.ReadLine());
                    byte[] byteMessage = Encoding.ASCII.GetBytes(message);
                    stream.Write(byteMessage, 0, byteMessage.Count());
                }
                client.Close();
            }
            catch (SocketException)
            {
                Console.WriteLine("Could not connect! Server may not be operational.");
            }
        }

        static void Main(string[] args)
        {
            Client client = new Client("Jim");
            client.WriteToServer();
        }
    }
}
