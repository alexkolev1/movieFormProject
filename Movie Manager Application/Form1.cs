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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("do you sill want to exit the app?", "exit the app?", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
                Close();
        }

        private void happyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutform = new AboutBox1();
            
            aboutform.ShowDialog();
        }
    }
}
