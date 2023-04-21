using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;



        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }


        private void keyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gametimerEvent(object sender, System.EventArgs e)
        {

            txtScore.Text = "Score: " + score;
            score++;

            if (goleft == true && player.Left > 16)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 409)
            {
                player.Left += playerSpeed;
            }

            RoadTrack1.Top += roadSpeed;
            RoadTrack2.Top += roadSpeed;

            if (RoadTrack2.Top > 519)
            {
                RoadTrack2.Top = -510;
            }
            if (RoadTrack1.Top > 519)
            {
                RoadTrack1.Top = -519;
            }

            Ai1.Top += trafficSpeed;
            Ai2.Top += trafficSpeed;

            if (Ai1.Top > 530)
            {
                changeAIcars(Ai1);

            }
            if (Ai2.Top > 530)
            {
                changeAIcars(Ai2);
            }
            if (player.Bounds.IntersectsWith(Ai1.Bounds) || player.Bounds.IntersectsWith(Ai2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources._1star;
            }

            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources._2star;
                roadSpeed = 16;
                trafficSpeed = 18;
            }
            if (score > 2000 && score < 3000)
            {
                award.Image = Properties.Resources._3star;
                trafficSpeed = 22;
                roadSpeed = 24;
            }
            if (score > 3000 && score < 5000)
            {
                award.Image = Properties.Resources._4star;
                trafficSpeed = 26;
                roadSpeed = 28;
            }
            if (score > 5000)
            {
                award.Image = Properties.Resources._5star;
                trafficSpeed = 30;
                roadSpeed = 32;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 14);

            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 10:
                    tempCar.Image = Properties.Resources.AI1;
                    break;
                case 11:
                    tempCar.Image = Properties.Resources.AI2;
                    break;
                case 12:
                    tempCar.Image = Properties.Resources.AI3;
                    break;
                case 13:
                    tempCar.Image = Properties.Resources.AI4;
                    break;


            }

            tempCar.Top = carPosition.Next(100, 400) * -1;

            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;

        }

        private void ResetGame()
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources._1star;

            roadSpeed = 12;
            trafficSpeed = 15;

            Ai1.Top = carPosition.Next(200, 500) * -1;
            Ai1.Left = carPosition.Next(5, 200);

            Ai2.Top = carPosition.Next(200, 500) * -1;
            Ai2.Left = carPosition.Next(245, 422);

            gameTimer.Start();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }


        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();


        }
    }
}
