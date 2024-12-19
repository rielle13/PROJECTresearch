
namespace project2
{
    partial class AdminRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRoom));
            this.label10 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAdminRoom = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRoomType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.appClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.accTrans = new System.Windows.Forms.Timer(this.components);
            this.sidebarTrans = new System.Windows.Forms.Timer(this.components);
            this.uReserveFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.room = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.instructors = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reserve = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.comboBldg = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRoom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uReserveFlow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(149, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbID.Location = new System.Drawing.Point(181, 118);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(231, 26);
            this.tbID.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(450, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSearch.Location = new System.Drawing.Point(524, 111);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 26);
            this.tbSearch.TabIndex = 42;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(87, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "ROOM FORM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(852, 472);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 29);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(725, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 29);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(597, 472);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 29);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(472, 472);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 29);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAdminRoom
            // 
            this.dgvAdminRoom.AllowUserToAddRows = false;
            this.dgvAdminRoom.AllowUserToDeleteRows = false;
            this.dgvAdminRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminRoom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAdminRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminRoom.Location = new System.Drawing.Point(451, 140);
            this.dgvAdminRoom.Name = "dgvAdminRoom";
            this.dgvAdminRoom.ReadOnly = true;
            this.dgvAdminRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminRoom.Size = new System.Drawing.Size(512, 326);
            this.dgvAdminRoom.TabIndex = 37;
            this.dgvAdminRoom.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminRoom_CellEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(77, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Room Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(110, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Building";
            // 
            // roomName
            // 
            this.roomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roomName.Location = new System.Drawing.Point(181, 201);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(231, 26);
            this.roomName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(85, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Room Type";
            // 
            // comboRoomType
            // 
            this.comboRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboRoomType.FormattingEnabled = true;
            this.comboRoomType.Location = new System.Drawing.Point(181, 242);
            this.comboRoomType.Name = "comboRoomType";
            this.comboRoomType.Size = new System.Drawing.Size(231, 28);
            this.comboRoomType.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.appClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menu);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 75);
            this.panel2.TabIndex = 80;
            // 
            // appClose
            // 
            this.appClose.AutoSize = true;
            this.appClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.appClose.ForeColor = System.Drawing.Color.White;
            this.appClose.Location = new System.Drawing.Point(967, 1);
            this.appClose.Name = "appClose";
            this.appClose.Size = new System.Drawing.Size(28, 31);
            this.appClose.TabIndex = 25;
            this.appClose.Text = "x";
            this.appClose.Click += new System.EventHandler(this.appClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTOMATED ROOM APPOINTMENT AND INSTRUCTORS\' \r\nAVAILABILITY FOR BULACAN POLYTECHNI" +
    "C\r\nCOLLEGE - MAIN CAMPUS\r\n";
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(3, 3);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(47, 69);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 24;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(56, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 69);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // sidebarTrans
            // 
            this.sidebarTrans.Interval = 10;
            this.sidebarTrans.Tick += new System.EventHandler(this.sidebarTrans_Tick);
            // 
            // uReserveFlow
            // 
            this.uReserveFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.uReserveFlow.Controls.Add(this.panel1);
            this.uReserveFlow.Controls.Add(this.panel3);
            this.uReserveFlow.Controls.Add(this.panel4);
            this.uReserveFlow.Controls.Add(this.panel5);
            this.uReserveFlow.Dock = System.Windows.Forms.DockStyle.Left;
            this.uReserveFlow.Location = new System.Drawing.Point(0, 75);
            this.uReserveFlow.Name = "uReserveFlow";
            this.uReserveFlow.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.uReserveFlow.Size = new System.Drawing.Size(66, 455);
            this.uReserveFlow.TabIndex = 105;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.room);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 35);
            this.panel1.TabIndex = 41;
            // 
            // room
            // 
            this.room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.room.ForeColor = System.Drawing.Color.White;
            this.room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.room.ImageIndex = 0;
            this.room.ImageList = this.imageList1;
            this.room.Location = new System.Drawing.Point(-11, -11);
            this.room.Name = "room";
            this.room.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.room.Size = new System.Drawing.Size(201, 57);
            this.room.TabIndex = 40;
            this.room.Text = "            ROOM";
            this.room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.room.UseVisualStyleBackColor = false;
            this.room.Click += new System.EventHandler(this.room_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.instructors);
            this.panel3.Location = new System.Drawing.Point(3, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 35);
            this.panel3.TabIndex = 42;
            // 
            // instructors
            // 
            this.instructors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.instructors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.instructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.instructors.ForeColor = System.Drawing.Color.White;
            this.instructors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.instructors.ImageIndex = 1;
            this.instructors.ImageList = this.imageList1;
            this.instructors.Location = new System.Drawing.Point(-11, -11);
            this.instructors.Name = "instructors";
            this.instructors.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.instructors.Size = new System.Drawing.Size(201, 57);
            this.instructors.TabIndex = 40;
            this.instructors.Text = "            INSTRUCTOR";
            this.instructors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.instructors.UseVisualStyleBackColor = false;
            this.instructors.Click += new System.EventHandler(this.instructors_Click);
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
            // comboBldg
            // 
            this.comboBldg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBldg.FormattingEnabled = true;
            this.comboBldg.Location = new System.Drawing.Point(181, 158);
            this.comboBldg.Name = "comboBldg";
            this.comboBldg.Size = new System.Drawing.Size(231, 28);
            this.comboBldg.TabIndex = 106;
            // 
            // AdminRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 530);
            this.Controls.Add(this.comboBldg);
            this.Controls.Add(this.uReserveFlow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboRoomType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAdminRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRoom";
            this.Load += new System.EventHandler(this.AdminRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uReserveFlow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAdminRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRoomType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label appClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer accTrans;
        private System.Windows.Forms.Timer sidebarTrans;
        private System.Windows.Forms.FlowLayoutPanel uReserveFlow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button room;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button instructors;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.ComboBox comboBldg;
    }
}