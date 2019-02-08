using System;
using System.Windows.Forms;

namespace Movie_Databse.AdminMenuDeep
{
    public partial class Create_Employee : Form
    {
        public Create_Employee()
        {
            InitializeComponent();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "")
            {
                var DB = new Database();
                DB.AddEmployee(txt_Name.Text);
                MessageBox.Show("Employee Created!");
                Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please Input A Name");
            }
            // (49) Simple Code
        }
    }
}