namespace Movie_Databse.AdminMenuDeep
{
    partial class EditMovieCosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMovieCosts));
            this.cbx_Age = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.nud_Value = new System.Windows.Forms.NumericUpDown();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.btn_Done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Age
            // 
            this.cbx_Age.DisplayMember = "0";
            this.cbx_Age.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Age.Items.AddRange(new object[] {
            "ALL",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbx_Age.Location = new System.Drawing.Point(12, 37);
            this.cbx_Age.Name = "cbx_Age";
            this.cbx_Age.Size = new System.Drawing.Size(208, 21);
            this.cbx_Age.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(12, 144);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(261, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(12, 9);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(266, 25);
            this.lbl_Age.TabIndex = 10;
            this.lbl_Age.Text = "Select Age (Older Than)";
            // 
            // nud_Value
            // 
            this.nud_Value.DecimalPlaces = 2;
            this.nud_Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_Value.Location = new System.Drawing.Point(12, 89);
            this.nud_Value.Name = "nud_Value";
            this.nud_Value.Size = new System.Drawing.Size(208, 20);
            this.nud_Value.TabIndex = 1;
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Value.Location = new System.Drawing.Point(12, 61);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(181, 25);
            this.lbl_Value.TabIndex = 12;
            this.lbl_Value.Text = "Select Value ($)";
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(12, 115);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(261, 23);
            this.btn_Done.TabIndex = 2;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // EditMovieCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_Databse.Properties.Resources.blockbusted;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.nud_Value);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cbx_Age);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMovieCosts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit Movie Costs";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Age;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.NumericUpDown nud_Value;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Button btn_Done;
    }
}