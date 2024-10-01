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

namespace C__Project
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Visible = true;
            this.Visible = false;
        }

        private void History_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows[0].Cells[0].Value = 0;
            this.dataGridView1.Rows[0].Cells[1].Value = 0;
            this.dataGridView1.Rows[0].Cells[2].Value = ""; //string
            this.dataGridView1.Rows[0].Cells[3].Value = 0;
           
            int i = 0;
            foreach(Player da in Program.playerlist)
            {
                if(i != Program.playerlist.Count - 1)
                {
                    this.dataGridView1.Rows.Add();
                    this.Height += 30;
                    dataGridView1.Height += 30; 
                }
                string d = da.Date.ToString().Split(' ')[0];
                this.dataGridView1.Rows[i].Cells[0].Value = d;
                this.dataGridView1.Rows[i].Cells[1].Value = da.MinDuration;
                this.dataGridView1.Rows[i].Cells[2].Value = da.Name;
                this.dataGridView1.Rows[i].Cells[3].Value = da.MaxScore + da.MinScore;
                
            }
        }
    }
}
