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
    public partial class Current : Form
    {
        public Current()
        {
            InitializeComponent();
        }
        public void fillList()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < Program.playerlist.Count; i++)
            {
                comboBox1.Items.Add(Program.playerlist[i].Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("please create account");

            }
            else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("please select account");
            }
            else
            {
                for (int i = 0; i < Program.playerlist.Count; i++)
                {
                    if (Program.playerlist[i].Name == comboBox1.SelectedItem.ToString())
                    {
                        N.Text = Program.playerlist[i].Name;
                        A.Text = Program.playerlist[i].Age.ToString();
                        G.Text = Program.playerlist[i].Gender;
                        M.Text = "Light";
                    }
                }
            }
        }

        private void Current_Load(object sender, EventArgs e)
        {
            fillList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Visible = true;
            this.Visible = false;
        }
    }
}
