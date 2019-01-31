using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Movie_Databse
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            this.Text += "  -  Logged in As : " + LoginInfo.User.ToString();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginInfo.User = null;
            LoginInfo.Password = null;
            LoginInfo.Security = null;
        }

        private void btn_ChangePassword_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Password_Input = new PasswordInput();
            DR = Password_Input.ShowDialog();
            if (DR != DialogResult.Cancel)
            {
                var DB = new Database();
                MD5 Hash = MD5.Create();
                string str_Username = LoginInfo.User;
                string str_NewPassword = GetHash(Hash, LoginInfo.NewPassword);
                DB.ChangePassword(str_Username, str_NewPassword);
                MessageBox.Show("Password Change Complete");
                LoginInfo.NewPassword = null;
            }
        }

        private static string GetHash(MD5 Hash, string Input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] Data = Hash.ComputeHash(Encoding.UTF8.GetBytes(Input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder SBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < Data.Length; i++)
            {
                SBuilder.Append(Data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return SBuilder.ToString();
        }
        // (45) all repeated code above.

        private void btn_ShowAllMovies_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var ShowAllMovies = new AdminMenuDeep.ShowAllMovies();
            DR = ShowAllMovies.ShowDialog();
        }

        private void btn_EditMovieCosts_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var EditMovies = new AdminMenuDeep.EditMovieCosts();
            DR = EditMovies.ShowDialog();
        }

        private void btn_ViewReports_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Reports = new AdminMenuDeep.Reports();
            DR = Reports.ShowDialog();
        }

        private void btn_DeleteCustomer_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var DeleteCustomer = new AdminMenuDeep.DeleteCustomer();
            DR = DeleteCustomer.ShowDialog();
        }

        private void btn_CreateEmployee_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var CreateEmployee = new AdminMenuDeep.Create_Employee();
            DR = CreateEmployee.ShowDialog();
        }

        private void btn_Privileges_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var Elevate = new AdminMenuDeep.Elevate();
            DR = Elevate.ShowDialog();
            Program.IsDelete = false;
        }

        private void btn_DeleteEmployee_Click(object sender, System.EventArgs e)
        {
            // (46) using the global bool's 
            Program.IsDelete = true;
            DialogResult DR = new DialogResult();
            var Elevate = new AdminMenuDeep.Elevate();
            DR = Elevate.ShowDialog();
        }

        private void btn_DeleteMovie_Click(object sender, System.EventArgs e)
        {
            Program.IsDeleteMovie = true;
            DialogResult DR = new DialogResult();
            var UDMovie = new AdminMenuDeep.Update_Delete_Movie();
            DR = UDMovie.ShowDialog();
        }

        private void btn_AddMovie_Click(object sender, System.EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var AddMovie = new AdminMenuDeep.Add_Movie();
            DR = AddMovie.ShowDialog();
        }

        private void btn_UpdateMovie_Click(object sender, System.EventArgs e)
        {
            Program.IsDeleteMovie = false;
            DialogResult DR = new DialogResult();
            var UDMovie = new AdminMenuDeep.Update_Delete_Movie();
            DR = UDMovie.ShowDialog();
        }
    }
}

// (47) Onto AdminMenuDeep :D