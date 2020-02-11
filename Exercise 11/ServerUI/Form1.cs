using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ServerUI
{
    public partial class Form1 : Form
    {
        public static readonly IPAddress address = new IPAddress(new byte[] { 127, 0, 0, 1 });
        private TcpListener listener;

        public Form1()
        {
            //CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            listener = new TcpListener(address, 5403);

            Thread th = new Thread(() =>
            {
                while (true)
                {
                    this.listBox1.Items.Add("Waiting for a client");
                    listener.Start();
                    TcpClient client = listener.AcceptTcpClient();
                    Thread connectionHandler = new Thread(() => ChatHandler(client))
                    {
                        IsBackground = true
                    };
                    connectionHandler.Start();
                }
            });
            th.Start();
            th.IsBackground = true;
            listener.Stop();
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
                    listBox1.Items.Add(received);
                    byte[] response = Encoding.ASCII.GetBytes("Objects received");
                    stream.Write(response, 0, response.Length);
                }
            }
            catch (System.IO.IOException)
            {
                this.listBox1.Items.Add("Client disconnected");
                client.Close();
            }
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (string.Equals((sender as Button).Name, @"CloseButton"))
        //    {
        //        if (listener != null)
        //        {
        //            listener.Stop();
        //            Environment.Exit(0);
        //        }
        //    }
        //}
    }
}
