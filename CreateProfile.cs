using C__Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__Project
{
    public partial class CreateProfile : Form
    {
        Player player1;
        public CreateProfile()
        {
            player1 = new Player();
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(player1.Name == null || player1.Name == "" || player1.Age == 0)
            {
                MessageBox.Show("please fill the data");
            }
            else
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Selected Age");


                }
                else
                {
                    player1.Age = int.Parse(comboBox1.SelectedItem.ToString());
                }
                player1.Name = textBox1.Text;


                if (radioButton2.Checked)
                {
                    player1.Gender = "Female";

                }
                else
                {
                    player1.Gender = "Male";
                }
              
                player1.Date = DateTime.Now; 
                Program.playerlist.Add(player1);

                StartPage s = new StartPage();
                s.Show();
                this.Hide();

            }
        }

     

        private void CurrentProfile_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Visible = true;
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
