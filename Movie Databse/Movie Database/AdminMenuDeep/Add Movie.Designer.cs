namespace Movie_Databse.AdminMenuDeep
{
    partial class Add_Movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Movie));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Done = new System.Windows.Forms.Button();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.nud_Year = new System.Windows.Forms.NumericUpDown();
            this.cbx_Rating = new System.Windows.Forms.ComboBox();
            this.lbl_Rating = new System.Windows.Forms.Label();
            this.lbl_Released = new System.Windows.Forms.Label();
            this.dtp_Released = new System.Windows.Forms.DateTimePicker();
            this.lbl_Runtime = new System.Windows.Forms.Label();
            this.nud_Runtime = new System.Windows.Forms.NumericUpDown();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.txt_Genre = new System.Windows.Forms.TextBox();
            this.txt_Director = new System.Windows.Forms.TextBox();
            this.lbl_Director = new System.Windows.Forms.Label();
            this.txt_Writer = new System.Windows.Forms.TextBox();
            this.lbl_Writer = new System.Windows.Forms.Label();
            this.txt_Actors = new System.Windows.Forms.TextBox();
            this.lbl_Actors = new System.Windows.Forms.Label();
            this.txt_Plot = new System.Windows.Forms.TextBox();
            this.lbl_Plot = new System.Windows.Forms.Label();
            this.txt_Language = new System.Windows.Forms.TextBox();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.txt_Awards = new System.Windows.Forms.TextBox();
            this.lbl_Awards = new System.Windows.Forms.Label();
            this.nud_Metascore = new System.Windows.Forms.NumericUpDown();
            this.lbl_Metascore = new System.Windows.Forms.Label();
            this.lbl_Copies = new System.Windows.Forms.Label();
            this.nud_Copies = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Runtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Metascore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Copies)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(16, 460);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(251, 47);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Done
            // 
            this.btn_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Done.Location = new System.Drawing.Point(273, 405);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(266, 102);
            this.btn_Done.TabIndex = 14;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(12, 34);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(266, 20);
            this.txt_Title.TabIndex = 0;
            // 
            // lbl_Year
            // 
            this.lbl_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Location = new System.Drawing.Point(284, 9);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(74, 20);
            this.lbl_Year.TabIndex = 12;
            this.lbl_Year.Text = "Year";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(266, 20);
            this.lbl_Title.TabIndex = 10;
            this.lbl_Title.Text = "Title";
            // 
            // nud_Year
            // 
            this.nud_Year.Location = new System.Drawing.Point(284, 34);
            this.nud_Year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_Year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_Year.Name = "nud_Year";
            this.nud_Year.Size = new System.Drawing.Size(74, 20);
            this.nud_Year.TabIndex = 1;
            this.nud_Year.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // cbx_Rating
            // 
            this.cbx_Rating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Rating.FormattingEnabled = true;
            this.cbx_Rating.Items.AddRange(new object[] {
            "G",
            "PG",
            "M",
            "R13",
            "R15",
            "R16",
            "R18",
            "RP13",
            "RP16",
            "R"});
            this.cbx_Rating.Location = new System.Drawing.Point(364, 34);
            this.cbx_Rating.Name = "cbx_Rating";
            this.cbx_Rating.Size = new System.Drawing.Size(175, 21);
            this.cbx_Rating.TabIndex = 2;
            // 
            // lbl_Rating
            // 
            this.lbl_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rating.Location = new System.Drawing.Point(364, 11);
            this.lbl_Rating.Name = "lbl_Rating";
            this.lbl_Rating.Size = new System.Drawing.Size(175, 20);
            this.lbl_Rating.TabIndex = 21;
            this.lbl_Rating.Text = "Rating";
            // 
            // lbl_Released
            // 
            this.lbl_Released.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Released.Location = new System.Drawing.Point(12, 68);
            this.lbl_Released.Name = "lbl_Released";
            this.lbl_Released.Size = new System.Drawing.Size(106, 20);
            this.lbl_Released.TabIndex = 22;
            this.lbl_Released.Text = "Released";
            // 
            // dtp_Released
            // 
            this.dtp_Released.CustomFormat = "dd,Jan,yyyy";
            this.dtp_Released.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Released.Location = new System.Drawing.Point(12, 91);
            this.dtp_Released.Name = "dtp_Released";
            this.dtp_Released.Size = new System.Drawing.Size(106, 20);
            this.dtp_Released.TabIndex = 3;
            // 
            // lbl_Runtime
            // 
            this.lbl_Runtime.AutoSize = true;
            this.lbl_Runtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Runtime.Location = new System.Drawing.Point(128, 68);
            this.lbl_Runtime.Name = "lbl_Runtime";
            this.lbl_Runtime.Size = new System.Drawing.Size(139, 20);
            this.lbl_Runtime.TabIndex = 24;
            this.lbl_Runtime.Text = "Runtime (Minutes)";
            // 
            // nud_Runtime
            // 
            this.nud_Runtime.Location = new System.Drawing.Point(128, 91);
            this.nud_Runtime.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_Runtime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Runtime.Name = "nud_Runtime";
            this.nud_Runtime.Size = new System.Drawing.Size(139, 20);
            this.nud_Runtime.TabIndex = 4;
            this.nud_Runtime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genre.Location = new System.Drawing.Point(273, 68);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(266, 20);
            this.lbl_Genre.TabIndex = 26;
            this.lbl_Genre.Text = "Genre";
            // 
            // txt_Genre
            // 
            this.txt_Genre.Location = new System.Drawing.Point(273, 91);
            this.txt_Genre.Name = "txt_Genre";
            this.txt_Genre.Size = new System.Drawing.Size(266, 20);
            this.txt_Genre.TabIndex = 5;
            // 
            // txt_Director
            // 
            this.txt_Director.Location = new System.Drawing.Point(12, 148);
            this.txt_Director.Name = "txt_Director";
            this.txt_Director.Size = new System.Drawing.Size(266, 20);
            this.txt_Director.TabIndex = 6;
            // 
            // lbl_Director
            // 
            this.lbl_Director.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Director.Location = new System.Drawing.Point(12, 125);
            this.lbl_Director.Name = "lbl_Director";
            this.lbl_Director.Size = new System.Drawing.Size(266, 20);
            this.lbl_Director.TabIndex = 28;
            this.lbl_Director.Text = "Director";
            // 
            // txt_Writer
            // 
            this.txt_Writer.Location = new System.Drawing.Point(284, 148);
            this.txt_Writer.Name = "txt_Writer";
            this.txt_Writer.Size = new System.Drawing.Size(255, 20);
            this.txt_Writer.TabIndex = 7;
            // 
            // lbl_Writer
            // 
            this.lbl_Writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Writer.Location = new System.Drawing.Point(284, 125);
            this.lbl_Writer.Name = "lbl_Writer";
            this.lbl_Writer.Size = new System.Drawing.Size(255, 20);
            this.lbl_Writer.TabIndex = 30;
            this.lbl_Writer.Text = "Writer";
            // 
            // txt_Actors
            // 
            this.txt_Actors.Location = new System.Drawing.Point(12, 194);
            this.txt_Actors.Name = "txt_Actors";
            this.txt_Actors.Size = new System.Drawing.Size(527, 20);
            this.txt_Actors.TabIndex = 8;
            // 
            // lbl_Actors
            // 
            this.lbl_Actors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actors.Location = new System.Drawing.Point(12, 171);
            this.lbl_Actors.Name = "lbl_Actors";
            this.lbl_Actors.Size = new System.Drawing.Size(527, 20);
            this.lbl_Actors.TabIndex = 32;
            this.lbl_Actors.Text = "Actors";
            // 
            // txt_Plot
            // 
            this.txt_Plot.Location = new System.Drawing.Point(12, 249);
            this.txt_Plot.Multiline = true;
            this.txt_Plot.Name = "txt_Plot";
            this.txt_Plot.Size = new System.Drawing.Size(527, 40);
            this.txt_Plot.TabIndex = 9;
            // 
            // lbl_Plot
            // 
            this.lbl_Plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Plot.Location = new System.Drawing.Point(12, 226);
            this.lbl_Plot.Name = "lbl_Plot";
            this.lbl_Plot.Size = new System.Drawing.Size(527, 20);
            this.lbl_Plot.TabIndex = 34;
            this.lbl_Plot.Text = "Plot";
            // 
            // txt_Language
            // 
            this.txt_Language.Location = new System.Drawing.Point(12, 321);
            this.txt_Language.Name = "txt_Language";
            this.txt_Language.Size = new System.Drawing.Size(266, 20);
            this.txt_Language.TabIndex = 10;
            // 
            // lbl_Language
            // 
            this.lbl_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Language.Location = new System.Drawing.Point(12, 298);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(266, 20);
            this.lbl_Language.TabIndex = 36;
            this.lbl_Language.Text = "Language";
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(284, 321);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(255, 20);
            this.txt_Country.TabIndex = 11;
            // 
            // lbl_Country
            // 
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.Location = new System.Drawing.Point(284, 298);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(255, 20);
            this.lbl_Country.TabIndex = 38;
            this.lbl_Country.Text = "Country";
            // 
            // txt_Awards
            // 
            this.txt_Awards.Location = new System.Drawing.Point(12, 379);
            this.txt_Awards.Name = "txt_Awards";
            this.txt_Awards.Size = new System.Drawing.Size(527, 20);
            this.txt_Awards.TabIndex = 12;
            // 
            // lbl_Awards
            // 
            this.lbl_Awards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Awards.Location = new System.Drawing.Point(12, 356);
            this.lbl_Awards.Name = "lbl_Awards";
            this.lbl_Awards.Size = new System.Drawing.Size(527, 20);
            this.lbl_Awards.TabIndex = 40;
            this.lbl_Awards.Text = "Awards";
            // 
            // nud_Metascore
            // 
            this.nud_Metascore.Location = new System.Drawing.Point(16, 434);
            this.nud_Metascore.Name = "nud_Metascore";
            this.nud_Metascore.Size = new System.Drawing.Size(102, 20);
            this.nud_Metascore.TabIndex = 13;
            this.nud_Metascore.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbl_Metascore
            // 
            this.lbl_Metascore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Metascore.Location = new System.Drawing.Point(12, 411);
            this.lbl_Metascore.Name = "lbl_Metascore";
            this.lbl_Metascore.Size = new System.Drawing.Size(106, 20);
            this.lbl_Metascore.TabIndex = 51;
            this.lbl_Metascore.Text = "Metascore";
            // 
            // lbl_Copies
            // 
            this.lbl_Copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Copies.Location = new System.Drawing.Point(128, 411);
            this.lbl_Copies.Name = "lbl_Copies";
            this.lbl_Copies.Size = new System.Drawing.Size(106, 20);
            this.lbl_Copies.TabIndex = 53;
            this.lbl_Copies.Text = "Copies";
            // 
            // nud_Copies
            // 
            this.nud_Copies.Location = new System.Drawing.Point(132, 434);
            this.nud_Copies.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Copies.Name = "nud_Copies";
            this.nud_Copies.Size = new System.Drawing.Size(102, 20);
            this.nud_Copies.TabIndex = 52;
            this.nud_Copies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Add_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 518);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Copies);
            this.Controls.Add(this.nud_Copies);
            this.Controls.Add(this.lbl_Metascore);
            this.Controls.Add(this.nud_Metascore);
            this.Controls.Add(this.txt_Awards);
            this.Controls.Add(this.lbl_Awards);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.txt_Language);
            this.Controls.Add(this.lbl_Language);
            this.Controls.Add(this.txt_Plot);
            this.Controls.Add(this.lbl_Plot);
            this.Controls.Add(this.txt_Actors);
            this.Controls.Add(this.lbl_Actors);
            this.Controls.Add(this.txt_Writer);
            this.Controls.Add(this.lbl_Writer);
            this.Controls.Add(this.txt_Director);
            this.Controls.Add(this.lbl_Director);
            this.Controls.Add(this.txt_Genre);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.nud_Runtime);
            this.Controls.Add(this.lbl_Runtime);
            this.Controls.Add(this.dtp_Released);
            this.Controls.Add(this.lbl_Released);
            this.Controls.Add(this.lbl_Rating);
            this.Controls.Add(this.cbx_Rating);
            this.Controls.Add(this.nud_Year);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Movie";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Input Movie Details";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Runtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Metascore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Copies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.NumericUpDown nud_Year;
        private System.Windows.Forms.ComboBox cbx_Rating;
        private System.Windows.Forms.Label lbl_Rating;
        private System.Windows.Forms.Label lbl_Released;
        private System.Windows.Forms.DateTimePicker dtp_Released;
        private System.Windows.Forms.Label lbl_Runtime;
        private System.Windows.Forms.NumericUpDown nud_Runtime;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.TextBox txt_Genre;
        private System.Windows.Forms.TextBox txt_Director;
        private System.Windows.Forms.Label lbl_Director;
        private System.Windows.Forms.TextBox txt_Writer;
        private System.Windows.Forms.Label lbl_Writer;
        private System.Windows.Forms.TextBox txt_Actors;
        private System.Windows.Forms.Label lbl_Actors;
        private System.Windows.Forms.TextBox txt_Plot;
        private System.Windows.Forms.Label lbl_Plot;
        private System.Windows.Forms.TextBox txt_Language;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.TextBox txt_Awards;
        private System.Windows.Forms.Label lbl_Awards;
        private System.Windows.Forms.NumericUpDown nud_Metascore;
        private System.Windows.Forms.Label lbl_Metascore;
        private System.Windows.Forms.Label lbl_Copies;
        private System.Windows.Forms.NumericUpDown nud_Copies;
    }
}