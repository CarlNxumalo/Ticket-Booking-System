using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG212_43400205
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        //public varibles  and objects
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;

        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventConnectDB.mdf;Integrated Security=True";


        private void gbSignUp_Enter(object sender, EventArgs e)
        {

        }
        private void insertMethod()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sql = $"insert into users values({txtUserID.Text}, '{txtFName.Text}', '{txtLName.Text}', '{txtPassword.Text}', 1)";
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //insert user to database
            try
            {
                //validate the data
                int temp = 0;
                if(txtUserID.Text.Length == 4 && int.TryParse(txtUserID.Text, out temp))//ID is 4 digits
                {
                    if(txtFName.Text!="")
                    {
                        if(txtLName.Text!="")
                        {
                            if (txtPassword.Text != "")
                            {
                                //good data
                                insertMethod();
                                MessageBox.Show("Your have successfully sign up to EventConnect\nNow Press the login button ", "Sign up status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();

                            }
                            else
                            {
                                epSignUp.SetError(txtPassword, "Enter password");
                            }
                        }
                        else
                        {
                            epSignUp.SetError(txtLName, "Enter surname");
                        }
                    }
                    else
                    {
                        epSignUp.SetError(txtFName, "Enter name");
                    }
                }
                else
                {
                    epSignUp.SetError(txtUserID, "Error enter 4 digits");
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "Sign up user Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            //connect to database
            try
            {
                connection = new SqlConnection(conStr);
                connection.Open();
                connection.Close();
                Console.WriteLine("Connected successfully");
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "Database connetion Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
