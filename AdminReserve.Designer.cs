
namespace project2
{
    partial class AdminReserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReserve));
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.dgvReserve = new System.Windows.Forms.DataGridView();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.appClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pROJECT2DataSet = new project2.PROJECT2DataSet();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationsTableAdapter = new project2.PROJECT2DataSetTableAdapters.ReservationsTableAdapter();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).BeginInit();
            this.uReserveFlow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(128, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSearch.Location = new System.Drawing.Point(194, 127);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 26);
            this.tbSearch.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(83, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 25);
            this.label8.TabIndex = 60;
            this.label8.Text = "RESERVATIONS FORM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.Silver;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDecline.ForeColor = System.Drawing.Color.Black;
            this.btnDecline.Location = new System.Drawing.Point(538, 473);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(95, 29);
            this.btnDecline.TabIndex = 59;
            this.btnDecline.Text = "DECLINE";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Silver;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnApprove.ForeColor = System.Drawing.Color.Black;
            this.btnApprove.Location = new System.Drawing.Point(415, 473);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(95, 29);
            this.btnApprove.TabIndex = 58;
            this.btnApprove.Text = "APPROVE";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // dgvReserve
            // 
            this.dgvReserve.AllowUserToDeleteRows = false;
            this.dgvReserve.AllowUserToOrderColumns = true;
            this.dgvReserve.AutoGenerateColumns = false;
            this.dgvReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReserve.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.buildingDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.bookedByDataGridViewTextBoxColumn,
            this.subjectCodeDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvReserve.DataSource = this.reservationsBindingSource;
            this.dgvReserve.Location = new System.Drawing.Point(132, 159);
            this.dgvReserve.MultiSelect = false;
            this.dgvReserve.Name = "dgvReserve";
            this.dgvReserve.ReadOnly = true;
            this.dgvReserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReserve.Size = new System.Drawing.Size(809, 297);
            this.dgvReserve.TabIndex = 56;
            this.dgvReserve.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserve_CellEnter);
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
            this.uReserveFlow.TabIndex = 106;
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
            this.panel2.TabIndex = 105;
            // 
            // appClose
            // 
            this.appClose.AutoSize = true;
            this.appClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.appClose.ForeColor = System.Drawing.Color.White;
            this.appClose.Location = new System.Drawing.Point(972, 0);
            this.appClose.Name = "appClose";
            this.appClose.Size = new System.Drawing.Size(28, 31);
            this.appClose.TabIndex = 25;
            this.appClose.Text = "x";
            this.appClose.Click += new System.EventHandler(this.appClose_Click);
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
            // pROJECT2DataSet
            // 
            this.pROJECT2DataSet.DataSetName = "PROJECT2DataSet";
            this.pROJECT2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.pROJECT2DataSet;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "Reservation ID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "Reservation ID";
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildingDataGridViewTextBoxColumn
            // 
            this.buildingDataGridViewTextBoxColumn.DataPropertyName = "Building";
            this.buildingDataGridViewTextBoxColumn.HeaderText = "Building";
            this.buildingDataGridViewTextBoxColumn.Name = "buildingDataGridViewTextBoxColumn";
            this.buildingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "Room Name";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "Room Name";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            this.roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookedByDataGridViewTextBoxColumn
            // 
            this.bookedByDataGridViewTextBoxColumn.DataPropertyName = "Booked By";
            this.bookedByDataGridViewTextBoxColumn.HeaderText = "Booked By";
            this.bookedByDataGridViewTextBoxColumn.Name = "bookedByDataGridViewTextBoxColumn";
            this.bookedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectCodeDataGridViewTextBoxColumn
            // 
            this.subjectCodeDataGridViewTextBoxColumn.DataPropertyName = "Subject Code";
            this.subjectCodeDataGridViewTextBoxColumn.HeaderText = "Subject Code";
            this.subjectCodeDataGridViewTextBoxColumn.Name = "subjectCodeDataGridViewTextBoxColumn";
            this.subjectCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start Time";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "End Time";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdminReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 530);
            this.Controls.Add(this.uReserveFlow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvReserve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminReserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminReserve";
            this.Load += new System.EventHandler(this.AdminReserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).EndInit();
            this.uReserveFlow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.DataGridView dgvReserve;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label appClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PROJECT2DataSet pROJECT2DataSet;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private PROJECT2DataSetTableAdapters.ReservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }

}