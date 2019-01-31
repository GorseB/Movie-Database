using System;
using System.Windows.Forms;

namespace Movie_Databse
{
    public partial class UpdateCustomer : Form
    {
        public static string CustID = null;
        public static string FirstName = null;
        public static string LastName = null;
        public static string Address = null;
        public static string Phone = null;

        public UpdateCustomer()
        {
            InitializeComponent();
            var DB = new Database();
            //clear out the old data
            DGV.DataSource = null;
            try
            {
                DGV.DataSource = DB.FillDGVCustomer();
                //pass the datatable data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV.Rows[e.RowIndex];

                CustID = row.Cells["CustID"].Value.ToString();
                FirstName = row.Cells["FirstName"].Value.ToString();
                LastName = row.Cells["LastName"].Value.ToString();
                Address = row.Cells["Address"].Value.ToString();
                Phone = row.Cells["Phone"].Value.ToString();
                DialogResult DR = new DialogResult();
                var UpdateCustomerSecond = new MenuDeep.UpdateCustomerSecond();
                DR = UpdateCustomerSecond.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    Close();
                    DialogResult = DialogResult.OK;
                }
            }
            // (43) More Simple Code, also the designer generated methods that cause errors when you remove them are around.
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}