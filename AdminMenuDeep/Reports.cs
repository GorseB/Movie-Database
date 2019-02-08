using System;
using System.Windows.Forms;

namespace Movie_Databse.AdminMenuDeep
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            FillDGVS();
        }

        public void FillDGVS()
        {
            var DB = new Database();
            //clear out the old data
            DGV_Customers.DataSource = null;
            DGV_Movies.DataSource = null;
            try
            {
                DGV_Customers.DataSource = DB.FillCustomersByRenting();
                //pass the datatable data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // (54) Just here to meet criteria
            try
            {
                DGV_Movies.DataSource = DB.FillMoviesByRenting();
                //pass the datatable data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGVS();
        }
    }
}