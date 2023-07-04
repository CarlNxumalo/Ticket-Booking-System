using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG212_43400205
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables and objects 
        public bool isHost = false, isUser = false;
        public string userID = "", password = "";

        //link to classes create new when menustrip buttons clicked
        HostDash hd;
        Login obj;
        UserDash ud;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //take user to dash board

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //open login
            obj = new Login();
            obj.ShowDialog();

            //is user host/user
            isHost = obj.isHost;
            isUser = obj.isUser;

            //save credentials
            userID = obj.userID;
            password = obj.password;

            //check if user is authorized first
            if (isUser)
            {
                //sending user credentials to next form
                ud = new UserDash();
                ud.MdiParent = this;
                ud.password = password;
                ud.userID = userID;
                ud.Show();
            }
            else
            {
                MessageBox.Show("You are not a member\nPlease sign up");
            }
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logged in users can't make new accounts
            if(isUser)
            {
                MessageBox.Show("You are already a user", "Cannot sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SignUp su = new SignUp();
                su.MdiParent = this;
                su.Show();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open login 
            obj = new Login();
            obj.ShowDialog();

            //is user host/user
            isHost = obj.isHost;
            isUser = obj.isUser;

            //save credentials
            userID = obj.userID;
            password = obj.password;

            //check if user is authorized first
            if (isUser)
            {
                //sending user credentials to next form
                ud = new UserDash();
                ud.MdiParent = this;
                ud.password = password;
                ud.userID = userID;
                ud.Show();
            }
            else
            {
                MessageBox.Show("You are not a member\nPlease sign up or Login");
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hostDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check is user is a host 
            if (isHost)
            {
                hd = new HostDash();
                hd.MdiParent = this;
                hd.password = password;
                hd.userID = userID;
                hd.Show();
            }
            else
            {
                MessageBox.Show("You are not a host\nUpgrade your membership");
            }
        }

        private void userDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if user is authorized first
            if(isUser)
            {
                //sending user credentials to next form
                ud = new UserDash();
                ud.MdiParent = this;
                ud.password = password;
                ud.userID = userID;
                ud.Show();

            }
            else
            {
                MessageBox.Show("You are not a member\nPlease sign up");
            }
        }
    }
}
