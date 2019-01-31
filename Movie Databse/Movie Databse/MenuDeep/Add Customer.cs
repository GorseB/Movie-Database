using System;
using System.Windows.Forms;

namespace Movie_Databse
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            var DB = new Database();
            DB.AddCustomer(txt_FirstName.Text, txt_LastName.Text, txt_Address.Text, txt_Phone.Text);
            MessageBox.Show("Insert Completed");
            Close();
            DialogResult = DialogResult.OK;
            // (37) Extremely Simple Customer Inset
        }
    }
}