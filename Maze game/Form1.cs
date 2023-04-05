using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_game
{
    public partial class Form1 : Form
    {
        public static int points = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitbtn_Load(object sender, EventArgs e)
        {
            pointslbl.Text ="Points: " + points.ToString();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            points--;

            pointslbl.Text = "Points: " + points.ToString();

            if (points == 0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations!");
        }
    }
}
