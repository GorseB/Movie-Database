using System;
using System.Windows.Forms;

namespace Movie_Databse.MenuDeep
{
    public partial class IssueMovies_Movies_ : Form
    {
        public IssueMovies_Movies_()
        {
            InitializeComponent();
            this.Text += "  -  Renting Out For : " + Issue_Movies.FirstName + " " + Issue_Movies.LastName;
            FillDGV();
        }

        public void FillDGV()
        {
            var DB = new Database();
            //clear out the old data
            DGV.DataSource = null;
            try
            {
                DGV.DataSource = DB.FillMoviesWithCopies();
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
                string MovieID = null;
                string Rental_Cost = null;
                string Title = null;
                DataGridViewRow row = DGV.Rows[e.RowIndex];
                MovieID = row.Cells["MovieID"].Value.ToString();
                Rental_Cost = row.Cells["Rental_Cost"].Value.ToString();
                Title = row.Cells["Title"].Value.ToString();
                var DB = new Database();
                DB.RentMovie(MovieID, Issue_Movies.CustID);
                MessageBox.Show("Rented Out : " + Title + " For " + Issue_Movies.FirstName + " " + Issue_Movies.LastName + " For : $" + Rental_Cost);
                FillDGV();
                // (39) This was created by the previous form, and then it rents out the movie for the customer that you selected in the first form and tells you all about it, it is here that i would say my program "Charges" the client for their rentals.
            }
        }
    }
}