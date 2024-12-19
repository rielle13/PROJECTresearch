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
    public partial class UserReserve : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adt;
        DataTable dt;
        private int userId;

        string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\project2\project2\bin\Debug\PROJECT2.accdb";

        public UserReserve(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\project2\project2\bin\Debug\PROJECT2.accdb");
            LoadComboBox();
            LoadBuilding();
        }

        private void LoadComboBox()
        {
            using (con = new OleDbConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT [Room Name] FROM RoomList"; // Replace with your column and table name
                    cmd = new OleDbCommand(query, con);
                    adt = new OleDbDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        roomName.DataSource = dt;
                        roomName.DisplayMember = "Room Name"; // The column name to display
                        roomName.ValueMember = "Room Name";   // Optional, for selecting values
                    }
                    else
                    {
                        roomName.DataSource = null;
                        roomName.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rooms: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void LoadBuilding()
        {
            using (con = new OleDbConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT BuildingID, BuildingType FROM Building";
                    adt = new OleDbDataAdapter(query, con);
                    dt = new DataTable();
                    adt.Fill(dt);

                    bldgReserve.DataSource = dt;
                    bldgReserve.DisplayMember = "BuildingType"; // What the user sees
                    bldgReserve.ValueMember = "BuildingType";    // Value used for filtering
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void UserReserve_Load(object sender, EventArgs e)
        {

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
            UserRoom room = new UserRoom(userId);
            room.ShowDialog();
        }

        private void uIns_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTC ins = new UserTC(userId);
            ins.ShowDialog();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Reservations' page.");
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new OleDbConnection(conString))
                {
                    con.Open();

                    // Format DateTime.Now to remove milliseconds
                    string formattedTimeOut = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // Update the LogTable with TimeOut
                    string updateLogQuery = @"UPDATE LogHistory SET [Log Out] = @timeOut 
                                      WHERE ID = @userId AND [Log Out] IS NULL";
                    using (OleDbCommand updateCmd = new OleDbCommand(updateLogQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@timeOut", formattedTimeOut);
                        updateCmd.Parameters.AddWithValue("@userId", userId);

                        updateCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Logout Successful.");
                this.Hide();
                LogIn login = new LogIn();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during logout: " + ex.Message);
            }
        }

        private void roomName_TextChanged(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT [Room Name] FROM RoomList WHERE [Room Name] LIKE '%{roomName.Text}%'";
                    cmd = new OleDbCommand(query, con);
                    adt = new OleDbDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);

                    roomName.DataSource = dt;
                    roomName.DisplayMember = "Room Name";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bldgReserve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bldgReserve.SelectedValue != null)
            {
                string buildingType = Convert.ToString(bldgReserve.SelectedValue); // Get the selected BuildingID
                LoadRooms(buildingType);
            }
        }

        private void LoadRooms(string buildingType)
        {
            using (con = new OleDbConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT [Room Name] FROM RoomList WHERE Building = ?";
                    cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("?", buildingType);

                    adt = new OleDbDataAdapter(cmd);
                    dt = new DataTable();
                    adt.Fill(dt);

                    roomName.DataSource = dt;
                    roomName.DisplayMember = "Room Name"; // What the user sees
                    roomName.ValueMember = "Room Name";    // Optional
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }    
        }

        public bool IsRoomAvailable(string roomName, DateTime date, DateTime start, DateTime end)
        {
            using (con = new OleDbConnection(conString))
            {
                con.Open();

                // Query checks for overlapping reservations
                string query = @"SELECT COUNT(*) FROM Reservations 
                         WHERE [Room Name] = @roomName AND 
                               [Date] = @date AND 
                               (([Start Time] < @end AND [End Time] > @start))";

                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@roomName", roomName);
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    int count = (int)cmd.ExecuteScalar();
                    return count == 0; // Returns true if no conflicts exist
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (bldgReserve.SelectedValue == null || roomName.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid building and room.");
                return;
            }

            if (string.IsNullOrEmpty(bookedBy.Text) || string.IsNullOrEmpty(subject.Text) ||
                string.IsNullOrEmpty(course.Text) || string.IsNullOrEmpty(section.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            string bldg = bldgReserve.SelectedValue.ToString();
            string room = roomName.SelectedValue.ToString();
            DateTime date = datepicker.Value.Date;
            DateTime startTime = start.Value;
            DateTime endTime = end.Value;

            if (IsRoomAvailable(room, date, startTime, endTime))
            {
                using (con = new OleDbConnection(conString))
                {
                    try
                    {
                        con.Open();
                        string reserveQuery = @"INSERT INTO Reservations 
                     ([Building], [Room Name], [Booked By], [Subject Code], [Course], [Section], [Date], [Start Time], [End Time], [Status]) 
                     VALUES (@bldg, @roomName, @bookedBy, @subCode, @course, @section, @date, @startTime, @endTime, 'Pending')";

                        using (OleDbCommand reserveCmd = new OleDbCommand(reserveQuery, con))
                        {
                            reserveCmd.Parameters.AddWithValue("@bldg", bldg);
                            reserveCmd.Parameters.AddWithValue("@roomName", room);
                            reserveCmd.Parameters.AddWithValue("@bookedBy", bookedBy.Text);
                            reserveCmd.Parameters.AddWithValue("@subCode", subject.Text);
                            reserveCmd.Parameters.AddWithValue("@course", course.Text);
                            reserveCmd.Parameters.AddWithValue("@section", section.Text);
                            reserveCmd.Parameters.AddWithValue("@date", date);
                            reserveCmd.Parameters.AddWithValue("@startTime", startTime);
                            reserveCmd.Parameters.AddWithValue("@endTime", endTime);

                            reserveCmd.ExecuteNonQuery();
                            MessageBox.Show("Reservation request submitted! Waiting for admin approval.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Room is not available at the selected time.");
            }
        }
    }
}
