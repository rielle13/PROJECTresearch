
namespace project2
{
    partial class UserRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.PictureBox();
            this.appClose = new System.Windows.Forms.Label();
            this.btnAdminOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBldg = new System.Windows.Forms.ComboBox();
            this.comboRm = new System.Windows.Forms.ComboBox();
            this.bldg = new System.Windows.Forms.Label();
            this.rm = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.daytime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.accTrans = new System.Windows.Forms.Timer(this.components);
            this.sidebarTrans = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.uReserveFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uRoom = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uIns = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uReserve = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uReserveFlow.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(752, 33);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(45, 45);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 31;
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
            // comboBldg
            // 
            this.comboBldg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBldg.FormattingEnabled = true;
            this.comboBldg.Items.AddRange(new object[] {
            "MAIN",
            "ANNEX"});
            this.comboBldg.Location = new System.Drawing.Point(143, 165);
            this.comboBldg.Name = "comboBldg";
            this.comboBldg.Size = new System.Drawing.Size(200, 28);
            this.comboBldg.TabIndex = 22;
            this.comboBldg.SelectedIndexChanged += new System.EventHandler(this.comboBldg_SelectedIndexChanged);
            // 
            // comboRm
            // 
            this.comboRm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRm.FormattingEnabled = true;
            this.comboRm.Items.AddRange(new object[] {
            "Rm. 101",
            "Rm. 102",
            "Rm. 103",
            "Rm. 104",
            "COMLAB 1",
            "COMLAB 2",
            "COMLAB 3",
            "COMLAB 4"});
            this.comboRm.Location = new System.Drawing.Point(488, 165);
            this.comboRm.Name = "comboRm";
            this.comboRm.Size = new System.Drawing.Size(200, 28);
            this.comboRm.TabIndex = 23;
            this.comboRm.SelectedIndexChanged += new System.EventHandler(this.comboRm_SelectedIndexChanged);
            this.comboRm.TextChanged += new System.EventHandler(this.comboRm_TextChanged);
            // 
            // bldg
            // 
            this.bldg.AutoSize = true;
            this.bldg.BackColor = System.Drawing.Color.Transparent;
            this.bldg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bldg.Location = new System.Drawing.Point(42, 168);
            this.bldg.Name = "bldg";
            this.bldg.Size = new System.Drawing.Size(95, 20);
            this.bldg.TabIndex = 24;
            this.bldg.Text = "BUILDING :";
            // 
            // rm
            // 
            this.rm.AutoSize = true;
            this.rm.BackColor = System.Drawing.Color.Transparent;
            this.rm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rm.Location = new System.Drawing.Point(416, 168);
            this.rm.Name = "rm";
            this.rm.Size = new System.Drawing.Size(66, 20);
            this.rm.TabIndex = 25;
            this.rm.Text = "ROOM :";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(301, 117);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 26);
            this.tbSearch.TabIndex = 26;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(231, 120);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(64, 20);
            this.search.TabIndex = 27;
            this.search.Text = "Search ";
            // 
            // daytime
            // 
            this.daytime.AutoSize = true;
            this.daytime.BackColor = System.Drawing.Color.Transparent;
            this.daytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daytime.Location = new System.Drawing.Point(42, 217);
            this.daytime.Name = "daytime";
            this.daytime.Size = new System.Drawing.Size(93, 20);
            this.daytime.TabIndex = 28;
            this.daytime.Text = "DAY/TIME :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sidebarTrans
            // 
            this.sidebarTrans.Interval = 10;
            this.sidebarTrans.Tick += new System.EventHandler(this.sidebarTrans_Tick);
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
            this.uReserveFlow.Size = new System.Drawing.Size(66, 470);
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
            this.panel4.Controls.Add(this.uReserve);
            this.panel4.Location = new System.Drawing.Point(3, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 35);
            this.panel4.TabIndex = 43;
            // 
            // uReserve
            // 
            this.uReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.uReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uReserve.ForeColor = System.Drawing.Color.White;
            this.uReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uReserve.ImageIndex = 2;
            this.uReserve.ImageList = this.imageList1;
            this.uReserve.Location = new System.Drawing.Point(-11, -11);
            this.uReserve.Name = "uReserve";
            this.uReserve.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.uReserve.Size = new System.Drawing.Size(201, 57);
            this.uReserve.TabIndex = 40;
            this.uReserve.Text = "            RESERVE";
            this.uReserve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uReserve.UseVisualStyleBackColor = false;
            this.uReserve.Click += new System.EventHandler(this.uReserve_Click_1);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 63;
            this.label8.Text = "ROOMS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToOrderColumns = true;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(69, 240);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(600, 285);
            this.dgvRooms.TabIndex = 64;
            // 
            // UserRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uReserveFlow);
            this.Controls.Add(this.daytime);
            this.Controls.Add(this.search);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.rm);
            this.Controls.Add(this.bldg);
            this.Controls.Add(this.comboRm);
            this.Controls.Add(this.comboBldg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRoom";
            this.Load += new System.EventHandler(this.UserRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uReserveFlow.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label appClose;
        private System.Windows.Forms.ComboBox comboBldg;
        private System.Windows.Forms.ComboBox comboRm;
        private System.Windows.Forms.Label bldg;
        private System.Windows.Forms.Label rm;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label daytime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer accTrans;
        private System.Windows.Forms.Timer sidebarTrans;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.FlowLayoutPanel uReserveFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button uRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button uIns;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button uReserve;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvRooms;
    }
}