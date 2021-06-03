using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Square_Chaser
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(151, 137, 20, 20);
        Rectangle player2 = new Rectangle(151, 97, 20, 20);
        Rectangle boost = new Rectangle(10, 126, 10, 10);
        Rectangle point = new Rectangle(297, 126, 15, 15);

        Random rnd = new Random();

        SoundPlayer boostSound = new SoundPlayer(Properties.Resources.mixkit_explainer_video_game_alert_sweep_236);
        SoundPlayer pointSound = new SoundPlayer(Properties.Resources.mixkit_video_game_retro_click_237);
        SoundPlayer winSound = new SoundPlayer(Properties.Resources.mixkit_player_recharging_in_video_game_2041);


        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush greenBrush = new SolidBrush(Color.LightGreen);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        int player1Score;
        int player2Score;

        bool wDown = false;
        bool sDown = false;
        bool aLeft = false;
        bool dRight = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool LeftArrowLeft = false;
        bool RightArrowRight = false;

        int player1Speed = 4;
        int player2Speed = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(greenBrush, player2);
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(yellowBrush, boost);
            e.Graphics.FillRectangle(whiteBrush, point);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aLeft = true;
                    break;
                case Keys.D:
                    dRight = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    RightArrowRight = true;
                    break;
                case Keys.Left:
                    LeftArrowLeft = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aLeft = false;
                    break;
                case Keys.D:
                    dRight = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    RightArrowRight = false;
                    break;
                case Keys.Left:
                    LeftArrowLeft = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

             

            //making the random x and y values for random boost and point locations
            int rndX = rnd.Next(10, 297);
            int rndY = rnd.Next(10, 224);

            //increasing speed with boost and relocating boost
            if (player1.IntersectsWith(boost))
            {
                player1Speed++;
                boost.X = rndX;
                boost.Y = rndY;
                boostSound.Play();
            }

            if (player2.IntersectsWith(boost))
            {
                player2Speed++;
                boost.X = rndX;
                boost.Y = rndY;
                boostSound.Play();
            }

            //adding points and relocating point
            if (player1.IntersectsWith(point))
            {
                point.X = rndX;
                point.Y = rndY;
                player1Score++;
                score1Label.Text = $"{player1Score}";
                pointSound.Play();
            }

            if (player2.IntersectsWith(point))
            {
                point.X = rndX;
                point.Y = rndY;
                player2Score++;
                score2Label.Text = $"{player2Score}";
                pointSound.Play();
            }

            //checks for game over
            if (player1Score == 7)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Blue Wins!!";
                winSound.Play();
            }

            if (player2Score == 7)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Green Wins!!";
                winSound.Play();
            }

            //movement
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }

            if (aLeft == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }

            if (dRight == true && player1.X < this.Width - player1.Width)
            {
                player1.X += player1Speed;
            }

            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }

            if (RightArrowRight == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
            }

            if (LeftArrowLeft == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }

            Refresh();
        }
    }
}
