namespace Movie_Databse
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_Time = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_CheckString = new System.Windows.Forms.Button();
            this.btn_ChangeString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Time
            // 
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Location = new System.Drawing.Point(12, 331);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(431, 18);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "THE DATE AND TIME GOES HERE";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(310, 12);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(133, 46);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(12, 12);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(292, 16);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "User Name";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(12, 123);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(292, 16);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(12, 31);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(289, 20);
            this.txt_User.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(12, 142);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(289, 20);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_CheckString
            // 
            this.btn_CheckString.Location = new System.Drawing.Point(16, 285);
            this.btn_CheckString.Name = "btn_CheckString";
            this.btn_CheckString.Size = new System.Drawing.Size(200, 43);
            this.btn_CheckString.TabIndex = 4;
            this.btn_CheckString.Text = "Check Connection String";
            this.btn_CheckString.UseVisualStyleBackColor = true;
            this.btn_CheckString.Click += new System.EventHandler(this.btn_CheckString_Click);
            // 
            // btn_ChangeString
            // 
            this.btn_ChangeString.Location = new System.Drawing.Point(243, 285);
            this.btn_ChangeString.Name = "btn_ChangeString";
            this.btn_ChangeString.Size = new System.Drawing.Size(200, 43);
            this.btn_ChangeString.TabIndex = 5;
            this.btn_ChangeString.Text = "Change Connection String";
            this.btn_ChangeString.UseVisualStyleBackColor = true;
            this.btn_ChangeString.Click += new System.EventHandler(this.btn_ChangeString_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_Databse.Properties.Resources.blockbusted;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 358);
            this.Controls.Add(this.btn_ChangeString);
            this.Controls.Add(this.btn_CheckString);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_CheckString;
        private System.Windows.Forms.Button btn_ChangeString;
    }
}

