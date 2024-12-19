using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class UserTC : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adt;
        DataTable dt;
        private int userId;

        public UserTC(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PROJECT2.accdb;");
        }

        string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\project2\project2\bin\Debug\PROJECT2.accdb";

        private void UserTC_Load(object sender, EventArgs e)
        {

        }

        private void LoadApprovedReservations()
        {
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PROJECT2.accdb;"))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT [Reservation ID], [Date], [Start Time], [End Time], [Building], [Room Name], [Status]
                             FROM Reservations
                             WHERE [Status] = 'Approved'";

                    // Use OleDbCommand within the scope of the connection
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the data to the DataGridView
                        if (dt.Rows.Count > 0)
                        {
                            dgvTC.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No approved reservations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvTC.DataSource = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool sidebarExpand = true;
        private void sidebarTrans_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                uReserveFlow.Width -= 10;
                if (uReserveFlow.Width <= 66)
                {
                    sidebarExpand = false;
                    sidebarTrans.Stop();
                }
            }
            else
            {
                uReserveFlow.Width += 10;
                if (uReserveFlow.Width >= 195)
                {
                    sidebarExpand = true;
                    sidebarTrans.Stop();
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            sidebarTrans.Start();
        }

        private void uRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRoom roomform = new UserRoom(userId);
            roomform.ShowDialog();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserReserve reserveform = new UserReserve(userId);
            reserveform.ShowDialog();
        }

        private void uIns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Instructors' page.");
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            con.Open();

            // Format DateTime.Now to remove milliseconds
            string formattedTimeOut = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Update the LogTable with TimeOut
            string updateLogQuery = "UPDATE LogHistory SET [Log Out] = @timeOut WHERE ID = @userId AND [Log Out] IS NULL";
            OleDbCommand updateCmd = new OleDbCommand(updateLogQuery, con);
            updateCmd.Parameters.AddWithValue("@timeOut", formattedTimeOut);
            updateCmd.Parameters.AddWithValue("@userId", userId);

            updateCmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Logout Successful.");
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        /*private void LoadInstructorSchedules()
        {
            string instructorId = tbInsID.Text.Trim();

            // If the instructor ID is empty, clear the DataGridView and return.
            if (string.IsNullOrEmpty(instructorId))
            {
                dgvTC.DataSource = null;
                return;
            }

            using (con = new OleDbConnection(conString))
            {
                string query = @"SELECT [Reservation ID], Date, [Start Time], [End Time], Building, [Room Name] FROM Reservations 
                               WHERE InstructorID = @InstructorID 
                               AND Date >= NOW() 
                               AND Date < DATEADD(DAY, 7, NOW())";

                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@InstructorID", instructorId);

                    dt = new DataTable();
                    adt = new OleDbDataAdapter(cmd);
                    adt.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        // Display a message box if no schedules exist for the instructor.
                        MessageBox.Show("The inputted instructor ID does not exist or has no schedules for the week.",
                                        "No Schedules Found",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                        // Clear the DataGridView to remove any previous data.
                        dgvTC.DataSource = null;
                        return;
                    }

                    // Set the DataGridView's data source to the table.
                    dgvTC.DataSource = dt;

                    // Adjust column headers (optional, depending on your requirements).
                    dgvTC.Columns["ReservationID"].HeaderText = "Reservation ID";
                    dgvTC.Columns["Date"].HeaderText = "Date";
                    dgvTC.Columns["Time"].HeaderText = "Time";
                    dgvTC.Columns["Building"].HeaderText = "Building";
                    dgvTC.Columns["Room"].HeaderText = "Room";
                }
            }
        }*/

        private void tbInsID_TextChanged(object sender, EventArgs e)
        {
            //LoadInstructorSchedules();
        }

        private void tbfname_TextChanged(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(conString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT [Room Name] FROM RoomList WHERE [Room Name] LIKE ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", "%" + tbfname.Text + "%");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tblname_TextChanged(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(conString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT [Room Name] FROM RoomList WHERE [Room Name] LIKE ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", "%" + tblname.Text + "%");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
