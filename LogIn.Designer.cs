
namespace project2
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.user = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbShowpass = new System.Windows.Forms.CheckBox();
            this.pass = new System.Windows.Forms.Label();
            this.linkForgotpass = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.appClose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLog = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.user.Location = new System.Drawing.Point(311, 95);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(85, 17);
            this.user.TabIndex = 1;
            this.user.Text = " Username :";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(314, 115);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(220, 26);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(314, 194);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(220, 26);
            this.tbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(366, 276);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbShowpass
            // 
            this.cbShowpass.AutoSize = true;
            this.cbShowpass.Location = new System.Drawing.Point(432, 227);
            this.cbShowpass.Name = "cbShowpass";
            this.cbShowpass.Size = new System.Drawing.Size(102, 17);
            this.cbShowpass.TabIndex = 5;
            this.cbShowpass.Text = "Show Password";
            this.cbShowpass.UseVisualStyleBackColor = true;
            this.cbShowpass.CheckedChanged += new System.EventHandler(this.cbShowpass_CheckedChanged);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pass.Location = new System.Drawing.Point(311, 173);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(77, 17);
            this.pass.TabIndex = 6;
            this.pass.Text = "Password :";
            // 
            // linkForgotpass
            // 
            this.linkForgotpass.AutoSize = true;
            this.linkForgotpass.LinkColor = System.Drawing.Color.Teal;
            this.linkForgotpass.Location = new System.Drawing.Point(378, 331);
            this.linkForgotpass.Name = "linkForgotpass";
            this.linkForgotpass.Size = new System.Drawing.Size(91, 13);
            this.linkForgotpass.TabIndex = 7;
            this.linkForgotpass.TabStop = true;
            this.linkForgotpass.Text = "Forgot password?";
            this.linkForgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotpass_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "LOG IN TO YOUR ACCOUNT";
            // 
            // appClose
            // 
            this.appClose.AutoSize = true;
            this.appClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.appClose.Location = new System.Drawing.Point(575, 0);
            this.appClose.Name = "appClose";
            this.appClose.Size = new System.Drawing.Size(23, 25);
            this.appClose.TabIndex = 9;
            this.appClose.Text = "x";
            this.appClose.Click += new System.EventHandler(this.appClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(78, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 120);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTOMATED ROOM \r\nAPPOINTMENT AND \r\nINSTRUCTORS\' \r\nAVAILABILITY FOR \r\nBULACAN POLY" +
    "TECHNIC\r\nCOLLEGE - MAIN CAMPUS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLog.Controls.Add(this.label1);
            this.panelLog.Controls.Add(this.pictureBox1);
            this.panelLog.Location = new System.Drawing.Point(0, 0);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(253, 353);
            this.panelLog.TabIndex = 0;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 353);
            this.Controls.Add(this.appClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkForgotpass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.cbShowpass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.user);
            this.Controls.Add(this.panelLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbShowpass;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.LinkLabel linkForgotpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label appClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLog;
    }
}

