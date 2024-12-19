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
    public partial class AdminTC : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adt;
        DataTable dt;
        private int userId;

        public AdminTC(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PROJECT2.accdb;");
        }

        void GetUsers()
        {
            // Establish the connection string to connect to the Access database
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:PROJECT2.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adt = new OleDbDataAdapter("SELECT * FROM UserAccounts", con);
            // Open the connection
            con.Open();
            // Fill the DataTable with the result of the query
            adt.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvUsers.DataSource = dt;
            // Close the database connection
            con.Close();

            if (dt.Rows.Count > 0)
            {
                dt.Rows.RemoveAt(0);
            }

            if (dgvUsers.Columns["Password"] != null)
            {
                dgvUsers.Columns["Password"].Visible = false;
            }

            if (dgvUsers.Columns["Type"] != null)
            {
                dgvUsers.Columns["Type"].Visible = false;
            }
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {
            GetUsers();
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

        private void appClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void room_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRoom room = new AdminRoom(userId);
            room.ShowDialog();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminReserve reserve = new AdminReserve(userId);
            reserve.ShowDialog();
        }

        private void instructors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Instructors' page.");
        }

        private void cbShowpass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbShowpass.Checked)
            {
                tbPass.PasswordChar = '\0'; //show password
            }
            else
            {
                tbPass.PasswordChar = '*'; //hide password
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbInsID.Text) ||    // Teacher's ID
                string.IsNullOrWhiteSpace(tbFname.Text) ||    // First Name
                string.IsNullOrWhiteSpace(tbLname.Text) ||    // Last Name
                string.IsNullOrWhiteSpace(tbEmail.Text) ||    // Email
                string.IsNullOrWhiteSpace(tbUname.Text) ||   // Username
                string.IsNullOrWhiteSpace(tbPass.Text))      // Password
            {
                MessageBox.Show("Please fill in all fields."); // Display a message if any field is empty
                return; // Exit the method if any field is missing
            }
            // SQL query to insert a new user into the 'UserAccounts' table
            string query = "INSERT INTO UserAccounts ([Teacher's ID], Firstname, Lastname, [Email Address], Username, [Password], Type) VALUES " +
                "(?, ?, ?, ?, ?, ?, ?)";
            // Create the command to execute the query
            cmd = new OleDbCommand(query, con);

            // Add values from textboxes and other controls to the command parameters
            cmd.Parameters.AddWithValue("?", tbInsID.Text); // Teacher's ID
            cmd.Parameters.AddWithValue("?", tbFname.Text); // First Name
            cmd.Parameters.AddWithValue("?", tbLname.Text); // Last Name
            cmd.Parameters.AddWithValue("?", tbEmail.Text);  // Email
            cmd.Parameters.AddWithValue("?", tbUname.Text);   // Username
            cmd.Parameters.AddWithValue("?", tbPass.Text);   // Password
            cmd.Parameters.AddWithValue("?", "user"); // default type 

            // Open the connection, execute the command, and close the connection
            con.Open(); // Open the connection to the database
            cmd.ExecuteNonQuery(); // Execute the insert query
            MessageBox.Show("User Inserted Successfully"); // Show success message
            con.Close(); // Close the connection to the database

            // Refresh DataGridView to show the newly inserted user
            GetUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbInsID.Text) ||
                string.IsNullOrWhiteSpace(tbFname.Text) ||
                string.IsNullOrWhiteSpace(tbLname.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbUname.Text) ||
                string.IsNullOrWhiteSpace(tbPass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                string query = "UPDATE UserAccounts SET [Teacher's ID]=?, Firstname=?, Lastname=?, [Email Address]=?, Username=?, [Password]=? WHERE ID=?";
                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("?", tbInsID.Text);
                    cmd.Parameters.AddWithValue("?", tbFname.Text);
                    cmd.Parameters.AddWithValue("?", tbLname.Text);
                    cmd.Parameters.AddWithValue("?", tbEmail.Text);
                    cmd.Parameters.AddWithValue("?", tbUname.Text);
                    cmd.Parameters.AddWithValue("?", tbPass.Text); // Hash password here
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(tbID.Text));

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "User updated successfully." : "User not found.");
                }
                GetUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // SQL query to delete a user based on their ID
            string query = "DELETE FROM UserAccounts WHERE ID = ?";

            // Create a new OleDbCommand with the query and the database connection
            cmd = new OleDbCommand(query, con);

            // Add the user ID parameter to the command
            cmd.Parameters.AddWithValue("?", Convert.ToInt32(tbID.Text)); // Convert the ID from the textbox to an integer

            // Open the connection, execute the command, and close the connection
            con.Open(); // Open the connection to the database
            cmd.ExecuteNonQuery(); // Execute the delete query
            MessageBox.Show("User Deleted"); // Show a success message
            con.Close(); // Close the connection to the database

            // Refresh the DataGridView to reflect changes
            GetUsers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            tbID.Clear();
            tbInsID.Clear();
            tbFname.Clear();
            tbLname.Clear();
            tbEmail.Clear();
            tbUname.Clear();
            tbPass.Clear();
            tbSearch.Clear();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // SQL query to search for users by ID using a partial match
            string searchQuery = "SELECT * FROM UserAccounts WHERE ID LIKE ?";

            // Create a new OleDbDataAdapter with the search query and the database connection
            adt = new OleDbDataAdapter(searchQuery, con);

            // Add the search parameter with the value from the search textbox
            adt.SelectCommand.Parameters.AddWithValue("?", tbSearch.Text + "%"); // Add '%' for partial matching

            dt = new DataTable(); // Create a new DataTable to hold the search results

            // Open the connection, fill the DataTable with search results, and close the connection
            con.Open(); // Open the connection to the database
            adt.Fill(dt); // Fill the DataTable with search results
            con.Close(); // Close the connection to the database

            // Bind the DataTable to the DataGridView
            dgvUsers.DataSource = dt;
        }

        private void dgvUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Populate textboxes and controls with data from the currently selected row
            tbID.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString(); // User ID
            tbInsID.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString(); // Teacher's ID
            tbFname.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString(); // First Name
            tbLname.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString(); // Last Name
            tbEmail.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString(); // Birthdate
            tbUname.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();   // Username
            tbPass.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();   // Password
        }
    }
}
