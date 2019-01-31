using System;
using System.Windows.Forms;

namespace Movie_Databse.MenuDeep
{
    public partial class Issue_Movies : Form
    {
        public static string CustID = null;
        public static string FirstName = null;
        public static string LastName = null;
        public static string Address = null;
        public static string Phone = null;

        public Issue_Movies()
        {
            InitializeComponent();
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

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV.Rows[e.RowIndex];

                CustID = row.Cells["CustID"].Value.ToString();
                FirstName = row.Cells["FirstName"].Value.ToString();
                LastName = row.Cells["LastName"].Value.ToString();
                Address = row.Cells["Address"].Value.ToString();
                Phone = row.Cells["Phone"].Value.ToString();
                DialogResult DR = new DialogResult();
                var IssueMoviesMovies = new MenuDeep.IssueMovies_Movies_();
                this.Left = -16384;
                Close();
                DialogResult = DialogResult.OK;
                DR = IssueMoviesMovies.ShowDialog();
            }
            // (38) if filling the datatable actually created something, then try to bind it to these variables when you click on a cell, then create another form and close out of this form
            // this.left is in there to fix a little nitpick i had about the way the DialogResult drops out of itself, comment it out to see for yourself.
        }
    }
}