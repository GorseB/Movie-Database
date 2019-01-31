using System;
using System.Windows.Forms;

namespace Movie_Databse.MenuDeep
{
    public partial class UpdateCustomerSecond : Form
    {
        public UpdateCustomerSecond()
        {
            InitializeComponent();
            txt_FirstName.Text = UpdateCustomer.FirstName;
            txt_LastName.Text = UpdateCustomer.LastName;
            txt_Address.Text = UpdateCustomer.Address;
            txt_Phone.Text = UpdateCustomer.Phone;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            var DB = new Database();
            DB.UpdateCustomer(UpdateCustomer.CustID, txt_FirstName.Text, txt_LastName.Text, txt_Address.Text, txt_Phone.Text);
            MessageBox.Show("Update Complete");
            Close();
            DialogResult = DialogResult.OK;
            // (44) Onto AdminMenu.cs!
        }
    }
}