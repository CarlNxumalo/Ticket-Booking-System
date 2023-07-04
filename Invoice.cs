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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            lblPurchaseDate.Text = "Registration Date: "+DateTime.Now.ToString("d");
        }
    }
}
