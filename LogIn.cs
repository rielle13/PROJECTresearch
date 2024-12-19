using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;


namespace project2
{
    public partial class LogIn : Form
    {

        OleDbConnection connection;
        OleDbCommand command;

        public LogIn()
        {
            InitializeComponent();
            //string connectionString = ConfigurationManager.ConnectionStrings["AccessDB"].ConnectionString;
            //connection = new OleDbConnection(connectionString);
        }

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Desktop\project2\project2\bin\Debug\PROJECT2.accdb";

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void cbShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowpass.Checked)
            {
                tbPassword.PasswordChar = '\0'; //show password
            }
            else
            {
                tbPassword.PasswordChar = '*'; //hide password
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection = new OleDbConnection (connectionString))
                {
                    connection.Open();

                    // Query to validate username and password
                    string query = "SELECT ID, Type FROM UserAccounts WHERE Username = @username AND Password = @password";
                    command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@username", tbUsername.Text.Trim());
                    command.Parameters.AddWithValue("@password", tbPassword.Text.Trim());

                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string userType = reader.GetString(1);

                        // Format DateTime.Now to remove milliseconds
                        string formattedTimeIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        // Insert the TimeIn value as Date/Time in LogTable
                        string insertLogQuery = "INSERT INTO LogHistory (ID, [Log In]) VALUES (@userId, @timeIn)";
                        OleDbCommand insertCmd = new OleDbCommand(insertLogQuery, connection);
                        insertCmd.Parameters.AddWithValue("@userId", userId);
                        insertCmd.Parameters.AddWithValue("@timeIn", formattedTimeIn);

                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Login Successfully");

                        // Redirect based on user type
                        this.Hide();
                        if (userType == "admin")
                        {
                            AdminTC adminForm = new AdminTC(userId); // Admin interface
                            adminForm.ShowDialog();
                        }
                        else
                        {
                            UserRoom userForm = new UserRoom(userId); // User interface
                            userForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password.");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void appClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPass forgotPass = new ForgotPass();
            forgotPass.ShowDialog();
            this.Show();
        }
    }
}
