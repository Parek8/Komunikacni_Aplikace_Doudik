namespace TCP_APP
{
    partial class Client
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_msg = new System.Windows.Forms.Label();
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
            this.btn_send.Location = new System.Drawing.Point(419, 395);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(504, 395);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
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
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label_Server);
            this.Name = "Client";
            this.Text = "TCP Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Server;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label_msg;
    }
}

