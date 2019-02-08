using System;
using System.Windows.Forms;

namespace Movie_Databse.MenuDeep
{
    public partial class PasswordInput_Forced_ : Form
    {
        public PasswordInput_Forced_()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txt_NewPassword.Text != "")
            {
                LoginInfo.NewPassword = txt_NewPassword.Text;
                Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please Input A New Password!");
            }
            // (41) No more Missed Passwords
        }
    }
}