using System;
using System.Windows.Forms;

namespace Movie_Databse.AdminMenuDeep
{
    public partial class Update_Delete_Movie : Form
    {
        public Update_Delete_Movie()
        {
            InitializeComponent();
            FillDGV();
            // (57) Big Chunk of code incoming, will keep it all as 57 for ease of typing
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
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDGV();
            if (e.RowIndex >= 0)
            {
                string MovieID = null;
                string Rental_Cost = null;
                string Title = null;
                DataGridViewRow row = DGV.Rows[e.RowIndex];
                MovieID = row.Cells["MovieID"].Value.ToString();
                Rental_Cost = row.Cells["Rental_Cost"].Value.ToString();
                Title = row.Cells["Title"].Value.ToString();
                // Now Grab The Update Variables
                string Year = null;
                string Rating = null;
                string Released = null;
                string Runtime = null;
                string Genre = null;
                string Director = null;
                string Writer = null;
                string Actors = null;
                string Plot = null;
                string Language = null;
                string Country = null;
                string Awards = null;
                string Metascore = null;
                string Copies = null;
                Year = row.Cells["Year"].Value.ToString();
                Rating = row.Cells["Rating"].Value.ToString();
                Released = row.Cells["Released"].Value.ToString();
                Runtime = row.Cells["Runtime"].Value.ToString();
                Genre = row.Cells["Genre"].Value.ToString();
                Director = row.Cells["Director"].Value.ToString();
                Writer = row.Cells["Writer"].Value.ToString();
                Actors = row.Cells["Actors"].Value.ToString();
                Plot = row.Cells["Plot"].Value.ToString();
                Language = row.Cells["Language"].Value.ToString();
                Country = row.Cells["Country"].Value.ToString();
                Awards = row.Cells["Awards"].Value.ToString();
                Metascore = row.Cells["Metascore"].Value.ToString();
                Copies = row.Cells["Copies"].Value.ToString();
                // just casting to variables here so that they can be used later on
                var DB = new Database();
                if (Program.IsDeleteMovie)
                {
                    DB.DeleteMovie(MovieID);
                    MessageBox.Show("Deleted Movie : " + Title);
                        // if we got sent here to delete, then ignore the rest and we can go home.
                }
                else
                {
                    // oh well
                    DialogResult DR = new DialogResult();
                    var UpdateMovie = new AdminMenuDeep.Update_Movie();
                    UpdateMovie.lbl_MovieID.Text = "Movie ID : " + MovieID;
                    UpdateMovie.txt_Title.Text = Title;
                    UpdateMovie.lbl_HiddenMovieID.Tag = MovieID;
                    UpdateMovie.cbx_Rating.Text = Rating;
                    if (Metascore == "" || Metascore == "N/A")
                    {
                        Metascore = "0";
                    }
                    if (Copies == "")
                    {
                        Copies = "0";
                    }
                    try
                    {
                        UpdateMovie.nud_Year.Value = Convert.ToInt32(Year);
                    }
                    catch (Exception mes)
                    {
                        MessageBox.Show("Conversion Failed (Year): " + mes.Message); // all these catches are here because of the way the database was originally designed, along with the improvements i made to it using a separate program.
                        // Most of them will never trigger and some of them will sometimes trigger but they make the code easy to debug and also future proof
                        // i cant talk for the readability of this section of code though.
                    }
                    try
                    {
                        UpdateMovie.dtp_Released.Value = Convert.ToDateTime(Released);
                    }
                    catch (Exception mes2)
                    {
                        MessageBox.Show("Conversion Failed (Released)  : " + mes2.Message);
                    }
                    try
                    {
                        UpdateMovie.nud_Runtime.Value = Convert.ToInt32(Runtime.Remove(Runtime.Length - 4));
                    }
                    catch (Exception mes)
                    {
                        MessageBox.Show("Conversion Failed (Runtime) : " + mes.Message);
                    }
                    UpdateMovie.txt_Genre.Text = Genre;
                    UpdateMovie.txt_Director.Text = Director;
                    UpdateMovie.txt_Writer.Text = Writer;
                    UpdateMovie.txt_Actors.Text = Actors;
                    UpdateMovie.txt_Plot.Text = Plot;
                    UpdateMovie.txt_Language.Text = Language;
                    UpdateMovie.txt_Country.Text = Country;
                    UpdateMovie.txt_Awards.Text = Awards;
                    // this should be up there more ^
                    try
                    {
                        UpdateMovie.nud_Metascore.Value = Convert.ToInt32(Metascore);
                    }
                    catch (Exception mes)
                    {
                        MessageBox.Show("Conversion Failed (Metascore) : " + mes.Message);
                    }
                    try
                    {
                        UpdateMovie.nud_Copies.Value = Convert.ToInt32(Copies);
                    }
                    catch (Exception mes)
                    {
                        MessageBox.Show("Conversion Failed (Copies) : " + mes.Message);
                    }
                    DR = UpdateMovie.ShowDialog();
                }
                FillDGV();
            }
            else
            {
                MessageBox.Show("No Data Found :(");
            }
        }

        private new void Closing(Object Sender, FormClosingEventArgs e)
        {
            Program.IsDeleteMovie = false; // ressetting the bool to prevent bugs
        }
    }
}

// (58) Onto MasterMenu.cs !