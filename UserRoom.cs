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
    public partial class UserRoom : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adt;
        DataTable dt;
        private int userId;

        public UserRoom(int userId)
        {
            InitializeComponent();
            LoadComboBox();
            LoadBuilding();
            this.userId = userId;
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PROJECT2.accdb;");
        }

        string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\project2\project2\bin\Debug\PROJECT2.accdb";

        private void LoadComboBox()
        {
            using (conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT [Room Name] FROM RoomList"; // Replace with your column and table name
                    cmd = new OleDbCommand(query, conn);
                    adt = new OleDbDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        comboRm.DataSource = dt;
                        comboRm.DisplayMember = "Room Name"; // The column name to display
                        comboRm.ValueMember = "Room Name";   // Optional, for selecting values
                    }
                    else
                    {
                        comboRm.DataSource = null;
                        comboRm.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rooms: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LoadBuilding()
        {
            using (conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT BuildingID, BuildingType FROM Building";
                    adt = new OleDbDataAdapter(query, conn);
                    dt = new DataTable();
                    adt.Fill(dt);

                    comboBldg.DataSource = dt;
                    comboBldg.DisplayMember = "BuildingType"; // What the user sees
                    comboBldg.ValueMember = "BuildingType";    // Value used for filtering
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
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
                            dgvRooms.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No approved reservations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvRooms.DataSource = null;
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

        private void UserRoom_Load(object sender, EventArgs e)
        {

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

        private void uIns_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTC TCform = new UserTC(userId);
            TCform.ShowDialog();
        }

        private void uReserve_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserReserve reserveForm = new UserReserve(userId);
            reserveForm.ShowDialog();
        }

        private void uRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Rooms' page.");
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Format DateTime.Now to remove milliseconds
            string formattedTimeOut = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Update the LogTable with TimeOut
            string updateLogQuery = "UPDATE LogHistory SET [Log Out] = @timeOut WHERE ID = @userId AND [Log Out] IS NULL";
            OleDbCommand updateCmd = new OleDbCommand(updateLogQuery, conn);
            updateCmd.Parameters.AddWithValue("@timeOut", formattedTimeOut);
            updateCmd.Parameters.AddWithValue("@userId", userId);

            updateCmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Logout Successful.");
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void comboBldg_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadApprovedReservations();
        }

        private void comboRm_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadApprovedReservations();
        }

        private void comboRm_TextChanged(object sender, EventArgs e)
        {
            using (conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT [Room Name] FROM RoomList WHERE [Room Name] LIKE '%{comboRm.Text}%'";
                    cmd = new OleDbCommand(query, conn);
                    adt = new OleDbDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);

                    comboRm.DataSource = dt;
                    comboRm.DisplayMember = "Room Name";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM Reservations WHERE ID LIKE ?";
            adt = new OleDbDataAdapter(searchQuery, conn);
            adt.SelectCommand.Parameters.AddWithValue("?", tbSearch.Text + "%");
            dt = new DataTable();
            conn.Open(); 
            adt.Fill(dt); 
            conn.Close();
            dgvRooms.DataSource = dt;
        }
    }
}
