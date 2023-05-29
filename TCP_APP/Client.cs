using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_APP
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        

        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(txt_ip.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            btn_send.Enabled = false;
            btn_connect.Enabled = true;
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            txt_log.Text += $"\n{e.IpPort} disconnecting";
            client.Disconnect();
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            txt_log.Text += $"\nData received from {e.IpPort}, {Encoding.UTF8.GetString(e.Data.Array)}";
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            txt_log.Text += $"\nServer {e.IpPort} connected";
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btn_connect.Enabled = false;
                btn_send.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show($"Nemohl jsem se připojit na server");
                throw;
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (client.IsConnected) {
                if (!string.IsNullOrEmpty(txt_msg.Text)) {
                    client.Send(txt_msg.Text);
                    txt_log.Text += $"\nData {txt_msg.Text}";
                    txt_msg.Text = string.Empty;
                }
            }
        }
    }
}
