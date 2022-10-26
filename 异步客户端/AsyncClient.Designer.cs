namespace 异步客户端
{
    partial class AsyncClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tBIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBReceive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBSend = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址";
            // 
            // tBIP
            // 
            this.tBIP.Location = new System.Drawing.Point(111, 34);
            this.tBIP.Name = "tBIP";
            this.tBIP.Size = new System.Drawing.Size(283, 30);
            this.tBIP.TabIndex = 1;
            this.tBIP.Text = "127.0.01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口";
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(469, 37);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(156, 30);
            this.tBPort.TabIndex = 1;
            this.tBPort.Text = "8080";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "接收";
            // 
            // tBReceive
            // 
            this.tBReceive.Location = new System.Drawing.Point(111, 77);
            this.tBReceive.Multiline = true;
            this.tBReceive.Name = "tBReceive";
            this.tBReceive.Size = new System.Drawing.Size(648, 147);
            this.tBReceive.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "发送";
            // 
            // tBSend
            // 
            this.tBSend.Location = new System.Drawing.Point(111, 238);
            this.tBSend.Multiline = true;
            this.tBSend.Name = "tBSend";
            this.tBSend.Size = new System.Drawing.Size(648, 147);
            this.tBSend.TabIndex = 1;
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(647, 391);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(112, 34);
            this.bSend.TabIndex = 2;
            this.bSend.Text = "发送";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(529, 391);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(112, 34);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "连接";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // AsyncClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tBPort);
            this.Controls.Add(this.tBSend);
            this.Controls.Add(this.tBReceive);
            this.Controls.Add(this.tBIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AsyncClient";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tBIP;
        private Label label2;
        private TextBox tBPort;
        private Label label3;
        private TextBox tBReceive;
        private Label label4;
        private TextBox tBSend;
        private Button bSend;
        private Button bConnect;
    }
}