using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project2
{
    public partial class AdminReserve : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adt;
        DataTable dt;
        private int userId;

        public AdminReserve(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\project2\project2\bin\Debug\PROJECT2.accdb");
        }

        string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\project2\project2\bin\Debug\PROJECT2.accdb";

        private void AdminReserve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJECT2DataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.pROJECT2DataSet.Reservations);
            LoadReservations();
        }

        private void LoadReservations()
        {
            try
            {
                con.Open();
                string query = @"
                SELECT 
                    [Reservation ID], 
                    [Building], 
                    [Room Name], 
                    [Booked By], 
                    [Subject Code], 
                    [Course], 
                    [Section], 
                    [Date], 
                    [Start Time], 
                    [End Time], 
                    [Status] 
                FROM 
                    Reservations 
                WHERE 
                    [Status] = 'Pending' 
                ORDER BY 
                    [Date] ASC";

                adt = new OleDbDataAdapter(query, con);
                dt = new DataTable();
                adt.Fill(dt);

                dgvReserve.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservations: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void room_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRoom roomForm = new AdminRoom(userId);
            roomForm.ShowDialog();
        }

        private void instructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminTC tcForm = new AdminTC(userId);
            tcForm.ShowDialog();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Reservations' page.");
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

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateReservationStatus("Approved");
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            UpdateReservationStatus("Declined");
        }

        private void UpdateReservationStatus(string status)
        {
            if (dgvReserve.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to update.");
                return;
            }

            try
            {
                // Debugging: Check if the column is being accessed correctly
                Console.WriteLine("Selected row index: " + dgvReserve.SelectedRows[0].Index);
                foreach (DataGridViewColumn column in dgvReserve.Columns)
                {
                    Console.WriteLine("Column Name: " + column.Name);
                }

                // Use an index to access the column if necessary
                int reservationId = Convert.ToInt32(dgvReserve.SelectedRows[0].Cells[0].Value); // Adjust index as needed

                con.Open();
                string query = "UPDATE Reservations SET [Status] = @status WHERE [Reservation ID] = @reservationId";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@reservationId", reservationId);

                cmd.ExecuteNonQuery();
                MessageBox.Show($"Reservation {status} successfully.");
                LoadReservations(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating reservation: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void dgvReserve_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvReserve.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
