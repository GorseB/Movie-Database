using System;
using System.Windows.Forms;

namespace Movie_Databse.MasterMenuDeep
{
    public partial class DemoteAdmin : Form
    {
        public DemoteAdmin()
        {
            InitializeComponent();
            FillDGV();
        }

        private void FillDGV()
        {
            var DB = new Database();
            //clear out the old data
            DGV.DataSource = null;
            try
            {
                DGV.DataSource = DB.FillAdminLogins();
                //pass the datatable data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private new void Click(object sender, DataGridViewCellEventArgs e)
        {
            FillDGV();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV.Rows[e.RowIndex];
                string UserID = null;
                string Username = null;
                UserID = row.Cells["UserID"].Value.ToString();
                Username = row.Cells["Username"].Value.ToString();
                var DB = new Database();
                DB.Demote_Admin(UserID, Username);
                MessageBox.Show("Demoted Admin : " + Username);
                FillDGV();
            }
            else
            {
                MessageBox.Show("No Data Found :(");
            }
        }
    }
}

// (59) This is essentially a God-Killer tool used by either the owner or the database manager to stop someone who has gained admin rights from wrecking your system, and just incase you have to delete all the admins the 
// Master account can launch directly into the admin menu!
// Unit Tests Now.