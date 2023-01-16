namespace TCP_Server
{
    partial class ServerSide
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
            this.ListBoxConnectionsClients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerIPtxtb = new System.Windows.Forms.TextBox();
            this.StartServerbtn = new System.Windows.Forms.Button();
            this.InfoListbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Stopserverbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxConnectionsClients
            // 
            this.ListBoxConnectionsClients.BackColor = System.Drawing.SystemColors.InfoText;
            this.ListBoxConnectionsClients.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ListBoxConnectionsClients.FormattingEnabled = true;
            this.ListBoxConnectionsClients.ItemHeight = 20;
            this.ListBoxConnectionsClients.Location = new System.Drawing.Point(26, 43);
            this.ListBoxConnectionsClients.Name = "ListBoxConnectionsClients";
            this.ListBoxConnectionsClients.Size = new System.Drawing.Size(333, 344);
            this.ListBoxConnectionsClients.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connections:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server IP:";
            // 
            // ServerIPtxtb
            // 
            this.ServerIPtxtb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServerIPtxtb.Location = new System.Drawing.Point(110, 404);
            this.ServerIPtxtb.Name = "ServerIPtxtb";
            this.ServerIPtxtb.Size = new System.Drawing.Size(249, 34);
            this.ServerIPtxtb.TabIndex = 3;
            this.ServerIPtxtb.Text = "127.0.0.1:9000";
            // 
            // StartServerbtn
            // 
            this.StartServerbtn.BackColor = System.Drawing.SystemColors.WindowText;
            this.StartServerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartServerbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartServerbtn.ForeColor = System.Drawing.Color.Yellow;
            this.StartServerbtn.Location = new System.Drawing.Point(455, 12);
            this.StartServerbtn.Name = "StartServerbtn";
            this.StartServerbtn.Size = new System.Drawing.Size(196, 94);
            this.StartServerbtn.TabIndex = 4;
            this.StartServerbtn.Text = "Start Server";
            this.StartServerbtn.UseVisualStyleBackColor = false;
            this.StartServerbtn.Click += new System.EventHandler(this.StartServerbtn_Click);
            // 
            // InfoListbox
            // 
            this.InfoListbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.InfoListbox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InfoListbox.FormattingEnabled = true;
            this.InfoListbox.ItemHeight = 20;
            this.InfoListbox.Location = new System.Drawing.Point(455, 146);
            this.InfoListbox.Name = "InfoListbox";
            this.InfoListbox.Size = new System.Drawing.Size(333, 284);
            this.InfoListbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(549, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server Info:";
            // 
            // Stopserverbtn
            // 
            this.Stopserverbtn.BackColor = System.Drawing.SystemColors.WindowText;
            this.Stopserverbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Stopserverbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Stopserverbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Stopserverbtn.Location = new System.Drawing.Point(699, 12);
            this.Stopserverbtn.Name = "Stopserverbtn";
            this.Stopserverbtn.Size = new System.Drawing.Size(89, 94);
            this.Stopserverbtn.TabIndex = 7;
            this.Stopserverbtn.Text = "Stop Server";
            this.Stopserverbtn.UseVisualStyleBackColor = false;
            this.Stopserverbtn.Click += new System.EventHandler(this.Stopserverbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stopserverbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoListbox);
            this.Controls.Add(this.StartServerbtn);
            this.Controls.Add(this.ServerIPtxtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxConnectionsClients);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListBoxConnectionsClients;
        private Label label1;
        private Label label2;
        private TextBox ServerIPtxtb;
        private Button StartServerbtn;
        private ListBox InfoListbox;
        private Label label3;
        private Button Stopserverbtn;
    }
}