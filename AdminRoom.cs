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
    public partial class AdminRoom : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adt;
        DataTable dt;
        private int userId;

        public AdminRoom(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\project2\project2\bin\Debug\PROJECT2.accdb");
        }

        private void appClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void room_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Rooms' page.");
        }

        private void instructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminTC Tcform = new AdminTC(userId);
            Tcform.ShowDialog();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminReserve reserve = new AdminReserve(userId);
            reserve.ShowDialog();
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

        void LoadRooms()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\project2\project2\bin\Debug\PROJECT2.accdb");
            dt = new DataTable();
            adt = new OleDbDataAdapter("SELECT * FROM RoomList", con);
            con.Open();
            adt.Fill(dt);
            dgvAdminRoom.DataSource = dt;
            con.Close();
        }

        private void AdminRoom_Load(object sender, EventArgs e)
        {
            LoadRooms();

            comboBldg.Items.Add("MAIN");
            comboBldg.Items.Add("ANNEX");

            comboRoomType.Items.Add("Laboratory");
            comboRoomType.Items.Add("Normal classroom");
        }

        private void ClearFields()
        {
            tbID.Clear();
            roomName.Clear();
            comboBldg.Text = string.Empty;
            comboRoomType.Text = string.Empty;
            comboRoomType.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBldg.Text) ||    
                string.IsNullOrWhiteSpace(roomName.Text) ||    
                string.IsNullOrWhiteSpace(comboRoomType.Text))      
            {
                MessageBox.Show("Please fill in all fields before adding a room."); 
                return;
            }
            
            string query = "INSERT INTO RoomList (Building, [Room Name], Type) VALUES " + "(?, ?, ?)";
            cmd = new OleDbCommand(query, con);

            cmd.Parameters.AddWithValue("?", comboBldg.Text);
            cmd.Parameters.AddWithValue("?", roomName.Text);
            cmd.Parameters.AddWithValue("?", comboRoomType.Text); 

            con.Open();
            cmd.ExecuteNonQuery(); 
            MessageBox.Show("Room added successfully!"); 
            con.Close();

            LoadRooms();


            /*if (string.IsNullOrEmpty(roomName.Text) || 
                string.IsNullOrEmpty(comboBldg.Text) || 
                string.IsNullOrEmpty(comboRoomType.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a room.");
                return;
            }

            try
            {
                con.Open();

                // Check for duplicate Room Name
                string checkQuery = "SELECT COUNT(*) FROM RoomList WHERE [Room Name] = @RoomName";
                cmd = new OleDbCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@RoomName", roomName.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("A room with the same name already exists. Please choose a different name.");
                    return;
                }

                // Insert the new room
                string query = "INSERT INTO RoomList ([Room Name], Building, Type) VALUES (@RoomName, @Building, @RoomType)";
                cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("@RoomName", roomName.Text);
                cmd.Parameters.AddWithValue("@Building", comboBldg.Text);
                cmd.Parameters.AddWithValue("@RoomType", comboRoomType.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Room added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                LoadRooms();
            }

            /*if (string.IsNullOrEmpty(roomName.Text) || 
                string.IsNullOrEmpty(comboBldg.Text) || 
                string.IsNullOrEmpty(comboRoomType.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a room.");
                return;
            }

            string query = "INSERT INTO RoomList ([Room Name], Building, Type) VALUES (@RoomName, @Building, @RoomType)";
            cmd = new OleDbCommand(query, con);

            con.Open();
            cmd.Parameters.AddWithValue("@RoomName", roomName.Text);
            cmd.Parameters.AddWithValue("@Building", comboBldg.Text);
            cmd.Parameters.AddWithValue("@RoomType", comboRoomType.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Room added successfully!");
            con.Close();

            LoadRooms();*/
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBldg.Text) ||
                string.IsNullOrWhiteSpace(roomName.Text) ||
                string.IsNullOrWhiteSpace(comboRoomType.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                string query = "UPDATE RoomList SET Building=?, [Room Name]=?, Type=? WHERE [Room ID]=?";
                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("?", comboBldg.Text);
                    cmd.Parameters.AddWithValue("?", roomName.Text);
                    cmd.Parameters.AddWithValue("?", comboRoomType.Text);
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(tbID.Text));

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Room updated successfully." : "Room not found.");
                }
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating room: {ex.Message}");
            }
            finally
            {
                con.Close();
            }

            /*if (string.IsNullOrWhiteSpace(tbID.Text) ||
                string.IsNullOrWhiteSpace(comboBldg.Text) ||
                string.IsNullOrWhiteSpace(roomName.Text) ||
                string.IsNullOrWhiteSpace(comboRoomType.Text))
            {
                MessageBox.Show("Please fill in all fields, including the ID.");
                return;
            }

            try
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM RoomList WHERE [Room Name] = @RoomName AND ID <> @ID";
                cmd = new OleDbCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@RoomName", roomName.Text);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(tbID.Text));
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("A room with the same name already exists. Please choose a different name.");
                    return;
                }

                string query = "UPDATE RoomList SET Building=@Building, [Room Name]=@RoomName, Type=@RoomType WHERE ID=@ID";
                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Building", comboBldg.Text);
                    cmd.Parameters.AddWithValue("@RoomName", roomName.Text);
                    cmd.Parameters.AddWithValue("@RoomType", comboRoomType.Text);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(tbID.Text));

                    //con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Room updated successfully." : "Room not found. Please check the ID and try again.");
                }
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating room: {ex.Message}");
            }
            finally
            {
                con.Close();
            }*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM RoomList WHERE ID = @ID";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", tbID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Room deleted successfully!");

                LoadRooms();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT [Room ID], [Room Name], Building, Type FROM RoomList WHERE [Room Name] LIKE @Search OR Building LIKE @Search";
                adt = new OleDbDataAdapter(query, con);
                adt.SelectCommand.Parameters.AddWithValue("@Search", "%" + tbSearch.Text + "%");

                DataTable dt = new DataTable();
                adt.Fill(dt);
                dgvAdminRoom.DataSource = dt;
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

        private void dgvAdminRoom_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dgvAdminRoom.CurrentRow.Cells[0].Value.ToString();
            comboBldg.Text = dgvAdminRoom.CurrentRow.Cells[1].Value.ToString();
            roomName.Text = dgvAdminRoom.CurrentRow.Cells[2].Value.ToString();
            comboRoomType.Text = dgvAdminRoom.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
