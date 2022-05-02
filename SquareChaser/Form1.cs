using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace SquareChaser
{
    public partial class squareChaser : Form
    {
        //random generator
        Random rndLoc = new Random();

        //models
        Rectangle point = new Rectangle(295, 195, 10, 10);
        Rectangle power = new Rectangle(295, 215, 10, 10);
        Rectangle losePoint = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint2 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint3 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint4 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint5 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint6 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint7 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint8 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint9 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint10 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint11 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint12 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint13 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint14 = new Rectangle(295, 195, 10, 10);
        Rectangle losePoint15 = new Rectangle(295, 195, 10, 10);
        Rectangle player1 = new Rectangle(200, 200, 30, 30);
        Rectangle player2 = new Rectangle(340, 200, 30, 30);

        //powerup bars
        Rectangle p1Bar = new Rectangle(30, 440, 0, 10);
        Rectangle p2Bar = new Rectangle(335, 440, 0, 10);

        //barriers
        Rectangle leftBarrier = new Rectangle(30, 30, 20, 400);
        Rectangle topBarrier = new Rectangle(30, 30, 500, 20);
        Rectangle rightBarrier = new Rectangle(515, 30, 20, 405);
        Rectangle bottomBarrier = new Rectangle(30, 415, 500, 20);

        //scoring variables
        int player1Score = 0;
        int player2Score = 0;
        //int playerTurn = 1;

        //player status variables
        int player1Speed = 5;
        int player2Speed = 5;
        
        //power timer variables
        int powerTimer = 50;
        int power2Timer = 50;
        
        
        //player movement variables
        bool wDown = false;
        bool aDown = false;
        bool sDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool rightArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        
        //brushes
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush redBrush = new SolidBrush (Color.Red);
        Pen whitePen = new Pen(Color.White, 4);

        //sounds
        SoundPlayer gameMusic = new SoundPlayer(Properties.Resources.gameMusic);

        public squareChaser()
        {
            InitializeComponent();

            //sounds
            gameMusic.Play();

            //placing models
            {
                point.X = rndLoc.Next(55, 485);
                point.Y = rndLoc.Next(55, 395);

                losePoint.X = rndLoc.Next(55, 485);
                losePoint.Y = rndLoc.Next(55, 395);

                losePoint2.X = rndLoc.Next(55, 485);
                losePoint2.Y = rndLoc.Next(55, 395);

                losePoint3.X = rndLoc.Next(55, 485);
                losePoint3.Y = rndLoc.Next(55, 395);

                losePoint4.X = rndLoc.Next(55, 485);
                losePoint4.Y = rndLoc.Next(55, 395);

                losePoint5.X = rndLoc.Next(55, 485);
                losePoint5.Y = rndLoc.Next(55, 395);

                losePoint6.X = rndLoc.Next(55, 485);
                losePoint6.Y = rndLoc.Next(55, 395);

                losePoint7.X = rndLoc.Next(55, 485);
                losePoint7.Y = rndLoc.Next(55, 395);

                losePoint8.X = rndLoc.Next(55, 485);
                losePoint8.Y = rndLoc.Next(55, 395);

                losePoint9.X = rndLoc.Next(55, 485);
                losePoint9.Y = rndLoc.Next(55, 395);

                losePoint10.X = rndLoc.Next(55, 485);
                losePoint10.Y = rndLoc.Next(55, 395);

                losePoint11.X = rndLoc.Next(55, 485);
                losePoint11.Y = rndLoc.Next(55, 395);

                losePoint12.X = rndLoc.Next(55, 485);
                losePoint12.Y = rndLoc.Next(55, 395);

                losePoint13.X = rndLoc.Next(55, 485);
                losePoint13.Y = rndLoc.Next(55, 395);

                losePoint14.X = rndLoc.Next(55, 485);
                losePoint14.Y = rndLoc.Next(55, 395);

                losePoint15.X = rndLoc.Next(55, 485);
                losePoint15.Y = rndLoc.Next(55, 395);



                while (point.IntersectsWith(player1))
                {
                    point.X = rndLoc.Next(55, 485);
                    point.Y = rndLoc.Next(55, 395);
                }

                while (point.IntersectsWith(player2))
                {
                    point.X = rndLoc.Next(55, 485);
                    point.Y = rndLoc.Next(55, 395);
                }

                while (power.IntersectsWith(player1))
                {
                    power.X = rndLoc.Next(55, 485);
                    power.Y = rndLoc.Next(55, 395);
                }

                while (power.IntersectsWith(player2))
                {
                    power.X = rndLoc.Next(55, 485);
                    power.Y = rndLoc.Next(55, 395);
                }

                while (losePoint.IntersectsWith(player1))
                {
                    losePoint.X = rndLoc.Next(55, 485);
                    losePoint.Y = rndLoc.Next(55, 395);
                }

                while (losePoint.IntersectsWith(player2))
                {
                    losePoint.X = rndLoc.Next(55, 485);
                    losePoint.Y = rndLoc.Next(55, 395);
                }

                while (losePoint2.IntersectsWith(player1))
                {
                    losePoint2.X = rndLoc.Next(55, 485);
                    losePoint2.Y = rndLoc.Next(55, 395);
                }

                while (losePoint2.IntersectsWith(player2))
                {
                    losePoint2.X = rndLoc.Next(55, 485);
                    losePoint2.Y = rndLoc.Next(55, 395);
                }

                while (losePoint3.IntersectsWith(player1))
                {
                    losePoint3.X = rndLoc.Next(55, 485);
                    losePoint3.Y = rndLoc.Next(55, 395);
                }

                while (losePoint3.IntersectsWith(player2))
                {
                    losePoint3.X = rndLoc.Next(55, 485);
                    losePoint3.Y = rndLoc.Next(55, 395);
                }

                while (losePoint4.IntersectsWith(player1))
                {
                    losePoint4.X = rndLoc.Next(55, 485);
                    losePoint4.Y = rndLoc.Next(55, 395);
                }

                while (losePoint4.IntersectsWith(player2))
                {
                    losePoint4.X = rndLoc.Next(55, 485);
                    losePoint4.Y = rndLoc.Next(55, 395);
                }

                while (losePoint5.IntersectsWith(player1))
                {
                    losePoint5.X = rndLoc.Next(55, 485);
                    losePoint5.Y = rndLoc.Next(55, 395);
                }

                while (losePoint5.IntersectsWith(player2))
                {
                    losePoint5.X = rndLoc.Next(55, 485);
                    losePoint5.Y = rndLoc.Next(55, 395);
                }

                while (losePoint6.IntersectsWith(player1))
                {
                    losePoint6.X = rndLoc.Next(55, 485);
                    losePoint6.Y = rndLoc.Next(55, 395);
                }

                while (losePoint6.IntersectsWith(player2))
                {
                    losePoint6.X = rndLoc.Next(55, 485);
                    losePoint6.Y = rndLoc.Next(55, 395);
                }

                while (losePoint7.IntersectsWith(player1))
                {
                    losePoint7.X = rndLoc.Next(55, 485);
                    losePoint7.Y = rndLoc.Next(55, 395);
                }

                while (losePoint7.IntersectsWith(player2))
                {
                    losePoint7.X = rndLoc.Next(55, 485);
                    losePoint7.Y = rndLoc.Next(55, 395);
                }

                while (losePoint8.IntersectsWith(player1))
                {
                    losePoint8.X = rndLoc.Next(55, 485);
                    losePoint8.Y = rndLoc.Next(55, 395);
                }

                while (losePoint8.IntersectsWith(player2))
                {
                    losePoint8.X = rndLoc.Next(55, 485);
                    losePoint8.Y = rndLoc.Next(55, 395);
                }

                while (losePoint9.IntersectsWith(player1))
                {
                    losePoint9.X = rndLoc.Next(55, 485);
                    losePoint9.Y = rndLoc.Next(55, 395);
                }

                while (losePoint9.IntersectsWith(player2))
                {
                    losePoint9.X = rndLoc.Next(55, 485);
                    losePoint9.Y = rndLoc.Next(55, 395);
                }

                while (losePoint10.IntersectsWith(player1))
                {
                    losePoint10.X = rndLoc.Next(55, 485);
                    losePoint10.Y = rndLoc.Next(55, 395);
                }

                while (losePoint10.IntersectsWith(player2))
                {
                    losePoint10.X = rndLoc.Next(55, 485);
                    losePoint10.Y = rndLoc.Next(55, 395);
                }

                while (losePoint11.IntersectsWith(player1))
                {
                    losePoint11.X = rndLoc.Next(55, 485);
                    losePoint11.Y = rndLoc.Next(55, 395);
                }

                while (losePoint11.IntersectsWith(player2))
                {
                    losePoint11.X = rndLoc.Next(55, 485);
                    losePoint11.Y = rndLoc.Next(55, 395);
                }

                while (losePoint12.IntersectsWith(player1))
                {
                    losePoint12.X = rndLoc.Next(55, 485);
                    losePoint12.Y = rndLoc.Next(55, 395);
                }

                while (losePoint12.IntersectsWith(player2))
                {
                    losePoint12.X = rndLoc.Next(55, 485);
                    losePoint12.Y = rndLoc.Next(55, 395);
                }

                while (losePoint13.IntersectsWith(player1))
                {
                    losePoint13.X = rndLoc.Next(55, 485);
                    losePoint13.Y = rndLoc.Next(55, 395);
                }

                while (losePoint13.IntersectsWith(player2))
                {
                    losePoint13.X = rndLoc.Next(55, 485);
                    losePoint13.Y = rndLoc.Next(55, 395);
                }

                while (losePoint14.IntersectsWith(player1))
                {
                    losePoint14.X = rndLoc.Next(55, 485);
                    losePoint14.Y = rndLoc.Next(55, 395);
                }

                while (losePoint14.IntersectsWith(player2))
                {
                    losePoint14.X = rndLoc.Next(55, 485);
                    losePoint14.Y = rndLoc.Next(55, 395);
                }

                while (losePoint15.IntersectsWith(player1))
                {
                    losePoint15.X = rndLoc.Next(55, 485);
                    losePoint15.Y = rndLoc.Next(55, 395);
                }

                while (losePoint15.IntersectsWith(player2))
                {
                    losePoint15.X = rndLoc.Next(55, 485);
                    losePoint15.Y = rndLoc.Next(55, 395);
                }
            }
        }

        private void squareChaser_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
            }
        }

        private void squareChaser_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            //power bar timer at the bottom of the screen

            powerTimer--;
            power2Timer--;
           

            if (player1Speed == 8)
            {
                p1Bar = new Rectangle(30, 440, 4 * powerTimer, 10);
            }
            
            if (powerTimer == 0)
            {
                power.X = rndLoc.Next(55, 485);
                power.Y = rndLoc.Next(55, 395);
                player1Speed = 5;
                powerTimer = 100;
                p1Bar = new Rectangle(30, 440, 0, 10);
            }

            if (player2Speed == 8)
            {
                p2Bar = new Rectangle(335, 440, 4 * power2Timer, 10);
            }

            if (power2Timer == 0)
            {
                power.X = rndLoc.Next(55, 485);
                power.Y = rndLoc.Next(55, 395);
                player2Speed = 5;
                power2Timer = 100;
                p2Bar = new Rectangle(335, 440, 0, 10);
            }

            //move player 1
            if (wDown == true && player1.Y > 50)
            {
                player1.Y -= player1Speed;
            }

            if (aDown == true && player1.X > 50)
            {
                player1.X -= player1Speed;
            }

            if (sDown == true && player1.Y < 415 - player1.Height)
            {
                player1.Y += player1Speed;
            }

            if (dDown == true && player1.X < 515 - player1.Height)
            {
                player1.X += player1Speed;
            }

            //move player 2
            if (upArrowDown == true && player2.Y > 50)
            {
                player2.Y -= player2Speed;
            }

            if (rightArrowDown == true && player2.X < 515 - player1.Height)
            {
                player2.X += player2Speed;
            }

            if (downArrowDown == true && player2.Y < 415 - player1.Height)
            {
                player2.Y += player2Speed;
            }

            if (leftArrowDown == true && player2.X > 50)
            {
                player2.X -= player2Speed;
            }

            //player intersecting with point orb
            if (player1.IntersectsWith(point))
            {
                player1Score++;
                p1ScoreLabel.Text = $"{player1Score}";
                point.X = rndLoc.Next(55, 485);
                point.Y = rndLoc.Next(55, 395);
            }
            else if (player2.IntersectsWith(point))
            {
                player2Score++;
                p2ScoreLabel.Text = $"{player2Score}";
                point.X = rndLoc.Next(55, 485);
                point.Y = rndLoc.Next(55, 395);
            }

            //player intersecting with lose point orb
            {
                if (player1.IntersectsWith(losePoint))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint.X = rndLoc.Next(55, 485);
                    losePoint.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint.X = rndLoc.Next(55, 485);
                    losePoint.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint2))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint2.X = rndLoc.Next(55, 485);
                    losePoint2.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint2))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint2.X = rndLoc.Next(55, 485);
                    losePoint2.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint3))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint3.X = rndLoc.Next(55, 485);
                    losePoint3.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint3))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint3.X = rndLoc.Next(55, 485);
                    losePoint3.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint4))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint4.X = rndLoc.Next(55, 485);
                    losePoint4.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint4))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint4.X = rndLoc.Next(55, 485);
                    losePoint4.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint5))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint5.X = rndLoc.Next(55, 485);
                    losePoint5.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint5))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint5.X = rndLoc.Next(55, 485);
                    losePoint5.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint6))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint6.X = rndLoc.Next(55, 485);
                    losePoint6.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint6))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint6.X = rndLoc.Next(55, 485);
                    losePoint6.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint7))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint7.X = rndLoc.Next(55, 485);
                    losePoint7.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint7))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint7.X = rndLoc.Next(55, 485);
                    losePoint7.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint8))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint8.X = rndLoc.Next(55, 485);
                    losePoint8.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint8))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint8.X = rndLoc.Next(55, 485);
                    losePoint8.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint9))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint9.X = rndLoc.Next(55, 485);
                    losePoint9.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint9))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint9.X = rndLoc.Next(55, 485);
                    losePoint9.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint10))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint10.X = rndLoc.Next(55, 485);
                    losePoint10.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint10))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint10.X = rndLoc.Next(55, 485);
                    losePoint10.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint11))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint11.X = rndLoc.Next(55, 485);
                    losePoint11.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint11))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint11.X = rndLoc.Next(55, 485);
                    losePoint11.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint12))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint12.X = rndLoc.Next(55, 485);
                    losePoint12.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint12))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint12.X = rndLoc.Next(55, 485);
                    losePoint12.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint13))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint13.X = rndLoc.Next(55, 485);
                    losePoint13.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint13))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint13.X = rndLoc.Next(55, 485);
                    losePoint13.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint14))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint14.X = rndLoc.Next(55, 485);
                    losePoint14.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint14))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint14.X = rndLoc.Next(55, 485);
                    losePoint14.Y = rndLoc.Next(55, 395);
                }

                if (player1.IntersectsWith(losePoint15))
                {
                    player1Score--;
                    p1ScoreLabel.Text = $"{player1Score}";
                    losePoint15.X = rndLoc.Next(55, 485);
                    losePoint15.Y = rndLoc.Next(55, 395);
                }
                else if (player2.IntersectsWith(losePoint15))
                {
                    player2Score--;
                    p2ScoreLabel.Text = $"{player2Score}";
                    losePoint15.X = rndLoc.Next(55, 485);
                    losePoint15.Y = rndLoc.Next(55, 395);
                }
            }

            //player intersecting with power orb
            if (player1.IntersectsWith(power) && powerTimer < 50)
            {
                player1Speed = 8;
                power.X = rndLoc.Next(30, 516);
                power.Y = rndLoc.Next(50, 416);
                powerTimer = 50;

            }
            else if (player2.IntersectsWith(power) && powerTimer < 50)
            {
                player2Speed = 8;
                power.X = rndLoc.Next(30, 416);
                power.Y = rndLoc.Next(50, 516);
                power2Timer = 50;
            }

            //preventing negative point values
            if (player1Score < 0)
            {
                player1Score = 0;
                p1ScoreLabel.Text = $"{player1Score}";
            }
            if (player2Score < 0)
            {
                player2Score = 0;
                p2ScoreLabel.Text = $"{player2Score}";
            }

            //if the score is 3 player wins
            if (player1Score == 5)
            {
                winLabel.Visible = true;
                winLabel.Text = $"Player 1 wins!";
                player1Speed = 0;
                player2Speed = 0;
                gameMusic.Stop();
            }
            else if (player2Score == 5)
            {
                winLabel.Visible = true;
                winLabel.Text = $"Player 2 wins!";
                player1Speed = 0;
                player2Speed = 0;
                gameMusic.Stop();
            }

            Refresh();
        }

        private void squareChaser_Paint(object sender, PaintEventArgs e)
        {
            //model graphics
            e.Graphics.FillRectangle(whiteBrush, point);
            

            if (powerTimer < 50)
            {
                e.Graphics.FillRectangle(yellowBrush, power);
            }

            //15 lose point graphics 
            {
                e.Graphics.FillRectangle(greenBrush, player1);
                e.Graphics.FillRectangle(orangeBrush, player2);
                e.Graphics.FillRectangle(redBrush, losePoint);
                e.Graphics.FillRectangle(redBrush, losePoint2);
                e.Graphics.FillRectangle(redBrush, losePoint3);
                e.Graphics.FillRectangle(redBrush, losePoint4);
                e.Graphics.FillRectangle(redBrush, losePoint5);
                e.Graphics.FillRectangle(redBrush, losePoint6);
                e.Graphics.FillRectangle(redBrush, losePoint7);
                e.Graphics.FillRectangle(redBrush, losePoint8);
                e.Graphics.FillRectangle(redBrush, losePoint9);
                e.Graphics.FillRectangle(redBrush, losePoint10);
                e.Graphics.FillRectangle(redBrush, losePoint11);
                e.Graphics.FillRectangle(redBrush, losePoint12);
                e.Graphics.FillRectangle(redBrush, losePoint13);
                e.Graphics.FillRectangle(redBrush, losePoint14);
                e.Graphics.FillRectangle(redBrush, losePoint15);
            }

            //barrier graphics
            e.Graphics.FillRectangle(blueBrush, leftBarrier);
            e.Graphics.FillRectangle(blueBrush, topBarrier);
            e.Graphics.FillRectangle(blueBrush, rightBarrier);
            e.Graphics.FillRectangle(blueBrush, bottomBarrier);

            //power bar grapics
            e.Graphics.FillRectangle(greenBrush, p1Bar);
            e.Graphics.FillRectangle(orangeBrush, p2Bar);
        }
    }
}
