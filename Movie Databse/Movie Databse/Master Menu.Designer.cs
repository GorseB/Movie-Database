namespace Movie_Databse
{
    partial class MasterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterMenu));
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btn_DemoteAdmin = new System.Windows.Forms.Button();
            this.btn_LaunchAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(12, 90);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(366, 33);
            this.btn_ChangePassword.TabIndex = 3;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btn_DemoteAdmin
            // 
            this.btn_DemoteAdmin.Location = new System.Drawing.Point(12, 51);
            this.btn_DemoteAdmin.Name = "btn_DemoteAdmin";
            this.btn_DemoteAdmin.Size = new System.Drawing.Size(366, 33);
            this.btn_DemoteAdmin.TabIndex = 2;
            this.btn_DemoteAdmin.Text = "Demote Admin";
            this.btn_DemoteAdmin.UseVisualStyleBackColor = true;
            this.btn_DemoteAdmin.Click += new System.EventHandler(this.btn_DemoteAdmin_Click);
            // 
            // btn_LaunchAdmin
            // 
            this.btn_LaunchAdmin.Location = new System.Drawing.Point(12, 12);
            this.btn_LaunchAdmin.Name = "btn_LaunchAdmin";
            this.btn_LaunchAdmin.Size = new System.Drawing.Size(366, 33);
            this.btn_LaunchAdmin.TabIndex = 1;
            this.btn_LaunchAdmin.Text = "Launch Admin Menu";
            this.btn_LaunchAdmin.UseVisualStyleBackColor = true;
            this.btn_LaunchAdmin.Click += new System.EventHandler(this.btn_LaunchAdmin_Click);
            // 
            // MasterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_Databse.Properties.Resources.blockbusted;
            this.ClientSize = new System.Drawing.Size(390, 142);
            this.Controls.Add(this.btn_LaunchAdmin);
            this.Controls.Add(this.btn_DemoteAdmin);
            this.Controls.Add(this.btn_ChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Master Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.MasterMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btn_DemoteAdmin;
        private System.Windows.Forms.Button btn_LaunchAdmin;
    }
}