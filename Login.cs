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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //public varibles  and objects
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventConnectDB.mdf;Integrated Security=True";
        public string userID, password;
        public bool isUser = false, isHost = false;

        private void authenticate(string ID, string password)
        {
            try
            {
                if(connection.State==ConnectionState.Closed)
                {
                    connection.Open();
                }
                //read database for id and password
                string tempID="", tempPass ="";


                string sql = $"select userID, password, premium from users where userID = {ID}";
                command = new SqlCommand(sql, connection);

                reader = command.ExecuteReader();

                if (reader.Read())//checking if data appeared from DB
                {
                    tempID = reader.GetValue(0).ToString();
                    tempPass = reader.GetValue(1).ToString();
                    
                    //compare
                    if (tempPass == password && tempID == ID)
                    {
                        //valid user, tell mdi that the user is valid then let him see user and/or host dashboard
                        isUser = true;
                        isHost = bool.Parse(reader.GetValue(2).ToString());
                        userID = ID;
                        this.password = password;


                        MessageBox.Show("Logged in succesfully");

                        this.Close();
                        
                    }
                    else
                    {
                        //incorrect credentials
                        lblLoginError.Text = "incorrect ID or password";
                        lblLoginError.ForeColor = Color.DarkRed;
                    }
                }
                else
                {
                    lblLoginError.Text = "No such user in our database";
                    lblLoginError.ForeColor = Color.DarkRed;
                }

                reader.Close();
                connection.Close();
               
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Login error");
            }
        }

        private void lblLoginError_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        { 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //set up connection to database 
            try
            {
                connection = new SqlConnection(conStr);
                connection.Open();
                connection.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the ID and Password then send it to the mdi form

            if(txtUserID.Text!="")
            {
                if(txtPassword.Text !="")
                {
                    userID = txtUserID.Text;
                    password = txtPassword.Text;

                    //authenticate user
                    authenticate(userID, password);
                    
                }
                else
                {
                    epLogin.SetError(txtPassword, "Enter a password");
                }
            }
            else
            {
                epLogin.SetError(txtUserID,"Enter a user ID");
            }

        }
    }
}
