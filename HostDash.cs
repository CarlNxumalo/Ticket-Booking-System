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
    public partial class HostDash : Form
    {
        public HostDash()
        {
            InitializeComponent();
        }
        //public varibles  and objects
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        DataSet ds;
        string sql = "";
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventConnectDB.mdf;Integrated Security=True";

        public string userID = "", password = ""; 
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbVenuesPopulate()
        {
            //putting the name and value of each combox item
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            sql = $"select venueID, name from venues";
            command = new SqlCommand(sql, connection);
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            ds = new DataSet();

            dataAdapter.Fill(ds, "venues");

            cmbCVenue.DataSource = ds.Tables["venues"];
            cmbCVenue.DisplayMember = "name";

            connection.Close();
            
        }

        private void HostDash_Load(object sender, EventArgs e)
        {
            
            //populate the combobox for the venues
            try
            {
                connection = new SqlConnection(conStr);
                connection.Open();
                connection.Close();

                //populate the venues cmb control
                cmbVenuesPopulate();

                //pupulate combobox with event IDs for their events
                showCMBAndDGV();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sign up user Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showCMBAndDGV() 
        {
            try
            {
                //putting the name and value of each combox item
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                //inner join to get venue name from venue table
                //only showing the EventID's the Host is in control of.
                sql=$"select eventID, venues.name, title, description, date, time, price, category, registration " +
                    $"from events "+
                    $"inner join venues on events.venueID = venues.venueID " +
                    $"where events.userID = {userID};";
                command = new SqlCommand(sql, connection);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                ds = new DataSet();

                dataAdapter.Fill(ds, "events");

                //create/edit tab
                cmbTheirEvents.DataSource = ds.Tables["events"];
                cmbTheirEvents.DisplayMember = "eventID";

                //cancel event tab cmb
                cmbCancelEvent.DataSource = ds.Tables["events"];
                cmbCancelEvent.DisplayMember = "eventID";

                //show pariticipants cmb events
                cmbSeeParticipants.DataSource = ds.Tables["events"];
                cmbSeeParticipants.DisplayMember = "eventID";

                //dgv control
                dgvTheirEvents.DataSource = ds;
                dgvTheirEvents.DataMember = "events";

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Fill Hosts EventID CMB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbCVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void insertEvent()
        {
            try
            {
                //check if registration is open
                int register = 1;
                if (cbCRegistration.Checked)
                {
                    register = 0;
                }

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string[] date = dtpCDate.Value.ToString().Split(' '); // taking away the time part of the date to be short date
                sql = $"insert into events values({userID}, {(cmbCVenue.SelectedIndex+1)}, '{txtCEvent.Text}', '{txtCDescription.Text}', '{date[0]}', '{txtCTime.Text}', {txtCPrice.Text}, '{txtCCategory.Text}', {register})";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Event Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(cmbTheirEvents.SelectedIndex !=-1)// Making sure user selected something
                {
                    if(validInput()) //other input controls
                    {
                        //update database 

                        //check if registration is open
                        int register = 1;
                        if (cbCRegistration.Checked)
                        {
                            register = 0;
                        }

                        string[] date = dtpCDate.Value.ToString().Split(' '); //excluding the time part just short date is used
                        sql = $"update events set title = '{txtCEvent.Text}', venueID = {(cmbCVenue.SelectedIndex + 1)}, description= '{txtCDescription.Text}', date= '{date[0]}', time = '{txtCTime.Text}', price = {txtCPrice.Text}, category='{txtCCategory.Text}', registration={register} " +
                              $"where eventID={cmbTheirEvents.Text}";
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();

                        //refresh DGV
                        showCMBAndDGV();

                        connection.Close();
                    }
                }
                else
                {
                    epHostDash.SetError(cmbTheirEvents, "Select an Event ID");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Create event Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validInput()
        {
            //validate data inputs from user before putting into database
            //providing user with nice error messages
            if (txtCEvent.Text != "")
            {
                if (txtCDescription.Text != "")
                {
                    if (dtpCDate.Text != "")
                    {
                        if (txtCTime.Text != "")
                        {
                            if (cmbCVenue.SelectedIndex != -1)
                            {

                                int tempPrice = 0;
                                if (txtCPrice.Text != "" && int.TryParse(txtCPrice.Text, out tempPrice))
                                {
                                    if (txtCCategory.Text != "")
                                    {
                                        //now we can insert or edit data
                                        return true;
                                    }
                                    else
                                    {
                                        epHostDash.SetError(txtCCategory, "Enter category");
                                    }
                                }
                                else
                                {
                                    epHostDash.SetError(txtCPrice, "Enter valid price(int)");
                                }
                            }
                            else
                            {
                                epHostDash.SetError(cmbCVenue, "select venue");
                            }
                        }
                        else
                        {
                            epHostDash.SetError(txtCTime, "Enter time");
                        }
                    }
                    else
                    {
                        epHostDash.SetError(dtpCDate, "Enter date");
                    }
                }
                else
                {
                    epHostDash.SetError(txtCDescription, "Enter name");
                }
            }
            else
            {
                epHostDash.SetError(txtCEvent, "Enter name");
            }
            return false;
        }

        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            //deleting event
            try
            {
                //get the selected ID in the combobox
                sql = $"delete from events where eventID = {cmbCancelEvent.Text}";
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                //reload dgv
                showCMBAndDGV();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "Cancel Event Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvTheirEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeeParticipants_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbSeeParticipants.SelectedIndex!=1 && cmbSeeParticipants.Text!="")
                {
                    //showing the participants for a specific event 

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    sql = $"select Register.userID, users.firstName, users.lastName from Register " +
                          $"inner join users on Register.userID = users.userID " +
                          $"where Register.eventID = {cmbSeeParticipants.Text}";
                    command = new SqlCommand(sql, connection);
                    dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = command;
                    ds = new DataSet();
                    dataAdapter.Fill(ds, "Register");

                    //dgv control with participants
                    dgvTheirEvents.DataSource = ds;
                    dgvTheirEvents.DataMember = "Register";
                    connection.Close();
                }
                else
                {
                    epHostDash.SetError(cmbSeeParticipants, "Select Event ID/No Events hosted by you");
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "See Participants Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpParticipants_Enter(object sender, EventArgs e)
        {
            /*display the users to the host
            try
            {
                
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sql = $"select Register.userID, users.firstName, users.lastName from Register " +
                      $"inner join users on Register.userID = users.userID " +
                      $"where Register.eventID = {cmbSeeParticipants.Text}";
                command = new SqlCommand(sql, connection);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                ds = new DataSet();
                dataAdapter.Fill(ds, "Register");

                //dgv control with participants
                dgvTheirEvents.DataSource = ds;
                dgvTheirEvents.DataMember = "Register";
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Participants show Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void tabPeople_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            //Counts the number of participants attenting your event
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sql = $"select count(*) from Register " +
                      $"where eventID = {cmbSeeParticipants.Text}";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                if(dataReader.Read())
                {
                    MessageBox.Show("EventID("+cmbSeeParticipants.Text+")\nTotal participants: "+dataReader.GetValue(0), "Tracking Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Create event Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreatEvent_Click(object sender, EventArgs e)
        {
            try
            {
               if(validInput())
                {
                    insertEvent();
                    showCMBAndDGV();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Create event Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
