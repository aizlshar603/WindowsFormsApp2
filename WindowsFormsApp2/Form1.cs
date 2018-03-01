using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string difficultyLevel;
        string heroName;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void level1_Click(object sender, EventArgs e)
        {
            difficultyLevel = "Easy";
            easy.BackColor = Color.Green;
            medium.BackColor = Color.White;
            hard.BackColor = Color.White;
        }

        private void level2_Click(object sender, EventArgs e)
        {
            difficultyLevel = "Medium";
            easy.BackColor = Color.White;
            medium.BackColor = Color.Orange;
            hard.BackColor = Color.White;
        }

        private void level3_Click(object sender, EventArgs e)
        {
            difficultyLevel = "Hard";
            easy.BackColor = Color.White;
            medium.BackColor = Color.White;
            hard.BackColor = Color.Red;
        }

        private void GameStart_Click(object sender, EventArgs e)
        {
            heroName = heroNameInput.Text;
            outputLabel.Text = "welcome "+ heroName + "You have chosen the " + difficultyLevel + " path";

        }
    }
}
