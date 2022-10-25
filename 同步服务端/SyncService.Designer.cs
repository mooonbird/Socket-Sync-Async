namespace WinFormsApp2
{
    partial class SyncService
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
            this.tBPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBReceive = new System.Windows.Forms.TextBox();
            this.tBSend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bListen = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(133, 45);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(150, 30);
            this.tBPort.TabIndex = 0;
            this.tBPort.Text = "8888";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "接收";
            // 
            // tBReceive
            // 
            this.tBReceive.Location = new System.Drawing.Point(133, 91);
            this.tBReceive.Multiline = true;
            this.tBReceive.Name = "tBReceive";
            this.tBReceive.Size = new System.Drawing.Size(616, 125);
            this.tBReceive.TabIndex = 0;
            // 
            // tBSend
            // 
            this.tBSend.Location = new System.Drawing.Point(133, 245);
            this.tBSend.Multiline = true;
            this.tBSend.Name = "tBSend";
            this.tBSend.Size = new System.Drawing.Size(616, 125);
            this.tBSend.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "发送";
            // 
            // bListen
            // 
            this.bListen.Location = new System.Drawing.Point(480, 390);
            this.bListen.Name = "bListen";
            this.bListen.Size = new System.Drawing.Size(112, 34);
            this.bListen.TabIndex = 2;
            this.bListen.Text = "监听";
            this.bListen.UseVisualStyleBackColor = true;
            this.bListen.Click += new System.EventHandler(this.bListen_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(637, 390);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(112, 34);
            this.bSend.TabIndex = 2;
            this.bSend.Text = "发送";
            this.bSend.UseVisualStyleBackColor = true;
            // 
            // SyncService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bListen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBSend);
            this.Controls.Add(this.tBReceive);
            this.Controls.Add(this.tBPort);
            this.Name = "SyncService";
            this.Text = "同步服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBPort;
        private Label label1;
        private Label label2;
        private TextBox tBReceive;
        private TextBox tBSend;
        private Label label3;
        private Button bListen;
        private Button bSend;
    }
}