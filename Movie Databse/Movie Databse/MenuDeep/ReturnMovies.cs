using System;
using System.Windows.Forms;

namespace Movie_Databse.MenuDeep
{
    public partial class ReturnMovies : Form
    {
        public ReturnMovies()
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
                DGV.DataSource = DB.FillMoviesOut();
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
                string RMID = null;
                DateTime DateRented = new DateTime();
                string Title = null;
                RMID = row.Cells["RMID"].Value.ToString();
                DateRented = Convert.ToDateTime(row.Cells["DateRented"].Value);
                Title = row.Cells["Title"].Value.ToString();
                var DB = new Database();
                DB.ReturnMovie(RMID, DateRented, Title);
                FillDGV();
                // (42) Very Simple Code
            }
        }
    }
}