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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeObjects();
        }

        private void InitializeObjects()
        {
            pictureBox1.Location = new System.Drawing.Point(50, 50); // Initial position of object 1
            pictureBox2.Location = new System.Drawing.Point(150, 150); // Initial position of object 2
        }
        private int object1X = 610; // Initial X position of object 1
        private int object1Y = 200; // Initial Y position of object 1
        private int object2X = 320; // Initial X position of object 2
        private int object2Y = 320; // Initial Y position of object 2
        private int moveAmount = 10; // Amount to move objects by


        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            // Move object 1 with the W, A, S, D keys
            if (e.KeyCode == Keys.W)
                object1Y -= moveAmount;
            else if (e.KeyCode == Keys.S)
                object1Y += moveAmount;
            else if (e.KeyCode == Keys.A)
                object1X -= moveAmount;
            else if (e.KeyCode == Keys.D)
                object1X += moveAmount;

            // Move object 2 with the Arrow keys
            if (e.KeyCode == Keys.Up)
                object2Y -= moveAmount;
            else if (e.KeyCode == Keys.Down)
                object2Y += moveAmount;
            else if (e.KeyCode == Keys.Left)
                object2X -= moveAmount;
            else if (e.KeyCode == Keys.Right)
                object2X += moveAmount;
        }
    }
}
