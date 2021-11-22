using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {

        bool terminating = false;
        bool connected = false;
        Socket clientSocket;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }


        private void button_connect_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string IP = textBox_ip.Text;

            int portNum;

            if (Int32.TryParse(textBox_port.Text, out portNum))
            {
                try
                {
                    clientSocket.Connect(IP, portNum);
                    button_connect.Enabled = false;

                    connected = true;
                    // Send username as message
                    string username = textBox_Username.Text;

                    Byte[] buffer = Encoding.Default.GetBytes(username);
                    
                    clientSocket.Send(buffer);

                    Thread recieveThread = new Thread(Receive); // Reciever of data from the server. 
                    recieveThread.Start(); // Don't forget to start the thread.

                }
                catch
                {
                    logs.AppendText("Could not connect to the server!\n");
                }
            }
            else
            {
                logs.AppendText("Check the port\n");
            }
        }

        private void Receive()
        {
            while (connected) // clientProj
            {
                try
                {
                    Byte[] buffer1 = new Byte[256];
                    clientSocket.Receive(buffer1);
                    string incomingMessage = Encoding.Default.GetString(buffer1);
                    System.Console.WriteLine(incomingMessage);
                    incomingMessage = incomingMessage.Trim('\0');
                    System.Console.WriteLine(incomingMessage);
                    if (incomingMessage != "")
                    {
                        logs.AppendText("Server: " + incomingMessage + "\n");
                    }
                }
                catch
                {

                    if (!terminating)
                    {
                        logs.AppendText("The server has disconnected\n");
                        button_connect.Enabled = true;

                    }

                    clientSocket.Close();
                    connected = false;
                }

            }
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }

        private void button_send_Click(object sender, EventArgs e)
        {


        }

        private void logs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sweet_Button_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Sweet_Click(object sender, EventArgs e)
        {
            string sweet = textBox_Sweet.Text;
            if (sweet != "" && sweet.Length <= 64)
            {
                Byte[] buffer = Encoding.Default.GetBytes(sweet);
                clientSocket.Send(buffer);
                textBox_Sweet.Text = "";
            }
        }

        private void textBox_ip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
