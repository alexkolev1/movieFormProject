
namespace Movie_Manager_Application
{
    partial class deleteMovieForm
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
            this.deleteMovieLabel = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.rottonTomatoesLabel = new System.Windows.Forms.Label();
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
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteMovieLabel
            // 
            this.deleteMovieLabel.AutoSize = true;
            this.deleteMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMovieLabel.Location = new System.Drawing.Point(24, 19);
            this.deleteMovieLabel.Name = "deleteMovieLabel";
            this.deleteMovieLabel.Size = new System.Drawing.Size(132, 24);
            this.deleteMovieLabel.TabIndex = 0;
            this.deleteMovieLabel.Text = "Delete Movie";
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Location = new System.Drawing.Point(61, 59);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(62, 13);
            this.movieTitleLabel.TabIndex = 1;
            this.movieTitleLabel.Text = "Movie Title:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(87, 118);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Year:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(67, 170);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(47, 13);
            this.directorLabel.TabIndex = 3;
            this.directorLabel.Text = "Director:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(75, 232);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre:";
            // 
            // rottonTomatoesLabel
            // 
            this.rottonTomatoesLabel.AutoSize = true;
            this.rottonTomatoesLabel.Location = new System.Drawing.Point(149, 284);
            this.rottonTomatoesLabel.Name = "rottonTomatoesLabel";
            this.rottonTomatoesLabel.Size = new System.Drawing.Size(123, 13);
            this.rottonTomatoesLabel.TabIndex = 5;
            this.rottonTomatoesLabel.Text = "Rotton Tomatoes Score:";
            // 
            // boxOfficeLabel
            // 
            this.boxOfficeLabel.AutoSize = true;
            this.boxOfficeLabel.Location = new System.Drawing.Point(364, 284);
            this.boxOfficeLabel.Name = "boxOfficeLabel";
            this.boxOfficeLabel.Size = new System.Drawing.Size(103, 13);
            this.boxOfficeLabel.TabIndex = 6;
            this.boxOfficeLabel.Text = "Box Office Earnings:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 415);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(111, 415);
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
            this.movieTitleText.Location = new System.Drawing.Point(129, 56);
            this.movieTitleText.Name = "movieTitleText";
            this.movieTitleText.Size = new System.Drawing.Size(368, 20);
            this.movieTitleText.TabIndex = 10;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(129, 118);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(80, 20);
            this.yearText.TabIndex = 11;
            // 
            // directorText
            // 
            this.directorText.Location = new System.Drawing.Point(129, 170);
            this.directorText.Name = "directorText";
            this.directorText.Size = new System.Drawing.Size(143, 20);
            this.directorText.TabIndex = 12;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(129, 232);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(143, 20);
            this.genreText.TabIndex = 13;
            // 
            // rottenTomatoesText
            // 
            this.rottenTomatoesText.Location = new System.Drawing.Point(278, 281);
            this.rottenTomatoesText.Name = "rottenTomatoesText";
            this.rottenTomatoesText.Size = new System.Drawing.Size(65, 20);
            this.rottenTomatoesText.TabIndex = 14;
            // 
            // boxOfficeText
            // 
            this.boxOfficeText.Location = new System.Drawing.Point(474, 284);
            this.boxOfficeText.Name = "boxOfficeText";
            this.boxOfficeText.Size = new System.Drawing.Size(130, 20);
            this.boxOfficeText.TabIndex = 15;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(503, 54);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 16;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // deleteMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findButton);
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
            this.Controls.Add(this.rottonTomatoesLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.movieTitleLabel);
            this.Controls.Add(this.deleteMovieLabel);
            this.Name = "deleteMovieForm";
            this.Text = "Delete Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteMovieLabel;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label rottonTomatoesLabel;
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
        private System.Windows.Forms.Button findButton;
    }
}