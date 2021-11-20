
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
            this.directorLabel.Location = new System.Drawing.Point(64, 188);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(47, 13);
            this.directorLabel.TabIndex = 3;
            this.directorLabel.Text = "Director:";
            // 
            // deleteMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}