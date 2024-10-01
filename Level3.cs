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
    public partial class Level3: Form
    {
        private int timerValue = 20;
        private Timer countdownTimer;
        public int thiefScore = 0; public int policeScore = 0;
        List<PictureBox> Colliders = new List<PictureBox>();
        public int moveAmount = 5;

        bool moveUP1 = false, moveDown1 = false, moveRight1 = false, moveLeft1 = false;
        bool moveUP2 = false, moveDown2 = false, moveRight2 = false, moveLeft2 = false;
        public Level3()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox19.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Game Over /: Police man Wins !!");
                policeScore += 10;
                if (thiefScore >= 10)
                    thiefScore -= 5;
                else { MessageBox.Show("thief score less than 5"); }

                label6.Text = "Score: " + policeScore;
                nextlevel.Visible = true;
                label1.Text = "Police wins!!";


            }
            if (moveUP1) 
            { 
                pictureBox19.Top -= moveAmount; 
            }
            if (moveDown1) 
            { 
                pictureBox19.Top += moveAmount; 
            }
            if (moveLeft1) 
            { 
                pictureBox19.Left -= moveAmount; 
            }
            if (moveRight1) 
            {
                pictureBox19.Left += moveAmount; 
            }

            Move2Computer();
            //if (moveUP2) 
            //{ 
            //    pictureBox20.Top -= moveAmount; 
            //}
            //if (moveDown2) 
            //{ 
            //    pictureBox20.Top += moveAmount; 
            //}
            //if (moveLeft2) 
            //{ 
            //    pictureBox20.Left -= moveAmount; 
            //}
            //if (moveRight2) 
            //{ 
            //    pictureBox20.Left += moveAmount; 
            //}

            Collider();
        }

        private void Stop1()
        {
            if (moveDown1)
            {
                moveDown1 = false;
                pictureBox19.Top -= moveAmount;
            }
            if (moveUP1)
            {
                moveUP1 = false;
                pictureBox19.Top += moveAmount;
            }
            if (moveRight1)
            {
                moveRight1 = false;
                pictureBox19.Left -= moveAmount;
            }
            if (moveLeft1)
            {
                moveLeft1 = false;
                pictureBox19.Left += moveAmount;
            }
        }
        private void Stop2Computer()
        {
            if (moveDown2)
            {
                moveDown2 = false;
                pictureBox20.Top -= moveAmount;
                if (pictureBox19.Left >= pictureBox20.Left)
                    pictureBox20.Left += moveAmount;
                else
                    pictureBox20.Left -= moveAmount;
            }
            if (moveUP2)
            {
                moveUP2 = false;
                pictureBox20.Top +=moveAmount;
                if (pictureBox19.Left >= pictureBox20.Left)
                    pictureBox20.Left += moveAmount;
                else
                    pictureBox20.Left -= moveAmount;
            }
            if (moveRight2)
            {
                moveRight2 = false;
                pictureBox20.Left -= moveAmount;
                if (pictureBox19.Top >= pictureBox20.Top)
                    pictureBox20.Top += moveAmount;
                else
                    pictureBox20.Top -= moveAmount;
            }
            if (moveLeft2)
            {
                moveLeft2 = false;
                pictureBox20.Left += moveAmount;
                if (pictureBox19.Top >= pictureBox20.Top)
                    pictureBox20.Top += moveAmount;
                else
                    pictureBox20.Top -= moveAmount;
            }
        }

        private void Stop2()
        {
            if (moveDown2)
            {
                moveDown2 = false;
                pictureBox20.Top -= moveAmount;
            }
            if (moveUP2)
            {
                moveUP2 = false;
                pictureBox20.Top += moveAmount;
            }
            if (moveRight2)
            {
                moveRight2 = false;
                pictureBox20.Left -= moveAmount;
            }
            if (moveLeft2)
            {
                moveLeft2 = false;
                pictureBox20.Left += moveAmount;
            }
        }
        private void Collider()
        {
            foreach (PictureBox c in Colliders)
            {
                if (pictureBox19.Bounds.IntersectsWith(c.Bounds))
                {
                    Stop1();
                    break;
                }
            }

            foreach (PictureBox c in Colliders)
            {
                if (pictureBox20.Bounds.IntersectsWith(c.Bounds))
                {
                    Stop2();
                  //Stop2Computer();
                    break;
                }
            }

        }

        private void Move2Computer()
        {
            int x = pictureBox19.Left - pictureBox20.Left;
            int y = pictureBox19.Top - pictureBox20.Top;

            if (Math.Abs(x) > Math.Abs(y))
            {
                if (x > 0)
                {
                    moveRight2 = true;
                    moveLeft2 = moveUP2 = moveDown2 = false;
                    pictureBox20.Left += moveAmount;
                }
                else if (x < 0)
                {
                    moveLeft2 = true;
                    moveDown2 = moveUP2 = moveLeft2 = false;
                    pictureBox20.Left -= moveAmount;
                }
            }
            else
            {
                if (y > 0)
                {
                    moveDown2 = true;
                    moveRight2 = moveUP2 = moveLeft2 = false;
                    pictureBox20.Top += moveAmount;
                }
                else if (y < 0)
                {
                    moveUP2 = true;
                    moveDown2 = moveLeft2 = moveRight2 = false;
                    pictureBox20.Top -= moveAmount;
                }
            }
        }
        

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Level3 l3 = new Level3();
            l3.Show();
            this.Hide();
            if (policeScore >= 10)
                policeScore -= 5;
            else 
            {
                MessageBox.Show("police score less than 5"); 
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Visible = true;
            Visible = false;
        }

        private void Level3_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is PictureBox && c.Tag == "Collider")
                    Colliders.Add((PictureBox)c);
            label6.Text = "0";
            label4.Text = "0";
        }

        private void Level3_KeyUp(object sender, KeyEventArgs e)
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

        private void Level3_KeyDown(object sender, KeyEventArgs e)
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
    }
}
