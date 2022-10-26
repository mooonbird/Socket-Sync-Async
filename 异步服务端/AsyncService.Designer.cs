namespace 异步服务端
{
    partial class AsyncService
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
            this.tBPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBReceive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBSend = new System.Windows.Forms.TextBox();
            this.bListen = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口";
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(120, 42);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(150, 30);
            this.tBPort.TabIndex = 1;
            this.tBPort.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "接收";
            // 
            // tBReceive
            // 
            this.tBReceive.Location = new System.Drawing.Point(120, 78);
            this.tBReceive.Multiline = true;
            this.tBReceive.Name = "tBReceive";
            this.tBReceive.Size = new System.Drawing.Size(633, 144);
            this.tBReceive.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "发送";
            // 
            // tBSend
            // 
            this.tBSend.Location = new System.Drawing.Point(120, 232);
            this.tBSend.Multiline = true;
            this.tBSend.Name = "tBSend";
            this.tBSend.Size = new System.Drawing.Size(633, 144);
            this.tBSend.TabIndex = 1;
            // 
            // bListen
            // 
            this.bListen.Location = new System.Drawing.Point(496, 382);
            this.bListen.Name = "bListen";
            this.bListen.Size = new System.Drawing.Size(112, 34);
            this.bListen.TabIndex = 2;
            this.bListen.Text = "监视";
            this.bListen.UseVisualStyleBackColor = true;
            this.bListen.Click += new System.EventHandler(this.bListen_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(641, 382);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(112, 34);
            this.bSend.TabIndex = 2;
            this.bSend.Text = "发送";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // AsyncService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bListen);
            this.Controls.Add(this.tBSend);
            this.Controls.Add(this.tBReceive);
            this.Controls.Add(this.tBPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AsyncService";
            this.Text = "异步服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tBPort;
        private Label label2;
        private TextBox tBReceive;
        private Label label3;
        private TextBox tBSend;
        private Button bListen;
        private Button bSend;
    }
}