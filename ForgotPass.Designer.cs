
namespace project2
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.appClose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appBack = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.appClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(217, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 316);
            this.panel1.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSend.Location = new System.Drawing.Point(109, 197);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 31);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbEmail.Location = new System.Drawing.Point(58, 130);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(183, 30);
            this.tbEmail.TabIndex = 11;
            // 
            // appClose
            // 
            this.appClose.AutoSize = true;
            this.appClose.BackColor = System.Drawing.Color.Transparent;
            this.appClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.appClose.ForeColor = System.Drawing.Color.White;
            this.appClose.Location = new System.Drawing.Point(269, 0);
            this.appClose.Name = "appClose";
            this.appClose.Size = new System.Drawing.Size(23, 25);
            this.appClose.TabIndex = 10;
            this.appClose.Text = "x";
            this.appClose.Click += new System.EventHandler(this.appClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forgot Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(37, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please enter your \r\ne-mail address to\r\nreceive a verification\r\ncode.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appBack
            // 
            this.appBack.AutoSize = true;
            this.appBack.BackColor = System.Drawing.Color.Transparent;
            this.appBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.appBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appBack.Location = new System.Drawing.Point(0, 0);
            this.appBack.Name = "appBack";
            this.appBack.Size = new System.Drawing.Size(25, 25);
            this.appBack.TabIndex = 13;
            this.appBack.Text = "<";
            this.appBack.Click += new System.EventHandler(this.appBack_Click);
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 316);
            this.Controls.Add(this.appBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label appClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label appBack;
    }
}