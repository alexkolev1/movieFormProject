
namespace Movie_Manager_Application
{
    partial class addMovieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.rottenTomatoesLabel = new System.Windows.Forms.Label();
            this.boxOfficeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.movieTitleText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.directorText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.rottenTomatoesText = new System.Windows.Forms.TextBox();
            this.boxOfficeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Movie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Location = new System.Drawing.Point(83, 72);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(62, 13);
            this.movieTitleLabel.TabIndex = 1;
            this.movieTitleLabel.Text = "Movie Title:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(113, 122);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Year:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(98, 180);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(47, 13);
            this.directorLabel.TabIndex = 3;
            this.directorLabel.Text = "Director:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(106, 247);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre:";
            // 
            // rottenTomatoesLabel
            // 
            this.rottenTomatoesLabel.AutoSize = true;
            this.rottenTomatoesLabel.Location = new System.Drawing.Point(187, 297);
            this.rottenTomatoesLabel.Name = "rottenTomatoesLabel";
            this.rottenTomatoesLabel.Size = new System.Drawing.Size(123, 13);
            this.rottenTomatoesLabel.TabIndex = 5;
            this.rottenTomatoesLabel.Text = "Rotten Tomatoes Score:";
            // 
            // boxOfficeLabel
            // 
            this.boxOfficeLabel.AutoSize = true;
            this.boxOfficeLabel.Location = new System.Drawing.Point(425, 297);
            this.boxOfficeLabel.Name = "boxOfficeLabel";
            this.boxOfficeLabel.Size = new System.Drawing.Size(103, 13);
            this.boxOfficeLabel.TabIndex = 6;
            this.boxOfficeLabel.Text = "Box Office Earnings:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 415);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(116, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(713, 415);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // movieTitleText
            // 
            this.movieTitleText.Location = new System.Drawing.Point(152, 72);
            this.movieTitleText.Name = "movieTitleText";
            this.movieTitleText.Size = new System.Drawing.Size(267, 20);
            this.movieTitleText.TabIndex = 10;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(152, 122);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(74, 20);
            this.yearText.TabIndex = 11;
            // 
            // directorText
            // 
            this.directorText.Location = new System.Drawing.Point(152, 180);
            this.directorText.Name = "directorText";
            this.directorText.Size = new System.Drawing.Size(158, 20);
            this.directorText.TabIndex = 12;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(152, 247);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(158, 20);
            this.genreText.TabIndex = 13;
            // 
            // rottenTomatoesText
            // 
            this.rottenTomatoesText.Location = new System.Drawing.Point(317, 297);
            this.rottenTomatoesText.Name = "rottenTomatoesText";
            this.rottenTomatoesText.Size = new System.Drawing.Size(67, 20);
            this.rottenTomatoesText.TabIndex = 14;
            // 
            // boxOfficeText
            // 
            this.boxOfficeText.Location = new System.Drawing.Point(535, 289);
            this.boxOfficeText.Name = "boxOfficeText";
            this.boxOfficeText.Size = new System.Drawing.Size(116, 20);
            this.boxOfficeText.TabIndex = 15;
            // 
            // addMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxOfficeText);
            this.Controls.Add(this.rottenTomatoesText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.directorText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.movieTitleText);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.boxOfficeLabel);
            this.Controls.Add(this.rottenTomatoesLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.movieTitleLabel);
            this.Controls.Add(this.label1);
            this.Name = "addMovieForm";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label rottenTomatoesLabel;
        private System.Windows.Forms.Label boxOfficeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox movieTitleText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox directorText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox rottenTomatoesText;
        private System.Windows.Forms.TextBox boxOfficeText;
    }
}