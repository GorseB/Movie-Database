using System;
using System.Windows.Forms;

namespace Movie_Databse.AdminMenuDeep
{
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
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
                DGV.DataSource = DB.FillDGVCustomer();
                //pass the datatable data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV.Rows[e.RowIndex];
                string CustID = null;
                string FirstName = null;
                FirstName = row.Cells["FirstName"].Value.ToString();
                CustID = row.Cells["CustID"].Value.ToString();
                var DB = new Database();
                DB.DeleteCustomer(CustID);
                MessageBox.Show("Deleted Customer : " + FirstName);
            }
            FillDGV();
            // (50) Re-Filling the Data Grid View at the end there so that the table actually updates after you alter it, only thing about this method i can talk about.
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
        }
    }
}