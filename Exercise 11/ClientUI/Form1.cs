using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Form1 : Form
    {
        private NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 5403);
                stream = client.GetStream();
            }
            catch (SocketException)
            {
                MessageBox.Show("Could not connect! Server may not be operational.", "Error");
                Environment.Exit(1);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13 && this.textBox1.Focused)
            {
                SendMessage();
            }
        }

        private void SendMessage()
        {
            string message = this.textBox1.Text;
            listBox1.Items.Add(message);
            byte[] byteMessage = Encoding.ASCII.GetBytes(message);
            stream.Write(byteMessage, 0, byteMessage.Count());
            this.textBox1.Text = "";
        }
    }
}
