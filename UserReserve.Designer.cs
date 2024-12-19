
namespace project2
{
    partial class UserReserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReserve));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.PictureBox();
            this.appClose = new System.Windows.Forms.Label();
            this.btnAdminOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uRoom = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uIns = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.accTrans = new System.Windows.Forms.Timer(this.components);
            this.sidebarTrans = new System.Windows.Forms.Timer(this.components);
            this.uReserveFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reserve = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bldgReserve = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.ComboBox();
            this.bookedBy = new System.Windows.Forms.TextBox();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.btnReserve = new System.Windows.Forms.Button();
            this.course = new System.Windows.Forms.TextBox();
            this.section = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.uReserveFlow.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.TabIndex = 38;
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(752, 33);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(45, 45);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 24;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.uRoom);
            this.panel2.Location = new System.Drawing.Point(3, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 35);
            this.panel2.TabIndex = 41;
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
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "user.png");
            this.imageList2.Images.SetKeyName(1, "school.png");
            this.imageList2.Images.SetKeyName(2, "reserve.png");
            this.imageList2.Images.SetKeyName(3, "profile.png");
            this.imageList2.Images.SetKeyName(4, "password.png");
            this.imageList2.Images.SetKeyName(5, "menu.png");
            this.imageList2.Images.SetKeyName(6, "logout.png");
            // 
            // sidebarTrans
            // 
            this.sidebarTrans.Interval = 10;
            this.sidebarTrans.Tick += new System.EventHandler(this.sidebarTrans_Tick);
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
            this.uReserveFlow.Size = new System.Drawing.Size(66, 369);
            this.uReserveFlow.TabIndex = 39;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 61;
            this.label8.Text = "RESERVATIONS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bldgReserve
            // 
            this.bldgReserve.BackColor = System.Drawing.Color.White;
            this.bldgReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bldgReserve.FormattingEnabled = true;
            this.bldgReserve.Items.AddRange(new object[] {
            "MAIN",
            "ANNEX"});
            this.bldgReserve.Location = new System.Drawing.Point(163, 139);
            this.bldgReserve.Name = "bldgReserve";
            this.bldgReserve.Size = new System.Drawing.Size(195, 28);
            this.bldgReserve.TabIndex = 62;
            this.bldgReserve.SelectedIndexChanged += new System.EventHandler(this.bldgReserve_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(62, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "BUILDING :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(41, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "ROOM NAME :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(46, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "BOOKED BY :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(403, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 40);
            this.label5.TabIndex = 66;
            this.label5.Text = "SUBJECT \r\nCODE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(71, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "COURSE :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(70, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "SECTION :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(429, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "DATE :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(378, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "START TIME :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(396, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 71;
            this.label11.Text = "END TIME :";
            // 
            // roomName
            // 
            this.roomName.BackColor = System.Drawing.Color.White;
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roomName.FormattingEnabled = true;
            this.roomName.Items.AddRange(new object[] {
            "MAIN",
            "ANNEX"});
            this.roomName.Location = new System.Drawing.Point(163, 188);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(195, 28);
            this.roomName.TabIndex = 73;
            this.roomName.TextChanged += new System.EventHandler(this.roomName_TextChanged);
            // 
            // bookedBy
            // 
            this.bookedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.bookedBy.Location = new System.Drawing.Point(163, 237);
            this.bookedBy.Name = "bookedBy";
            this.bookedBy.Size = new System.Drawing.Size(195, 28);
            this.bookedBy.TabIndex = 74;
            // 
            // datepicker
            // 
            this.datepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.datepicker.Location = new System.Drawing.Point(495, 188);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(195, 28);
            this.datepicker.TabIndex = 78;
            this.datepicker.Value = new System.DateTime(2024, 11, 23, 16, 15, 14, 0);
            // 
            // start
            // 
            this.start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start.Location = new System.Drawing.Point(495, 237);
            this.start.Name = "start";
            this.start.ShowUpDown = true;
            this.start.Size = new System.Drawing.Size(195, 28);
            this.start.TabIndex = 79;
            this.start.Value = new System.DateTime(2024, 11, 26, 0, 0, 0, 0);
            // 
            // end
            // 
            this.end.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end.Location = new System.Drawing.Point(495, 287);
            this.end.Name = "end";
            this.end.ShowUpDown = true;
            this.end.Size = new System.Drawing.Size(195, 28);
            this.end.TabIndex = 80;
            this.end.Value = new System.DateTime(2024, 11, 23, 16, 15, 14, 0);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(294, 397);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(160, 41);
            this.btnReserve.TabIndex = 82;
            this.btnReserve.Text = "RESERVE";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // course
            // 
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.course.Location = new System.Drawing.Point(163, 285);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(195, 28);
            this.course.TabIndex = 83;
            // 
            // section
            // 
            this.section.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.section.Location = new System.Drawing.Point(163, 332);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(195, 28);
            this.section.TabIndex = 84;
            // 
            // subject
            // 
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.subject.Location = new System.Drawing.Point(495, 137);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(195, 28);
            this.subject.TabIndex = 85;
            // 
            // UserReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.section);
            this.Controls.Add(this.course);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.bookedBy);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bldgReserve);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uReserveFlow);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserReserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserReserve";
            this.Load += new System.EventHandler(this.UserReserve_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.uReserveFlow.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appClose;
        private System.Windows.Forms.Button btnAdminOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Button uRoom;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button uIns;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Timer accTrans;
        private System.Windows.Forms.Timer sidebarTrans;
        private System.Windows.Forms.FlowLayoutPanel uReserveFlow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox bldgReserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox roomName;
        private System.Windows.Forms.TextBox bookedBy;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.TextBox section;
        private System.Windows.Forms.TextBox subject;
    }
}