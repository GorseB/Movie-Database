using System;
using System.Windows.Forms;

namespace Movie_Databse.AdminMenuDeep
{
    public partial class ShowAllMovies : Form
    {
        public ShowAllMovies()
        {
            InitializeComponent();
            FillDGV();
        }

        public void FillDGV()
        {
            var DB = new Database();
            //clear out the old data
            DGV.DataSource = null;
            try
            {
                DGV.DataSource = DB.Fill();
                //pass the datatable data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // (55) SELECT * FROM Movies
        }
    }
}