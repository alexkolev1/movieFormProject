using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    public partial class deleteMovieForm : Form
    {
        public deleteMovieForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            movieTitleText.Text = "";
            yearText.Text = "";
            directorText.Text = "";
            genreText.Text = "";
            rottenTomatoesText.Text = "";
            boxOfficeText.Text = "";
        }
    }
}
