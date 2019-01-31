using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Movie_Databse
{
    public partial class MasterMenu : Form
    {
        public static string KeepLoginInfo = null;

        public MasterMenu()
        {
            InitializeComponent();
            KeepLoginInfo = LoginInfo.User.ToString();
            this.Text += "  -  Logged in As : " + LoginInfo.User.ToString();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginInfo.User = null;
            LoginInfo.Password = null;
            LoginInfo.Security = null;
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
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

        private void btn_LaunchAdmin_Click(object sender, EventArgs e)
        {
            LoginInfo.User = KeepLoginInfo;
            DialogResult DR = new DialogResult();
            var AdminMenu = new AdminMenu();
            DR = AdminMenu.ShowDialog();
        }

        private void btn_DemoteAdmin_Click(object sender, EventArgs e)
        {
            DialogResult DR = new DialogResult();
            var DemoteAdmin = new MasterMenuDeep.DemoteAdmin();
            DR = DemoteAdmin.ShowDialog();
        }

        private void MasterMenu_Load(object sender, EventArgs e)
        {
        }
    }
}


// (58) There used to be a bug where you launched the admin menu from here then exited out and launched it again, the this.text wouldn't work because the closing form event triggered on the admin menu causing your globals to erase
// hence the inclusion of a static form var called keeplogoninfo
// MasterMenuDeep Time.