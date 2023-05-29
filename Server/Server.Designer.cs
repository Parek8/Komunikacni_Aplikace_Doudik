namespace TCP_APP
{
    partial class Server
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Server = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label_msg = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Server
            // 
            this.label_Server.AutoSize = true;
            this.label_Server.Location = new System.Drawing.Point(62, 47);
            this.label_Server.Name = "label_Server";
            this.label_Server.Size = new System.Drawing.Size(50, 16);
            this.label_Server.TabIndex = 0;
            this.label_Server.Text = "Server:";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(118, 44);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(461, 22);
            this.txt_ip.TabIndex = 1;
            this.txt_ip.Text = "127.0.0.1:9000";
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(118, 83);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_log.Size = new System.Drawing.Size(461, 237);
            this.txt_log.TabIndex = 2;
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(118, 335);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(461, 22);
            this.txt_msg.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(407, 383);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(87, 35);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(504, 383);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(89, 35);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label_msg
            // 
            this.label_msg.AutoSize = true;
            this.label_msg.Location = new System.Drawing.Point(45, 338);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(67, 16);
            this.label_msg.TabIndex = 6;
            this.label_msg.Text = "Message:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(615, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 292);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Client\'s IP address";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label_Server);
            this.Name = "Server";
            this.Text = "TCP server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Server;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label_msg;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

