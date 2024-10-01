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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }

        private void statsicToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewProfile newProfile = new NewProfile();
            newProfile.Visible = true;
            this.Visible = false;
        }

        private void currentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Current current = new Current();
            current.Visible = true;
            this.Visible = false;
        }

        private void newToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CreateProfile currentProfile = new CreateProfile();
            currentProfile.Visible = true;
            this.Visible = false;
        }

        private void endToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StartPage s = new StartPage();
            s.Show();
        }

        private void statsicToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Visible = true;
            this.Visible = false;
        }

        private void historyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            History history = new History();
            history.Visible = true;
            this.Visible = false;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeToGame startPage = new WelcomeToGame();
            startPage.Visible = true;
            this.Visible = false;
        }
    }
}
