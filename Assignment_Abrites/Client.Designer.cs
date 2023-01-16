namespace Assignment_Abrites
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.Problem_Textbox = new System.Windows.Forms.TextBox();
            this.labelproblem = new System.Windows.Forms.Label();
            this.labelresult = new System.Windows.Forms.Label();
            this.Result_Textbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IPtxb = new System.Windows.Forms.TextBox();
            this.labelip = new System.Windows.Forms.Label();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Disconnectbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.BackColor = System.Drawing.Color.Yellow;
            this.Calculatebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calculatebtn.Location = new System.Drawing.Point(109, 261);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(198, 110);
            this.Calculatebtn.TabIndex = 0;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.UseVisualStyleBackColor = false;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click);
            // 
            // Problem_Textbox
            // 
            this.Problem_Textbox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Problem_Textbox.Location = new System.Drawing.Point(29, 165);
            this.Problem_Textbox.Name = "Problem_Textbox";
            this.Problem_Textbox.Size = new System.Drawing.Size(380, 31);
            this.Problem_Textbox.TabIndex = 1;
            this.Problem_Textbox.TextChanged += new System.EventHandler(this.Problem_Textbox_TextChanged);
            this.Problem_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Problem_Textbox_KeyPress);
            // 
            // labelproblem
            // 
            this.labelproblem.AutoSize = true;
            this.labelproblem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelproblem.Location = new System.Drawing.Point(29, 137);
            this.labelproblem.Name = "labelproblem";
            this.labelproblem.Size = new System.Drawing.Size(194, 25);
            this.labelproblem.TabIndex = 2;
            this.labelproblem.Text = "Mathematical Problem:";
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelresult.Location = new System.Drawing.Point(29, 406);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(63, 25);
            this.labelresult.TabIndex = 3;
            this.labelresult.Text = "Result:";
            // 
            // Result_Textbox
            // 
            this.Result_Textbox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result_Textbox.Location = new System.Drawing.Point(29, 434);
            this.Result_Textbox.Name = "Result_Textbox";
            this.Result_Textbox.ReadOnly = true;
            this.Result_Textbox.Size = new System.Drawing.Size(380, 31);
            this.Result_Textbox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(447, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 204);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(540, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Developed by";
            // 
            // IPtxb
            // 
            this.IPtxb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPtxb.Location = new System.Drawing.Point(29, 46);
            this.IPtxb.Name = "IPtxb";
            this.IPtxb.Size = new System.Drawing.Size(380, 31);
            this.IPtxb.TabIndex = 7;
            this.IPtxb.Text = "127.0.0.1:9000";
            // 
            // labelip
            // 
            this.labelip.AutoSize = true;
            this.labelip.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelip.Location = new System.Drawing.Point(29, 18);
            this.labelip.Name = "labelip";
            this.labelip.Size = new System.Drawing.Size(85, 25);
            this.labelip.TabIndex = 8;
            this.labelip.Text = "Server IP:";
            // 
            // Connectbtn
            // 
            this.Connectbtn.BackColor = System.Drawing.Color.Yellow;
            this.Connectbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Connectbtn.Location = new System.Drawing.Point(447, 12);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(317, 65);
            this.Connectbtn.TabIndex = 9;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = false;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Yellow;
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("Deletebtn.Image")));
            this.Deletebtn.Location = new System.Drawing.Point(348, 198);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(61, 60);
            this.Deletebtn.TabIndex = 10;
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Disconnectbtn
            // 
            this.Disconnectbtn.BackColor = System.Drawing.Color.Yellow;
            this.Disconnectbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Disconnectbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Disconnectbtn.Location = new System.Drawing.Point(447, 97);
            this.Disconnectbtn.Name = "Disconnectbtn";
            this.Disconnectbtn.Size = new System.Drawing.Size(317, 65);
            this.Disconnectbtn.TabIndex = 11;
            this.Disconnectbtn.Text = "Disconnect";
            this.Disconnectbtn.UseVisualStyleBackColor = false;
            this.Disconnectbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(818, 522);
            this.Controls.Add(this.Disconnectbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.labelip);
            this.Controls.Add(this.IPtxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Result_Textbox);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.labelproblem);
            this.Controls.Add(this.Problem_Textbox);
            this.Controls.Add(this.Calculatebtn);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Calculatebtn;
        private TextBox Problem_Textbox;
        private Label labelproblem;
        private Label labelresult;
        private TextBox Result_Textbox;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox IPtxb;
        private Label labelip;
        private Button Connectbtn;
        private Button Deletebtn;
        private Button Disconnectbtn;
    }
}