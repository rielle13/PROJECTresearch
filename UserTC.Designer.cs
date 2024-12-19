
namespace project2
{
    partial class UserTC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTC));
            this.search = new System.Windows.Forms.Label();
            this.tbInsID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.PictureBox();
            this.appClose = new System.Windows.Forms.Label();
            this.btnAdminOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tblname = new System.Windows.Forms.TextBox();
            this.daytime = new System.Windows.Forms.Label();
            this.uReserveFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uRoom = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.uIns = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reserve = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.accTrans = new System.Windows.Forms.Timer(this.components);
            this.sidebarTrans = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTC = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uReserveFlow.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(226, 127);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(90, 20);
            this.search.TabIndex = 32;
            this.search.Text = "ID Number ";
            // 
            // tbInsID
            // 
            this.tbInsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInsID.Location = new System.Drawing.Point(322, 124);
            this.tbInsID.Name = "tbInsID";
            this.tbInsID.Size = new System.Drawing.Size(200, 26);
            this.tbInsID.TabIndex = 31;
            this.tbInsID.TextChanged += new System.EventHandler(this.tbInsID_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.appClose);
            this.panel1.Controls.Add(this.btnAdminOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 30;
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(752, 32);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(45, 45);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 41;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // appClose
            // 
            this.appClose.AutoSize = true;
            this.appClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.appClose.ForeColor = System.Drawing.Color.White;
            this.appClose.Location = new System.Drawing.Point(777, 0);
            this.appClose.Name = "appClose";
            this.appClose.Size = new System.Drawing.Size(23, 25);
            this.appClose.TabIndex = 23;
            this.appClose.Text = "x";
            this.appClose.Click += new System.EventHandler(this.appClose_Click);
            // 
            // btnAdminOut
            // 
            this.btnAdminOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdminOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdminOut.ForeColor = System.Drawing.Color.Black;
            this.btnAdminOut.Location = new System.Drawing.Point(51, 488);
            this.btnAdminOut.Name = "btnAdminOut";
            this.btnAdminOut.Size = new System.Drawing.Size(140, 37);
            this.btnAdminOut.TabIndex = 22;
            this.btnAdminOut.Text = "LOG OUT";
            this.btnAdminOut.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTOMATED ROOM APPOINTMENT AND INSTRUCTORS\' \r\nAVAILABILITY FOR BULACAN POLYTECHNI" +
    "C\r\nCOLLEGE - MAIN CAMPUS\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Firstname :";
            // 
            // tbfname
            // 
            this.tbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfname.Location = new System.Drawing.Point(146, 170);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(200, 26);
            this.tbfname.TabIndex = 34;
            this.tbfname.TextChanged += new System.EventHandler(this.tbfname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Lastname :";
            // 
            // tblname
            // 
            this.tblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblname.Location = new System.Drawing.Point(479, 170);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(200, 26);
            this.tblname.TabIndex = 36;
            this.tblname.TextChanged += new System.EventHandler(this.tblname_TextChanged);
            // 
            // daytime
            // 
            this.daytime.AutoSize = true;
            this.daytime.BackColor = System.Drawing.Color.Transparent;
            this.daytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daytime.Location = new System.Drawing.Point(45, 217);
            this.daytime.Name = "daytime";
            this.daytime.Size = new System.Drawing.Size(93, 20);
            this.daytime.TabIndex = 38;
            this.daytime.Text = "DAY/TIME :";
            // 
            // uReserveFlow
            // 
            this.uReserveFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.uReserveFlow.Controls.Add(this.panel2);
            this.uReserveFlow.Controls.Add(this.panel3);
            this.uReserveFlow.Controls.Add(this.panel4);
            this.uReserveFlow.Controls.Add(this.panel5);
            this.uReserveFlow.Dock = System.Windows.Forms.DockStyle.Right;
            this.uReserveFlow.Location = new System.Drawing.Point(734, 81);
            this.uReserveFlow.Name = "uReserveFlow";
            this.uReserveFlow.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.uReserveFlow.Size = new System.Drawing.Size(66, 478);
            this.uReserveFlow.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uRoom);
            this.panel2.Location = new System.Drawing.Point(3, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 35);
            this.panel2.TabIndex = 41;
            // 
            // uRoom
            // 
            this.uRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.uRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uRoom.ForeColor = System.Drawing.Color.White;
            this.uRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uRoom.ImageIndex = 0;
            this.uRoom.ImageList = this.imageList1;
            this.uRoom.Location = new System.Drawing.Point(-11, -11);
            this.uRoom.Name = "uRoom";
            this.uRoom.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.uRoom.Size = new System.Drawing.Size(201, 57);
            this.uRoom.TabIndex = 40;
            this.uRoom.Text = "            ROOM";
            this.uRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uRoom.UseVisualStyleBackColor = false;
            this.uRoom.Click += new System.EventHandler(this.uRoom_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "room.png");
            this.imageList1.Images.SetKeyName(1, "teacher.png");
            this.imageList1.Images.SetKeyName(2, "calendar.png");
            this.imageList1.Images.SetKeyName(3, "changepf.png");
            this.imageList1.Images.SetKeyName(4, "resetpass.png");
            this.imageList1.Images.SetKeyName(5, "logout.png");
            this.imageList1.Images.SetKeyName(6, "accSet.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uIns);
            this.panel3.Location = new System.Drawing.Point(3, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 35);
            this.panel3.TabIndex = 42;
            // 
            // uIns
            // 
            this.uIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.uIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uIns.ForeColor = System.Drawing.Color.White;
            this.uIns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uIns.ImageIndex = 1;
            this.uIns.ImageList = this.imageList1;
            this.uIns.Location = new System.Drawing.Point(-11, -11);
            this.uIns.Name = "uIns";
            this.uIns.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.uIns.Size = new System.Drawing.Size(201, 57);
            this.uIns.TabIndex = 40;
            this.uIns.Text = "            INSTRUCTOR";
            this.uIns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uIns.UseVisualStyleBackColor = false;
            this.uIns.Click += new System.EventHandler(this.uIns_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.reserve);
            this.panel4.Location = new System.Drawing.Point(3, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 35);
            this.panel4.TabIndex = 43;
            // 
            // reserve
            // 
            this.reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.reserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reserve.ForeColor = System.Drawing.Color.White;
            this.reserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reserve.ImageIndex = 2;
            this.reserve.ImageList = this.imageList1;
            this.reserve.Location = new System.Drawing.Point(-11, -11);
            this.reserve.Name = "reserve";
            this.reserve.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.reserve.Size = new System.Drawing.Size(201, 57);
            this.reserve.TabIndex = 40;
            this.reserve.Text = "            RESERVE";
            this.reserve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reserve.UseVisualStyleBackColor = false;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.logOut);
            this.panel5.Location = new System.Drawing.Point(3, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 35);
            this.panel5.TabIndex = 43;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.logOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut.ImageIndex = 5;
            this.logOut.ImageList = this.imageList1;
            this.logOut.Location = new System.Drawing.Point(-11, -11);
            this.logOut.Name = "logOut";
            this.logOut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.logOut.Size = new System.Drawing.Size(201, 57);
            this.logOut.TabIndex = 40;
            this.logOut.Text = "            LOG OUT";
            this.logOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // sidebarTrans
            // 
            this.sidebarTrans.Interval = 10;
            this.sidebarTrans.Tick += new System.EventHandler(this.sidebarTrans_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 25);
            this.label8.TabIndex = 62;
            this.label8.Text = "INSTRUCTORS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTC
            // 
            this.dgvTC.AllowUserToAddRows = false;
            this.dgvTC.AllowUserToDeleteRows = false;
            this.dgvTC.AllowUserToOrderColumns = true;
            this.dgvTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTC.Location = new System.Drawing.Point(69, 240);
            this.dgvTC.Name = "dgvTC";
            this.dgvTC.ReadOnly = true;
            this.dgvTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTC.Size = new System.Drawing.Size(600, 285);
            this.dgvTC.TabIndex = 65;
            // 
            // UserTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.dgvTC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uReserveFlow);
            this.Controls.Add(this.daytime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.search);
            this.Controls.Add(this.tbInsID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserTC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserTC";
            this.Load += new System.EventHandler(this.UserTC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uReserveFlow.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox tbInsID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appClose;
        private System.Windows.Forms.Button btnAdminOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.Label daytime;
        private System.Windows.Forms.FlowLayoutPanel uReserveFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button uRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button uIns;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer accTrans;
        private System.Windows.Forms.Timer sidebarTrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTC;
    }
}