using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void SetNumberOfGames()
        {
            NumberOfGame.Text = $"{Program.Gameslist.Count}";
        }

        private void SetNumberOfProfile()
         {
             NumberOfProfiles.Text = $"{Program.playerlist.Count}";
         }

         private void setHightestScore()
         {
             int max = 0;
             var q1 = from Profile in Program.playerlist
                      select Profile.MaxScore;
             foreach (int i in q1)
             {
                 if (i >= max)
                     max = i;
             }
             HighestScore.Text = max.ToString();
         }

         private void setLowestScore()
         {
             int min = 0;
             var q1 = from Profile in Program.playerlist
                      select Profile.MinScore;
             foreach (int i in q1)
             {
                 if (i <= min)
                     min = i;
             }

             LowestScore.Text = min.ToString();
         }

         private void setMaximumDuration()
         {
             int max = 0;
             var q1 = from Profile in Program.playerlist
                      select Profile.MaxDuration;
             foreach (int i in q1)
             {
                 if (i >= max)
                     max = i;
             }
             MaximumDuration.Text = max.ToString();
         }

         private void setMinimunDuration()
         {
             int min = 20;
             var q1 = from Profile in Program.playerlist
                      select Profile.MinDuration;
             foreach (int i in q1)
             {
                 if (i <= min)
                     min = i;
             }

             MinimumDuration.Text = min.ToString();

         }

         private void setTotalDuration()
         {
             int sum = 0;
             var q1 = from Profile in Program.playerlist
                      select Profile.TotalDuration;
             foreach (int i in q1)
             {
                 sum = sum + i;
             }
             TotalDuration.Text = sum.ToString();
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Visible = true;
            this.Visible = false;
        }

        private void Statistic_Load_1(object sender, EventArgs e)
        {
            SetNumberOfGames();
            SetNumberOfProfile();
            setHightestScore();
            setLowestScore();
            setMaximumDuration();
            setMinimunDuration();
            setTotalDuration();

        }

        private void HighestScore_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfProfiles_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfGame_Click(object sender, EventArgs e)
        {

        }
    }
}
