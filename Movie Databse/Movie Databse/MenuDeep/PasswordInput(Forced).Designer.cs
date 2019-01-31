namespace Movie_Databse.MenuDeep
{
    partial class PasswordInput_Forced_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordInput_Forced_));
            this.btn_Done = new System.Windows.Forms.Button();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(12, 58);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(202, 23);
            this.btn_Done.TabIndex = 7;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.BackColor = System.Drawing.Color.White;
            this.lbl_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPassword.Location = new System.Drawing.Point(12, 9);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(125, 20);
            this.lbl_NewPassword.TabIndex = 5;
            this.lbl_NewPassword.Text = "New Password";
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(12, 32);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(202, 20);
            this.txt_NewPassword.TabIndex = 6;
            this.txt_NewPassword.UseSystemPasswordChar = true;
            // 
            // PasswordInput_Forced_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_Databse.Properties.Resources.blockbusted;
            this.ClientSize = new System.Drawing.Size(220, 86);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordInput_Forced_";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Input New Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.TextBox txt_NewPassword;
    }
}