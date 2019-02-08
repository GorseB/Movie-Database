using System;
using System.Windows.Forms;

namespace Movie_Databse.AdminMenuDeep
{
    public partial class Add_Movie : Form
    {
        public Add_Movie()
        {
            InitializeComponent();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            if (txt_Title.Text != "")
            {
                var DB = new Database();
                DB.Add_Movie(txt_Title.Text, nud_Year.Value.ToString(), cbx_Rating.Text, dtp_Released.Value.ToString().Remove(dtp_Released.Value.ToString().Length - 12), nud_Runtime.Value.ToString() + " min", txt_Genre.Text, txt_Director.Text, txt_Writer.Text, txt_Actors.Text, txt_Plot.Text, txt_Language.Text, txt_Country.Text, txt_Awards.Text, nud_Metascore.Value.ToString(), nud_Copies.Value.ToString());
                MessageBox.Show("Movie Added : " + txt_Title.Text);
                Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Title Required");
            }
            // (48) This code would be MUCH more readable if all of those were cast to variables first then used
            // Rushed due to time constraints 
        }
    }
}