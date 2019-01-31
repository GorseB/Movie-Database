using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Movie_Databse
{
    public partial class PasswordInput : Form
    {
        public PasswordInput()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MD5 Hash = MD5.Create();
            if (GetHash(Hash, txt_OldPassword.Text) == LoginInfo.Password.ToString())
            {
                LoginInfo.NewPassword = txt_NewPassword.Text;
                Close();
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Old Password Incorrect!");
            // (40) This form allows the user to input "" as their password, but the forced password form doesn't, 
            // i don't really see a reason why not having a password as a password is something someone would want, but i couldn't make up my mind as to how much i wanted to enforce restrictions on user passwords 
            // so i left it the way it is, i feel like this way the user would have to click on "Change Password" then input their old password, then click "ok" to actually make their password nothing, in which case its more than 
            // likely something they want to do, whereas having it on the forced password form seems a little lackluster as i use tab control to pass through the forms quickly and i can see a new user typing stuff in and pressing "TAB" "ENTER" and 
            // then going "Wait what password?"
            // Thats because that exact scenario happened to me while i was testing, which led to that restriction on the Forced Password form. 
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
    }
}