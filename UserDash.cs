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
    public partial class UserDash : Form
    {
        public UserDash()
        {
            InitializeComponent();
        }

        //public varibles  and objects
        public string userID = "", password = "";

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        DataSet ds;
        string sql;
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventConnectDB.mdf;Integrated Security=True";
        //connecting to invoice form
        Invoice invoice;
        
        //variables for validating and creating the invoice
        int tempPrice = 0;
        int tempCapacity = 0, tempNumberOfParticipants = 0;
        string title = "", venue = "", date = "";
        bool userHasRegisteredForEvent = false;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //variable 
            int tempPrice = 0, tempCapacity = 0, tempNumberOfParticipants = 0;
            DialogResult result;
            //userID, eventID adds to registartion table
            try
            {
                //getting the data to validate insert 
                if (cmbSelected.SelectedIndex != -1)
                {
                    //get the price and capacity of the event using data reader 
                    sql = $"select price, venues.capacity, title, venues.name, date from events " +
                        $"inner join venues on events.venueID = venues.venueID " +
                        $"where events.eventID = {cmbSelected.Text}";
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();

                    if(dataReader.Read())
                    {
                        tempPrice = int.Parse(dataReader.GetValue(0).ToString());
                        tempCapacity = int.Parse(dataReader.GetValue(1).ToString());
                        //this is for invoice
                        title = dataReader.GetValue(2).ToString();
                        venue = dataReader.GetValue(3).ToString();
                        date = dataReader.GetValue(4).ToString();
                    }
                    connection.Close();

                    //now we are getting the capacity of the event
                    sql = $"select count(*) from Register where eventID={cmbSelected.Text}";
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();

                    if (dataReader.Read())
                    {
                        tempNumberOfParticipants = int.Parse(dataReader.GetValue(0).ToString());
                    }
                    connection.Close();


                    //we now have all the variable values
                    if(tempNumberOfParticipants<tempCapacity)//good
                    {
                        if(tempPrice!=0)
                        {
                            //it cost money
                            result = MessageBox.Show($"The event costs R {tempPrice}.00\nWould you like to pay?", "Confrim purchase", MessageBoxButtons.YesNo);

                            if(result == DialogResult.Yes)
                            {
                                registerForEvent();
                                userHasRegisteredForEvent = true;
                            }
                            else
                            {
                                MessageBox.Show("You have not registered for the event", "Registration Failure");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You have successfully registered\nfor the free event", "Registration");
                            registerForEvent();
                            userHasRegisteredForEvent = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Event is full sorry", "Capacity");
                    }
                }
                else
                {
                    epUserDash.SetError(cmbSelected, "Please select");
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Register for event Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerForEvent()
        {
            try
            {
                //insery query
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sql = $"insert into Register " +
                    $"values({userID}, {cmbSelected.Text})";

                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();

                //notification of success.
                MessageBox.Show($"Notification!\nYou have successfully registered!\nFor EventID: {cmbSelected.Text}", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Could not insert registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e) //personal info update
        {
            //updating personal info
            if(txtNameUp.Text!="")
            {
                if(txtLNameUp.Text!="")
                {
                    updateMethod($"Update users set firstName= '{txtNameUp.Text}', lastName= '{txtLNameUp.Text}'", "Update personal info error");
                    //refresh dgv
                    displayEventsDGV($"select userID, firstName, lastName from users where userID = {userID}", "Displaying Users Error");
                    MessageBox.Show("Udated Personal Info!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    epUserDash.SetError(txtNameUp, "Enter last name");
                }
            }
            else
            {
                epUserDash.SetError(txtNameUp, "Enter name");
            }
        }


        //i used this twice
        static DateTime now = DateTime.Now;
        string strNow = now.ToString("d");
        private void UserDash_Load(object sender, EventArgs e)
        {
            //fill combobox with event ID's 
            //show events that are up coming
            //Maybe - show the user events that he hasn't reistered for
            try
            {
                //connect to db
                connection = new SqlConnection(conStr);
                connection.Open();

                sql = $"select eventID from events where date >='{strNow}' AND registration = 1;";//show events that are up coming allow users to register
                command = new SqlCommand(sql, connection);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                ds = new DataSet();

                dataAdapter.Fill(ds, "events");

                //create/edit tap
                cmbSelected.DataSource = ds.Tables["events"];
                cmbSelected.DisplayMember = "eventID";

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Fill CMB Control Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateMethod(string sql, string error)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMembership_Click(object sender, EventArgs e)
        {
            //chnging mmembership
            try
            {
                int ans = 0;
                //check if the user selected a rdb control
                if(rdbNormal.Checked || rdbPremium.Checked)
                {
                    if(rdbNormal.Checked)
                    {
                        ans = 0;
                    }
                    else
                    {
                        ans = 1;
                    }

                    //update user membership
                    sql = $"update users set premium = {ans} where userID = {userID}";

                    updateMethod(sql, "Update Memebership Error");
                    displayEventsDGV($"select userID, firstName, lastName, premium from users where userID = {userID}", "Displaying Users Error");
                    MessageBox.Show("Udated membership on database.\nPlease re-login for changes to be functional on application", "Memebership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    epUserDash.SetError(rdbNormal, "Check one");
                    epUserDash.SetError(rdbPremium, "Check one");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Update Membership Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            //creating a very nice invoice using a new form.
            try
            {
                if(userHasRegisteredForEvent)
                {
                    invoice = new Invoice();
                    invoice.lblDate.Text = "Date:           " + date;
                    invoice.lblEventName.Text = "Event Title:    " + title;
                    invoice.lblVenue.Text = "Event Venue:    " + venue;
                    invoice.lblPrice.Text = "Price:          " + tempPrice;
                    invoice.Show();
                }
                else
                {
                    MessageBox.Show("Please register first to see invoice","invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print invoice error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tpPersonalInfo_Enter(object sender, EventArgs e)
        {
            displayEventsDGV($"select userID, firstName, lastName from users where userID = {userID}", "Displaying Users Error");
        }

        private void tpMembership_Enter(object sender, EventArgs e)
        {
            displayEventsDGV($"select userID, firstName, lastName, premium from users where userID = {userID}", "Displaying Users Error");
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text!="")
            {
                updateMethod($"update users set password = '{txtNewPass.Text}' where userID = {userID};", "Change password error");
                MessageBox.Show("Udated password!\nPlease re-login for changes to be finilized", "password", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                epUserDash.SetError(txtNewPass, "Enter password");
            }
        }
        
        private void txtNameS_TextChanged(object sender, EventArgs e)
        {
            sql = $"SELECT Register.eventID, events.title, venues.name as venue, events.date,  events.category, events.time, events.price,  events.description " +
                 $"FROM Register " +
                 $"INNER JOIN events ON Register.eventID = events.eventID " +
                 $"INNER JOIN venues ON events.venueID = venues.venueID " +
                 $"WHERE Register.userID = {userID} AND events.date >= '{strNow}' AND events.title like '%{txtNameS.Text}%';";

            displayEventsDGV(sql, "Search event name error");
        }

        private void tpUpComing_Enter(object sender, EventArgs e)
        {
            //This show the events the user registered for only.
            sql = $"SELECT Register.eventID, events.title, venues.name as venue, events.date,  events.category, events.time, events.price,  events.description " +
                 $"FROM Register " +
                 $"INNER JOIN events ON Register.eventID = events.eventID " +
                 $"INNER JOIN venues ON events.venueID = venues.venueID " +
                 $"WHERE Register.userID = {userID} AND events.date >= '{strNow}';";
            displayEventsDGV(sql, "Up coming events DGV error");
        }

        private void tpRegister_Enter(object sender, EventArgs e)
        {
            sql = $"select eventID, title, date, venues.name AS venue, time, price, category from events " +
                  $"inner join venues on events.venueID = venues.venueID " +
                  $"where date >= '{strNow}' AND registration = 1;";
            displayEventsDGV(sql, "Register DGV error");
        }

        private void tpUpComing_Click(object sender, EventArgs e)
        {

        }

        private void txtVenueS_TextChanged(object sender, EventArgs e)
        {
            sql =$"SELECT Register.eventID, events.title, venues.name as venue, events.date,  events.category, events.time, events.price,  events.description " +
                 $"FROM Register " +
                 $"INNER JOIN events ON Register.eventID = events.eventID " +
                 $"INNER JOIN venues ON events.venueID = venues.venueID " +
                 $"WHERE Register.userID = {userID} AND events.date >= '{strNow}' AND venues.name LIKE '%{txtVenueS.Text}%';";

            displayEventsDGV(sql, "Search for venue error");
        }

        private void txtDateS_TextChanged(object sender, EventArgs e)
        {
            sql = $"SELECT Register.eventID, events.title, venues.name as venue, events.date,  events.category, events.time, events.price,  events.description " +
                 $"FROM Register " +
                 $"INNER JOIN events ON Register.eventID = events.eventID " +
                 $"INNER JOIN venues ON events.venueID = venues.venueID " +
                 $"WHERE Register.userID = {userID} AND events.date >= '{strNow}' AND events.date LIKE '%{txtDateS.Text}%';";

            displayEventsDGV(sql, "Search using date error");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//category search
        {
            sql = $"SELECT Register.eventID, events.title, venues.name as venue, events.date,  events.category, events.time, events.price,  events.description " +
                 $"FROM Register " +
                 $"INNER JOIN events ON Register.eventID = events.eventID " +
                 $"INNER JOIN venues ON events.venueID = venues.venueID " +
                 $"WHERE Register.userID = {userID} AND events.date >= '{strNow}' AND events.category LIKE '%{txtCategoryS.Text}%';";

            displayEventsDGV(sql, "Search using category error");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            sql = $"SELECT Register.eventID, events.title, venues.name as venue, events.date,  events.category, events.time, events.price,  events.description " +
                 $"FROM Register " +
                 $"INNER JOIN events ON Register.eventID = events.eventID " +
                 $"INNER JOIN venues ON events.venueID = venues.venueID " +
                 $"WHERE Register.userID = {userID} AND events.date < '{strNow}'"; //showing user their event history
            displayEventsDGV(sql, "See past events error");
        }

        public void displayEventsDGV(string sql, string error)
        {
            try
            {
                //putting the name and value of each combox item
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                command = new SqlCommand(sql, connection);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                ds = new DataSet();

                dataAdapter.Fill(ds, "events");

                dgvUpComing.DataSource = ds;
                dgvUpComing.DataMember = "events";

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabControl1_Enter(object sender, EventArgs e)
        {
            //display dgv values 
            displayEventsDGV($"select eventID, title, date, time, price, venues.name, category from events " +
                             $"inner join venues on events.venueID = venues.venueID " +
                             $"where date >= '{strNow}' AND registration = 1;" , "Error displaying events(TapEnter)");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tpRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
