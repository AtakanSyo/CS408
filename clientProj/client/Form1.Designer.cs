namespace client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Sweet = new System.Windows.Forms.Button();
            this.textBox_Sweet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(134, 97);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(172, 31);
            this.textBox_ip.TabIndex = 2;
            this.textBox_ip.Text = "192.168.195.214";
            this.textBox_ip.TextChanged += new System.EventHandler(this.textBox_ip_TextChanged);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(134, 161);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(172, 31);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.Text = "1111";
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox_port_TextChanged);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(148, 293);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(139, 43);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(396, 86);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(454, 498);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            this.logs.TextChanged += new System.EventHandler(this.logs_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Username:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(134, 235);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(172, 31);
            this.textBox_Username.TabIndex = 12;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sweet:";
            // 
            // button_Sweet
            // 
            this.button_Sweet.Location = new System.Drawing.Point(711, 681);
            this.button_Sweet.Name = "button_Sweet";
            this.button_Sweet.Size = new System.Drawing.Size(139, 43);
            this.button_Sweet.TabIndex = 15;
            this.button_Sweet.Text = "Sweet";
            this.button_Sweet.UseVisualStyleBackColor = true;
            this.button_Sweet.Click += new System.EventHandler(this.button_Sweet_Click);
            // 
            // textBox_Sweet
            // 
            this.textBox_Sweet.Location = new System.Drawing.Point(134, 618);
            this.textBox_Sweet.Name = "textBox_Sweet";
            this.textBox_Sweet.Size = new System.Drawing.Size(716, 31);
            this.textBox_Sweet.TabIndex = 16;
            this.textBox_Sweet.TextChanged += new System.EventHandler(this.sweet_Button_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 756);
            this.Controls.Add(this.textBox_Sweet);
            this.Controls.Add(this.button_Sweet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Sweet;
        private System.Windows.Forms.TextBox textBox_Sweet;
    }
}

