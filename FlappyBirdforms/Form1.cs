using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravity = 0;
        int speed = 25;
        int score = 0;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 10;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15;
            else if (e.KeyCode == Keys.Enter)
                timer1.Start();
        }

        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeDown.Left -= speed;
            pipeTop.Left -= speed;
            weather.Left -= speed;
            lblScore.Text = $"Score: {score}";
            //adding score
            if(pipeDown.Left<-92)
            {
                pipeDown.Left = rnd.Next(80, 800);
                score++;
            }
            if(pipeTop.Left <-92)
            {
                int top = rnd.Next(80, 800);
                pipeTop.Left = top;
                weather.Left = rnd.Next(top + 80, 800);

                score++;
            }
            if(flappyBird.Bounds.IntersectsWith(pipeDown.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds
                .IntersectsWith(groundBase.Bounds))
            {
                timer1.Stop();
                lblScore.Text += " Game Over !!! ";
            }
            if (score > 10)
                speed += 5;
        }


        private void flappyBird_Click(object sender, EventArgs e)
        {

        }
    }
}
