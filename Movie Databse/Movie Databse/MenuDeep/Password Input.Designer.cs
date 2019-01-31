namespace Movie_Databse
{
    partial class PasswordInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordInput));
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.lbl_OldPassword = new System.Windows.Forms.Label();
            this.txt_OldPassword = new System.Windows.Forms.TextBox();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(12, 78);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(202, 20);
            this.txt_NewPassword.TabIndex = 3;
            this.txt_NewPassword.UseSystemPasswordChar = true;
            // 
            // lbl_OldPassword
            // 
            this.lbl_OldPassword.AutoSize = true;
            this.lbl_OldPassword.BackColor = System.Drawing.Color.White;
            this.lbl_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OldPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_OldPassword.Location = new System.Drawing.Point(8, 9);
            this.lbl_OldPassword.Name = "lbl_OldPassword";
            this.lbl_OldPassword.Size = new System.Drawing.Size(151, 20);
            this.lbl_OldPassword.TabIndex = 0;
            this.lbl_OldPassword.Text = "Current Password";
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.Location = new System.Drawing.Point(12, 32);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.Size = new System.Drawing.Size(202, 20);
            this.txt_OldPassword.TabIndex = 1;
            this.txt_OldPassword.UseSystemPasswordChar = true;
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.BackColor = System.Drawing.Color.White;
            this.lbl_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPassword.Location = new System.Drawing.Point(12, 55);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(125, 20);
            this.lbl_NewPassword.TabIndex = 2;
            this.lbl_NewPassword.Text = "New Password";
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(12, 104);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(202, 23);
            this.btn_Done.TabIndex = 4;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(12, 133);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(202, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // PasswordInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Movie_Databse.Properties.Resources.blockbusted;
            this.ClientSize = new System.Drawing.Size(220, 175);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.txt_OldPassword);
            this.Controls.Add(this.lbl_OldPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " Please Input Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.Label lbl_OldPassword;
        private System.Windows.Forms.TextBox txt_OldPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Button btn_Cancel;
    }
}