using System;
using System.Windows.Forms;

namespace Movie_Databse.AdminMenuDeep
{
    public partial class Elevate : Form
    {
        public Elevate()
        {
            InitializeComponent();
            FillDGV();
            // (52) This Form Should be Called Promote along with Terminate and Demote, for readabilities sake, alas.
        }

        private void FillDGV()
        {
            var DB = new Database();
            //clear out the old data
            DGV.DataSource = null;
            try
            {
                DGV.DataSource = DB.FillLogins();
                //pass the datatable data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private new void Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV.Rows[e.RowIndex];
                string UserID = null;
                string Username = null;
                UserID = row.Cells["UserID"].Value.ToString();
                Username = row.Cells["Username"].Value.ToString();
                var DB = new Database();
                if (!Program.IsDelete)
                {
                    DB.Elevate(UserID, Username);
                    MessageBox.Show("Elevated Employee : " + Username);
                }
                else
                {
                    DB.TerminateEmployee(UserID, Username);
                    MessageBox.Show("Terminated Employee : " + Username);
                }
                FillDGV();
                //  (53) Either Promotes or Terminates based on the global bool, to save on space.
            }
            else
            {
                MessageBox.Show("No Data Found :(");
            }
        }

        private new void Closing(Object Sender, FormClosingEventArgs e)
        {
            Program.IsDelete = false;
        }
    }
}