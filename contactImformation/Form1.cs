using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactImformation
{
    public partial class Form1 : Form
    {
        ContactDB_pansiluEntities1 db= new ContactDB_pansiluEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tblcontacts.ToList();
            try
            {
                using(ContactDB_pansiluEntities1 db =new ContactDB_pansiluEntities1 ()) 
                {
                    cbcountry.DataSource = db.tblCountries.ToList();
                    cbcountry.ValueMember = "CountryID";
                    cbcountry.DisplayMember = "Country";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void clear()
        {
            txtname.Text = txttelephone.Text = txtmobile.Text = txtemail.Text = "";
        }

        private void cbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {

        }
    }
}
