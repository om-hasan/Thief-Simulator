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
    public partial class NewProfile : Form
    {
        public void fillList()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < Program.playerlist.Count; i++)

            {
                comboBox1.Items.Add(Program.playerlist[i].Name);

            }
        }

        public void fillList2()
        {
            comboBox2.Items.Clear();
            for (int i = 0; i < Program.playerlist.Count; i++)
            {
                comboBox2.Items.Add(Program.playerlist[i].Name);
            }
        }

        public NewProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0 || comboBox2.Items.Count == 0)

            {
                MessageBox.Show("please create  account");
            }

            else if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)


                MessageBox.Show("please select profile");
            else
            {
                for (int i = 0; i < Program.playerlist.Count; i++)

                {
                    if (Program.playerlist[i].Name == comboBox1.SelectedItem.ToString())
                    {
                        Program.player = Program.playerlist[i];
                        Program.index = i;

                    }
                    if (Program.playerlist[i].Name == comboBox2.SelectedItem.ToString())
                    {
                        Program.player = Program.playerlist[i];
                        Program.index = i;

                    }
                }
                Level1 l1 = new Level1();
                l1.Show();
                this.Hide();
            }
        }

        private void NewProfile_Load(object sender, EventArgs e)
        {
            fillList();
            fillList2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Visible = true;
            this.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
