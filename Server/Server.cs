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
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;

        
        private void Server_Load(object sender, EventArgs e)
        {
            btn_send.Enabled = false;
            btn_start.Enabled = true;
            server = new SimpleTcpServer(txt_ip.Text);
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            txt_log.Text += $"\n{e.IpPort} : {Encoding.UTF8.GetString(e.Data.Array)}";
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            txt_log.Text += $"{e.IpPort} disconnected\n";
            listBox1.Items.Remove(e.IpPort);
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            txt_log.Text += $"\n{e.IpPort} connected";
            listBox1.Items.Add(e.IpPort);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            server.Start();
            txt_log.Text += $"\nServer is starting..";
            btn_start.Enabled = false;
            btn_send.Enabled = true;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (server.IsListening) {
                if (!string.IsNullOrEmpty(txt_ip.Text) && listBox1.SelectedItems != null) {
                    server.Send(listBox1.SelectedItem.ToString(), txt_msg.Text);
                    txt_log.Text += $"\nServer is sending msg - {txt_msg.Text}";
                    txt_msg.Text = string.Empty;
                }
            }
        }
    }
}
