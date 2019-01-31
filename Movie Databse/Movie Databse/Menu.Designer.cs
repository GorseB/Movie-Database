namespace Movie_Databse
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_CreateCustomer = new System.Windows.Forms.Button();
            this.btn_UpdateCustomer = new System.Windows.Forms.Button();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateCustomer
            // 
            this.btn_CreateCustomer.Location = new System.Drawing.Point(12, 12);
            this.btn_CreateCustomer.Name = "btn_CreateCustomer";
            this.btn_CreateCustomer.Size = new System.Drawing.Size(174, 33);
            this.btn_CreateCustomer.TabIndex = 0;
            this.btn_CreateCustomer.Text = "Add Customer";
            this.btn_CreateCustomer.UseVisualStyleBackColor = true;
            this.btn_CreateCustomer.Click += new System.EventHandler(this.btn_CreateCustomer_Click);
            // 
            // btn_UpdateCustomer
            // 
            this.btn_UpdateCustomer.Location = new System.Drawing.Point(12, 51);
            this.btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            this.btn_UpdateCustomer.Size = new System.Drawing.Size(174, 33);
            this.btn_UpdateCustomer.TabIndex = 1;
            this.btn_UpdateCustomer.Text = "Update Customer";
            this.btn_UpdateCustomer.UseVisualStyleBackColor = true;
            this.btn_UpdateCustomer.Click += new System.EventHandler(this.btn_UpdateCustomer_Click);
            // 
            // btn_Sell
            // 
            this.btn_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sell.Location = new System.Drawing.Point(192, 12);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(348, 72);
            this.btn_Sell.TabIndex = 2;
            this.btn_Sell.Text = "Issue Movies";
            this.btn_Sell.UseVisualStyleBackColor = true;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(12, 90);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(174, 33);
            this.btn_Return.TabIndex = 3;
            this.btn_Return.Text = "Return Movies";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(192, 90);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(348, 33);
            this.btn_ChangePassword.TabIndex = 4;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_Databse.Properties.Resources.blockbusted;
            this.ClientSize = new System.Drawing.Size(549, 132);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.btn_UpdateCustomer);
            this.Controls.Add(this.btn_CreateCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateCustomer;
        private System.Windows.Forms.Button btn_UpdateCustomer;
        private System.Windows.Forms.Button btn_Sell;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_ChangePassword;
    }
}