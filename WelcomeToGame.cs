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
    public partial class WelcomeToGame : Form
    {
        public WelcomeToGame()
        {
            InitializeComponent();
        }

        private void WelcomeToGame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPage st = new StartPage();
            st.Visible = true;
            this.Visible = false;
        }
    }
}
