using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Movie_Databse
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.Text += "  -  Logged in As : " + LoginInfo.User.ToString();
            // (33) The First of the three menu's to be created and the second most populated, the code above is used in all menu's to give them a nice look, nothing more than a little addition like the clock that i feel makes the program come alive a little bit
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginInfo.User = null;
            LoginInfo.Password = null;
            LoginInfo.Security = null;
            // (34) This code sets LoginInfo to null when the form is closed, so that you can't get in by logging in with blank input boxes (OR just a username) to a station someone has recently logged out of
            // This code reappears in all three menu
        }

        private void btn_ChangePassword_Click(object sender, System.EventArgs e)
        {
            // (35) Another section of reappearing code, this section of code shows up a whopping 4 times throughout the program, so i will go through it in detail here and pass by it in other sections of the program to reduce the amount of 
            // Green in the project.
            DialogResult DR = new DialogResult();
            // Why bind DR every time you create a new form when sometimes you don't use it?
            // This is so that you future proof your code, when someone else comes in and reads through this code and has to work on it
            // that person should have an easier time when variables are declared and assigned. for example when i used DR.Result earlier on in Login.cs for the "FORCECHANGEPASSWORD" thing
            var Password_Input = new PasswordInput();
            // Create An Instance of the PasswordInput Form
            DR = Password_Input.ShowDialog();
            // Show it as a DialogBox (it is set to a dialog box by default (in designer)), but you say Dialog to prevent errors and future proof code
            if (DR != DialogResult.Cancel)
                // if you didn't cancel out of the form
            {
                var DB = new Database();
                MD5 Hash = MD5.Create();
                string str_Username = LoginInfo.User;
                string str_NewPassword = GetHash(Hash, LoginInfo.NewPassword);
                DB.ChangePassword(str_Username, str_NewPassword);
                MessageBox.Show("Password Change Complete");
                LoginInfo.NewPassword = null;
                //change the password and clear out LoginInfo to reduce bugs
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

        private void btn_CreateCustomer_Click(object sender, EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var AddCustomer = new AddCustomer();
            DR = AddCustomer.ShowDialog();
        }

        private void btn_UpdateCustomer_Click(object sender, EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var UpdateCustomer = new UpdateCustomer();
            DR = UpdateCustomer.ShowDialog();
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var IssueMovies = new MenuDeep.Issue_Movies();
            DR = IssueMovies.ShowDialog();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var ReturnMovies = new MenuDeep.ReturnMovies();
            DR = ReturnMovies.ShowDialog();
        }
    }
}
// (36) All done, onto MenuDeep in order from top to bottom