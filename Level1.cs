using C__Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace C__Project
{
    public partial class Level1 : Form
    {
        private int timerValue = 20; 
        private Timer countdownTimer;

        public Level1()
        {
            InitializeComponent();
            InitializeTimer();
            
            countdownTimer.Start();
        }


        private void InitializeTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; 
            countdownTimer.Tick += CountdownTimer_Tick;

            UpdateTimerLabel(); 
        }
        public int thiefScore = 0; public int policeScore = 0;
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            timerValue--;

            if (timerValue >= 0)
            {
                UpdateTimerLabel();
            }
            else
            {
                countdownTimer.Stop();
                timer1.Stop();
                label1.Visible = true;
                label1.Text = "Thief wins!!";
                thiefScore += 10;
                label4.Text = "Score: " + thiefScore;
            }
        }

        private void UpdateTimerLabel()
        {
            time.Text = "Time remaining: " + timerValue.ToString() + "s";
        }

        List<PictureBox> Colliders = new List<PictureBox>();
        public int moveAmount = 5;

        bool moveUP1 = false, moveDown1 = false, moveRight1 = false, moveLeft1 = false;
        bool moveUP2 = false, moveDown2 = false, moveRight2 = false, moveLeft2 = false;

        private void Level1_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is PictureBox && c.Tag == "Collider")
                    Colliders.Add((PictureBox)c);
            label6.Text = "0";
            label4.Text = "0";
            this.KeyPreview = true;
            this.Focus();
            timer1.Start();






        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();

        }



        private void nextlevel_Click(object sender, EventArgs e)
        {
            Level2 level2 = new Level2();
            level2.Show();
            Hide();
        }

        private void Stop1()
        {
            if (moveDown1)
            {
                moveDown1 = false;
                pictureBox1.Top -= moveAmount;
            }
            if (moveUP1)
            {
                moveUP1 = false;
                pictureBox1.Top += moveAmount;
            }
            if (moveRight1)
            {
                moveRight1 = false;
                pictureBox1.Left -= moveAmount;
            }
            if (moveLeft1)
            {
                moveLeft1 = false;
                pictureBox1.Left += moveAmount;
            }
        }
        private void Stop2Computer()
        {
            if (moveDown2)
            {
                moveDown2 = false;
                pictureBox2.Top -= moveAmount;
                if (pictureBox1.Left >= pictureBox2.Left)
                    pictureBox2.Left += moveAmount;
                else
                   pictureBox2.Left -= moveAmount;
            }
            if (moveUP2)
            {
                moveUP2 = false;
                pictureBox2.Top +=moveAmount;
                if (pictureBox1.Left >= pictureBox2.Left)
                    pictureBox2.Left += moveAmount;
                else
                    pictureBox2.Left -= moveAmount;
            }
            if (moveRight2)
            {
                moveRight2 = false;
                pictureBox2.Left -= moveAmount;
                if (pictureBox1.Top >= pictureBox2.Top)
                    pictureBox2.Top += moveAmount;
                else
                    pictureBox2.Top -= moveAmount;
            }
            if (moveLeft2)
            {
                moveLeft2 = false;
                pictureBox2.Left += moveAmount;
                if (pictureBox1.Top >= pictureBox2.Top)
                    pictureBox2.Top += moveAmount;
                else
                    pictureBox2.Top -= moveAmount;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Level1 l1 = new Level1();
            l1.Show();
            this.Hide();
            if (policeScore >= 10 )
            policeScore -= 5;
            else { MessageBox.Show("police score less than 5"); }
        }

        private void label7_Click(object sender, EventArgs e)
        {
              Level1 Main = new Level1();
            Main.Show();
           this.Close();
        }

        private void Stop2()
        {
            if (moveDown2)
            {
                moveDown2 = false;
                pictureBox2.Top -= moveAmount;
            }
            if (moveUP2)
            {
                moveUP2 = false;
                pictureBox2.Top += moveAmount;
            }
            if (moveRight2)
            {
                moveRight2 = false;
                pictureBox2.Left -= moveAmount;
            }
            if (moveLeft2)
            {
                moveLeft2 = false;
                pictureBox2.Left += moveAmount;
            }
        }
        private void Collider()
        {
            foreach (PictureBox c in Colliders)
            {
                if (pictureBox1.Bounds.IntersectsWith(c.Bounds))
                {
                    Stop1();
                    break;
                }
            }

            foreach (PictureBox c in Colliders)
            {
                if (pictureBox2.Bounds.IntersectsWith(c.Bounds))
                {
                  //Stop2();
                    Stop2Computer();
                    break;
                }
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer1.Stop();
                Games games = new Games();
                MessageBox.Show("Game Over /: Police man Wins !!");
                policeScore += 10;
                if (thiefScore >= 10)
                    thiefScore -= 5;
                else { MessageBox.Show("thief score less than 5"); }

                label6.Text = "Score: " + policeScore;
                nextlevel.Visible = true;
                label1.Text = "Police wins!!";
                Program.Gameslist.Add(games);
            }
            if (moveUP1) { pictureBox1.Top -= moveAmount; }
            if (moveDown1) { pictureBox1.Top += moveAmount; }
            if (moveLeft1) { pictureBox1.Left -= moveAmount; }
            if (moveRight1) { pictureBox1.Left += moveAmount; }

            Move2Computer();
            //if (moveUP2) { pictureBox2.Top -= moveAmount; }
            //if (moveDown2) { pictureBox2.Top += moveAmount; }
            //if (moveLeft2) { pictureBox2.Left -= moveAmount; }
            //if (moveRight2) { pictureBox2.Left += moveAmount; }

            Collider();
        }
        private void Move2Computer()
        {
            int x = pictureBox1.Left - pictureBox2.Left;
            int y = pictureBox1.Top - pictureBox2.Top;

            if (Math.Abs(x) > Math.Abs(y))
            {
                if (x > 0)
                {
                    moveRight2 = true;
                    moveLeft2 = moveUP2 = moveDown2 = false;
                    pictureBox2.Left += moveAmount;
                }
                else if (x < 0)
                {
                    moveLeft2 = true;
                    moveDown2 = moveUP2 = moveLeft2 = false;
                    pictureBox2.Left -= moveAmount;
                }
            }
            else
            {
                if (y > 0)
                {
                    moveDown2 = true;
                    moveRight2 = moveUP2 = moveLeft2 = false;
                    pictureBox2.Top += moveAmount;
                }
                else if (y < 0)
                {
                    moveUP2 = true;
                    moveDown2 = moveLeft2 = moveRight2 = false;
                    pictureBox2.Top -= moveAmount;
                }
            }
        }
        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.W)
                moveUP1 = true;
            if (e.KeyCode == Keys.S)
                moveDown1 = true;
            if (e.KeyCode == Keys.A)
                moveLeft1 = true;
            if (e.KeyCode == Keys.D)
                moveRight1 = true;

            
            if (e.KeyCode == Keys.Up)
                moveUP2 = true;
            if (e.KeyCode == Keys.Down)
                moveDown2 = true;
            if (e.KeyCode == Keys.Left)
                moveLeft2 = true;
            if (e.KeyCode == Keys.Right)
                moveRight2 = true;

        }

        private void Level1_KeyUp(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.W)
                moveUP1 = false;
            if (e.KeyCode == Keys.S)
                moveDown1 = false;
            if (e.KeyCode == Keys.A)
                moveLeft1 = false;
            if (e.KeyCode == Keys.D)
                moveRight1 = false;

            
            if (e.KeyCode == Keys.Up)
                moveUP2 = false;
            if (e.KeyCode == Keys.Down)
                moveDown2 = false;
            if (e.KeyCode == Keys.Left)
                moveLeft2 = false;
            if (e.KeyCode == Keys.Right)
                moveRight2 = false;

        }
    }
}