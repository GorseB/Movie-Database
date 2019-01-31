using System;
using System.Windows.Forms;

namespace Movie_Databse.AdminMenuDeep
{
    public partial class EditMovieCosts : Form
    {
        public EditMovieCosts()
        {
            InitializeComponent();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            if (cbx_Age.SelectedItem != null)
            {
                var DB = new Database();
                DB.ChangeMoviesCosts(cbx_Age.SelectedIndex.ToString(), nud_Value.Value.ToString());
                Close();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Movie Costs Updated");
            }
            else
            {
                MessageBox.Show("Please Input A Value Into The Year Selector!");
            }
            // (51) This fills the criteria for movies older than x years cost y
            // Also allows for some neat user input (Sanitized User Input!)
        }
    }
}