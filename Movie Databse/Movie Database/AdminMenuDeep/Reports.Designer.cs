namespace Movie_Databse.AdminMenuDeep
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.tbc_Reports = new System.Windows.Forms.TabControl();
            this.tbp_Borrow = new System.Windows.Forms.TabPage();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.tbp_Rented = new System.Windows.Forms.TabPage();
            this.DGV_Movies = new System.Windows.Forms.DataGridView();
            this.btn_Done = new System.Windows.Forms.Button();
            this.tbc_Reports.SuspendLayout();
            this.tbp_Borrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.tbp_Rented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movies)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_Reports
            // 
            this.tbc_Reports.Controls.Add(this.tbp_Borrow);
            this.tbc_Reports.Controls.Add(this.tbp_Rented);
            this.tbc_Reports.Location = new System.Drawing.Point(12, 12);
            this.tbc_Reports.Name = "tbc_Reports";
            this.tbc_Reports.SelectedIndex = 0;
            this.tbc_Reports.Size = new System.Drawing.Size(1209, 519);
            this.tbc_Reports.TabIndex = 0;
            this.tbc_Reports.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // tbp_Borrow
            // 
            this.tbp_Borrow.Controls.Add(this.DGV_Customers);
            this.tbp_Borrow.Location = new System.Drawing.Point(4, 22);
            this.tbp_Borrow.Name = "tbp_Borrow";
            this.tbp_Borrow.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Borrow.Size = new System.Drawing.Size(1201, 493);
            this.tbp_Borrow.TabIndex = 0;
            this.tbp_Borrow.Text = "Customers";
            this.tbp_Borrow.ToolTipText = "Who Borrows The Most Movies";
            this.tbp_Borrow.UseVisualStyleBackColor = true;
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.AllowUserToAddRows = false;
            this.DGV_Customers.AllowUserToDeleteRows = false;
            this.DGV_Customers.AllowUserToOrderColumns = true;
            this.DGV_Customers.AllowUserToResizeColumns = false;
            this.DGV_Customers.AllowUserToResizeRows = false;
            this.DGV_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Customers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Customers.Location = new System.Drawing.Point(3, 3);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.ReadOnly = true;
            this.DGV_Customers.Size = new System.Drawing.Size(1195, 487);
            this.DGV_Customers.TabIndex = 0;
            // 
            // tbp_Rented
            // 
            this.tbp_Rented.Controls.Add(this.DGV_Movies);
            this.tbp_Rented.Location = new System.Drawing.Point(4, 22);
            this.tbp_Rented.Name = "tbp_Rented";
            this.tbp_Rented.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Rented.Size = new System.Drawing.Size(1201, 493);
            this.tbp_Rented.TabIndex = 1;
            this.tbp_Rented.Text = "Movies";
            this.tbp_Rented.ToolTipText = "The Highest Rented Out Movies";
            this.tbp_Rented.UseVisualStyleBackColor = true;
            // 
            // DGV_Movies
            // 
            this.DGV_Movies.AllowUserToAddRows = false;
            this.DGV_Movies.AllowUserToDeleteRows = false;
            this.DGV_Movies.AllowUserToOrderColumns = true;
            this.DGV_Movies.AllowUserToResizeColumns = false;
            this.DGV_Movies.AllowUserToResizeRows = false;
            this.DGV_Movies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Movies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Movies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Movies.Location = new System.Drawing.Point(3, 3);
            this.DGV_Movies.Name = "DGV_Movies";
            this.DGV_Movies.ReadOnly = true;
            this.DGV_Movies.Size = new System.Drawing.Size(1195, 487);
            this.DGV_Movies.TabIndex = 1;
            // 
            // btn_Done
            // 
            this.btn_Done.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Done.Location = new System.Drawing.Point(16, 537);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(1209, 27);
            this.btn_Done.TabIndex = 13;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_Databse.Properties.Resources.blockbusted;
            this.ClientSize = new System.Drawing.Size(1233, 567);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.tbc_Reports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reports";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Reports";
            this.tbc_Reports.ResumeLayout(false);
            this.tbp_Borrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.tbp_Rented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Reports;
        private System.Windows.Forms.TabPage tbp_Borrow;
        private System.Windows.Forms.TabPage tbp_Rented;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.DataGridView DGV_Customers;
        private System.Windows.Forms.DataGridView DGV_Movies;
    }
}