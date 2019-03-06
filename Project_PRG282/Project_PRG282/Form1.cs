using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;


namespace Project_PRG282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        int height;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Randomizing enemycamp terretories
            Random r = new Random();
            randomTerritories(r.Next(1, 4));
            //Creating obstacle menu
            pnlTitan.Enabled = false;
            pnlAnza.Enabled = false;
            pnlFlakpanzer.Enabled = false;
            pnlIronDome.Enabled = false;
            pnlmachbet.Enabled = false;
            pnlPatriot.Enabled = false;
            pnlSpyder.Enabled = false;
            pnlThel.Enabled = false;
            ControlExtension.Draggable(pnlTitan, true);
            ControlExtension.Draggable(pnlAnza, true);
            ControlExtension.Draggable(pnlFlakpanzer, true);
            ControlExtension.Draggable(pnlIronDome, true);
            ControlExtension.Draggable(pnlmachbet, true);
            ControlExtension.Draggable(pnlPatriot, true);
            ControlExtension.Draggable(pnlSpyder, true);
            ControlExtension.Draggable(pnlThel, true);

            //Hiding zones (Obstacle zone, running strip)
            pnlAirStripStart.BorderStyle = BorderStyle.None;
            pbObstacleZone.BorderStyle = BorderStyle.None;
            pnlEnemyBase.BorderStyle = BorderStyle.None;
            pnlReturnBase.BorderStyle = BorderStyle.None;
            pnlTitan.BorderStyle = BorderStyle.None;
            pnlAnza.BorderStyle = BorderStyle.None;
            pnlFlakpanzer.BorderStyle = BorderStyle.None;
            pnlIronDome.BorderStyle = BorderStyle.None;
            pnlmachbet.BorderStyle = BorderStyle.None;
            pnlPatriot.BorderStyle = BorderStyle.None;
            pnlSpyder.BorderStyle = BorderStyle.None;
            pnlThel.BorderStyle = BorderStyle.None;
            pnlHQBorder.BorderStyle = BorderStyle.None;
            pnlTakeOff.BorderStyle = BorderStyle.None;
            picJetAttack.BorderStyle = BorderStyle.None;

            //Fuel Start
            FuelGauge.Value = 100;
            //Moving the jet to the start of the airstrip

            pnlAirStripStart.Hide();
            picJet.Location = new Point(pnlAirStripStart.Location.X, pnlAirStripStart.Location.Y);
            picJet.BorderStyle = BorderStyle.None;
            //Rotating the jet

            Image imgJet = picJet.BackgroundImage;
            imgJet.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picJet.BackgroundImage = imgJet;

            picJetAttack.Hide();

        }

        //Displaying Obstacle Menu
        private void addObstaclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlTitan.Enabled = true;
            pnlAnza.Enabled = true;
            pnlFlakpanzer.Enabled = true;
            pnlIronDome.Enabled = true;
            pnlmachbet.Enabled = true;
            pnlPatriot.Enabled = true;
            pnlSpyder.Enabled = true;
            pnlThel.Enabled = true;
            pnlTitan.Show();
            pnlAnza.Show();
            pnlFlakpanzer.Show();
            pnlIronDome.Show();
            pnlmachbet.Show();
            pnlPatriot.Show();
            pnlSpyder.Show();
            pnlThel.Show();
            pnlTitan.BackColor = Color.Black;
            pnlAnza.BackColor = Color.Black;
            pnlFlakpanzer.BackColor = Color.Black;
            pnlIronDome.BackColor = Color.Black;
            pnlmachbet.BackColor = Color.Black;
            pnlPatriot.BackColor = Color.Black;
            pnlSpyder.BackColor = Color.Black;
            pnlThel.BackColor = Color.Black;
            pbObstacleZone.BackColor = Color.Red;
            startToolStripMenuItem.Enabled = false;
        }

        //Hiding Obstacle Menu
        private void removeAllObstaclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbObstacleZone.BackColor = Color.Transparent;
            checkObstacles(pnlTitan);
            checkObstacles(pnlAnza);
            checkObstacles(pnlFlakpanzer);
            checkObstacles(pnlIronDome);
            checkObstacles(pnlmachbet);
            checkObstacles(pnlPatriot);
            checkObstacles(pnlSpyder);
            checkObstacles(pnlThel);
            startToolStripMenuItem.Enabled = true;
        }
        //Checking if obstacles are outside the obstacle Zone
        public void checkObstacles(Panel obstacle)
        {
            if (obstacle.Location.X > pbObstacleZone.Location.X && obstacle.Location.X + obstacle.Width < pbObstacleZone.Location.X + pbObstacleZone.Width)
            {

            }
            else
            {
                obstacle.Enabled = false;
                obstacle.Hide();
                obstacle.BackColor = Color.Transparent;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;
            timeMove.Start();
            timeMove.Interval = 50;
            timeMove.Tick += MoveJet;

            timeObjectMove.Start();
            timeObjectMove.Interval = 120;
            timeObjectMove.Tick += MoveObject;
        }

        int X1 = -5;
        int X2 = 5;
        int Y1 = -5;
        int Y2 = 5;
        public void MoveObject(object sender, EventArgs e)
        {
            Random r = new Random();
            ObjectsMovement(pnlTitan, r.Next(X1, X2), r.Next(Y1, Y2));
            ObjectsMovement(pnlAnza, r.Next(X1, X2), r.Next(Y1, Y2));
            ObjectsMovement(pnlFlakpanzer, r.Next(X1, X2), r.Next(Y1, Y2));
            ObjectsMovement(pnlIronDome, r.Next(X1, X2), r.Next(Y1, Y2));
            ObjectsMovement(pnlmachbet, r.Next(X1, X2), r.Next(Y1, Y2));
            ObjectsMovement(pnlPatriot, r.Next(X1, X2), r.Next(Y1, Y2));
            ObjectsMovement(pnlSpyder, r.Next(X1, X2), r.Next(Y1, Y2));
            ObjectsMovement(pnlThel, r.Next(X1, X2), r.Next(Y1, Y2));
        }
        //Moves the objects inside the area
        public void ObjectsMovement(Panel obstacle, int X, int Y)
        {

            if (obstacle.Enabled == true)
            {
                obstacle.Location = new Point(obstacle.Location.X + X, obstacle.Location.Y + Y);
                if (obstacle.Location.X <= pbObstacleZone.Location.X)
                {
                    obstacle.Location = new Point(obstacle.Location.X + 5, obstacle.Location.Y);
                    X1 = -1;
                    X2 = 7;
                }
                if (obstacle.Location.X + obstacle.Width >= pbObstacleZone.Location.X + pbObstacleZone.Width)
                {
                    obstacle.Location = new Point(obstacle.Location.X - 5, obstacle.Location.Y);
                    X1 = -7;
                    X2 = 1;
                }
                if (obstacle.Location.Y <= pbObstacleZone.Location.Y)
                {
                    obstacle.Location = new Point(obstacle.Location.X, obstacle.Location.Y + 5);
                    Y1 = -1;
                    Y2 = 7;
                }
                if (obstacle.Location.Y + obstacle.Height >= pbObstacleZone.Location.Y + pbObstacleZone.Height)
                {
                    obstacle.Location = new Point(obstacle.Location.X, obstacle.Location.Y - 5);
                    Y1 = -7;
                    Y2 = 1;
                }
            }
        }
        //Launches jet from HQ to enemy base
        int speed;
        public void MoveJet(object sender, EventArgs e)
        {
            Rectangle recJet = new Rectangle(picJet.Location.X, picJet.Location.Y, picJet.Width, picJet.Height);
            Rectangle recEBase = new Rectangle(pnlEnemyBase.Location.X, pnlEnemyBase.Location.Y, pnlEnemyBase.Width, pnlEnemyBase.Height);

            bool isCollision = recJet.IntersectsWith(recEBase);

            if (height < 31000)
            {
                height += 1000;
                lblHeight.Text = height.ToString() + " feet";

            }

            if (speed < 900)
            {
                speed += 50;
                lblSpeed.Text = speed.ToString() + " km/hr";
            }


            if (isCollision)
            {
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                timeMove.Stop();
                ReturnBase();
            }

            else
            {
                picJet.Location = new Point(picJet.Location.X + 5, picJet.Location.Y);
                Thread thDodge = new Thread(DodgeObject);
                thDodge.Start();
            }

        }

        public void ReturnBaseAttack()
        {
            Image imgJet = picJetAttack.BackgroundImage;
            imgJet.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picJetAttack.BackgroundImage = imgJet;

            timeMoveAttackJet.Start();
            timeMoveAttackJet.Interval = 50;
            timeMoveAttackJet.Tick += MoveBackAttack;

        }

        bool check = true;
        public void MoveBackAttack(object sender, EventArgs e)
        {
            Rectangle recJetAttack = new Rectangle(picJetAttack.Location.X, picJetAttack.Location.Y, picJetAttack.Width, picJetAttack.Height);
            Rectangle recHQBase = new Rectangle(pnlReturnBase.Location.X, pnlReturnBase.Location.Y, pnlReturnBase.Width, pnlReturnBase.Height);
            Rectangle recHQborder = new Rectangle(pnlHQBorder.Location.X, pnlHQBorder.Location.Y, pnlHQBorder.Width, pnlHQBorder.Height);
            bool isCollision_Base = recJetAttack.IntersectsWith(recHQBase);
            bool isCollision_Border = recJetAttack.IntersectsWith(recHQborder);


            if (isCollision_Base)
            {
                timeMoveBackAttack.Stop();
            }
            else
            {
                picJetAttack.Location = new Point(picJetAttack.Location.X - 5, picJetAttack.Location.Y);
            }

            if (check)
            {
                if (isCollision_Border)
                {
                    if (picJetAttack.Location.Y > pnlHQBorder.Location.Y)
                    {
                        RePositionUpAttack();
                        check = false;
                    }
                }
            }




            Thread thDodge = new Thread(DodgeObject);
            thDodge.Start();
        }

        public void ReturnBase()
        {
            Image imgJet2 = picJet.BackgroundImage;
            imgJet2.RotateFlip(RotateFlipType.Rotate180FlipNone);
            picJet.BackgroundImage = imgJet2;
            


            timeMoveBack.Start();
            timeMoveBack.Interval = 50;
            timeMoveBack.Tick += MoveBack;


        }
        bool check1 = true;
        public void MoveBack(object sender, EventArgs e)
        {

            Rectangle recJet = new Rectangle(picJet.Location.X, picJet.Location.Y, picJet.Width, picJet.Height);
            Rectangle recHQBase = new Rectangle(pnlReturnBase.Location.X, pnlReturnBase.Location.Y, pnlReturnBase.Width, pnlReturnBase.Height);
            Rectangle recHQborder = new Rectangle(pnlHQBorder.Location.X, pnlHQBorder.Location.Y, pnlHQBorder.Width, pnlHQBorder.Height);
            bool isCollision_Base = recJet.IntersectsWith(recHQBase);
            bool isCollision_Border = recJet.IntersectsWith(recHQborder);


            if (isCollision_Base)
            {
                
                timeMoveBack.Stop();
            }
            else
            {
                picJet.Location = new Point(picJet.Location.X - 5, picJet.Location.Y);
            }

            if (check1)
            {
                if (isCollision_Border)
                {
                    if (picJet.Location.Y > pnlHQBorder.Location.Y)
                    {
                        RePositionUp();
                        check = false;
                    }
                }
            }




            Thread thDodge = new Thread(DodgeObject);
            thDodge.Start();


        }

        public void RePositionUpAttack()
        {
            Image imgJet2 = picJetAttack.BackgroundImage;
            imgJet2.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picJetAttack.BackgroundImage = imgJet2;

            timeAttackJetMoveUp.Start();
            timeAttackJetMoveUp.Interval = 50;
            timeAttackJetMoveUp.Tick += RePositionUpAttacks;
        }

        public void RePositionUpAttacks(object sender, EventArgs e)
        {
            if (picJetAttack.Location.Y == pnlAirStripStart.Location.Y)
            {
                StraightAttack();
            }
            else
            {
                picJetAttack.Location = new Point(picJetAttack.Location.X, picJetAttack.Location.Y - 1);
                HeightDecrease();
                SpeedDecrease();
            }
        }

        public void RePositionUp()
        {
            Image imgJet2 = picJet.BackgroundImage;
            imgJet2.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picJet.BackgroundImage = imgJet2;

            timeJetMoveUp.Start();
            timeJetMoveUp.Interval = 50;
            timeJetMoveUp.Tick += RePositionUps;

        }

        public void RePositionUps(object sender, EventArgs e)
        {

            if (picJet.Location.Y == pnlAirStripStart.Location.Y)
            {
                Straight();
            }
            else
            {
                picJet.Location = new Point(picJet.Location.X, picJet.Location.Y - 1);
                HeightDecrease();
                SpeedDecrease();
            }

        }

        bool checkAgain = true;

        public void StraightAttack()
        {
            if (picJetAttack.Location.X > pnlAirStripStart.Location.X)
            {

                if (checkAgain == true)
                {
                    Image imgJet1 = picJetAttack.BackgroundImage;
                    imgJet1.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    picJetAttack.BackgroundImage = imgJet1;
                    checkAgain = false;
                }

                speed = 0;
                lblSpeed.Text = speed.ToString() + " km/hr";
                height = 0;
                lblHeight.Text = height.ToString() + " feet";

                picJetAttack.Location = new Point(picJetAttack.Location.X - 1, picJet.Location.Y);
            }
            else
            {
                timeAttackJetMoveUp.Stop();
                
            }
        }

        bool onlyOnce = true;

        public void Message()
        {
            MessageBox.Show("This shit doesn't work :(");
        }
       
        public void Straight()
        {

            if (picJet.Location.X > pnlAirStripStart.Location.X)
            {

                if (onlyOnce == true)
                {
                    Image imgJet2 = picJet.BackgroundImage;
                    imgJet2.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    picJet.BackgroundImage = imgJet2;
                    onlyOnce = false;
                }

                speed = 0;
                lblSpeed.Text = speed.ToString() + " km/hr";
                height = 0;
                lblHeight.Text = height.ToString() + " feet";

                picJet.Location = new Point(picJet.Location.X - 1, picJet.Location.Y);
            }
            else
            {
                timeJetMoveUp.Stop();
                EndTrip();
            }
        }

        public void EndTrip()
        {
            picJet.Enabled = false;
            picJet.Hide();
            picJetAttack.Location = new Point(pnlAirStripStart.Location.X, pnlAirStripStart.Location.Y);
            Image imgJetAttack = picJetAttack.BackgroundImage;
            imgJetAttack.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picJetAttack.BackgroundImage = imgJetAttack;
            picJetAttack.Show();

            timeMoveAttackJet.Start();
            timeMoveAttackJet.Interval = 50;
            timeMoveAttackJet.Tick += MoveAttackJet;
        }

        public void MoveAttackJet(object sender, EventArgs e)
        {
            Rectangle recJetAttack = new Rectangle(picJetAttack.Location.X, picJetAttack.Location.Y, picJetAttack.Width, picJet.Height);
            Rectangle recEBase = new Rectangle(pnlEnemyBase.Location.X, pnlEnemyBase.Location.Y, pnlEnemyBase.Width, pnlEnemyBase.Height);

            bool isCollision = recJetAttack.IntersectsWith(recEBase);

            if (height < 31000)
            {
                height += 1000;
                lblHeight.Text = height.ToString() + " feet";

            }

            if (speed < 900)
            {
                speed += 50;
                lblSpeed.Text = speed.ToString() + " km/hr";
            }


            if (isCollision)
            {
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                timeMoveAttackJet.Stop();
                ReturnBaseAttack();
            }

            else
            {
                picJetAttack.Location = new Point(picJetAttack.Location.X + 5, picJetAttack.Location.Y);
                Thread thDodge = new Thread(DodgeObjectAttack);
                thDodge.Start();
            }
        }

        public void DodgeObjectAttack()
        {
            Rectangle recJetAttack = new Rectangle(picJetAttack.Location.X, picJetAttack.Location.Y, picJetAttack.Width * 2, picJetAttack.Height);
            Rectangle recTitan = new Rectangle(pnlTitan.Location.X, pnlTitan.Location.Y, pnlTitan.Width, pnlTitan.Height * 2); //Height increases
            Rectangle recAnza = new Rectangle(pnlAnza.Location.X, pnlAnza.Location.Y, pnlAnza.Width, pnlAnza.Height * 2); //Height Increase
            Rectangle recFlak = new Rectangle(pnlFlakpanzer.Location.X, pnlFlakpanzer.Location.Y, pnlFlakpanzer.Width, pnlFlakpanzer.Height * 2); //Dodges
            Rectangle recIronDome = new Rectangle(pnlIronDome.Location.X, pnlIronDome.Location.Y, pnlIronDome.Width, pnlIronDome.Height * 2); //Dodges
            Rectangle recMachbet = new Rectangle(pnlmachbet.Location.X, pnlmachbet.Location.Y, pnlmachbet.Width, pnlmachbet.Height * 2); //Dodges
            Rectangle recPatriot = new Rectangle(pnlPatriot.Location.X, pnlPatriot.Location.Y, pnlPatriot.Width, pnlPatriot.Height * 2); //Dodges
            Rectangle recSpyder = new Rectangle(pnlSpyder.Location.X, pnlSpyder.Location.Y, pnlSpyder.Width, pnlSpyder.Height * 2); //Dodges
            Rectangle recThel = new Rectangle(pnlThel.Location.X, pnlThel.Location.Y, pnlThel.Width, pnlThel.Height); //Dodges

            int toAvoid = recTitan.Width;

            bool isCollision = recJetAttack.IntersectsWith(recTitan);
            bool isCollision2 = recJetAttack.IntersectsWith(recAnza);
            bool isCollision3 = recJetAttack.IntersectsWith(recFlak);
            bool isCollision4 = recJetAttack.IntersectsWith(recIronDome);
            bool isCollision5 = recJetAttack.IntersectsWith(recMachbet);
            bool isCollision6 = recJetAttack.IntersectsWith(recPatriot);
            bool isCollision7 = recJetAttack.IntersectsWith(recSpyder);
            bool isCollision8 = recJetAttack.IntersectsWith(recThel);

            if (isCollision)
            {
                if (picJetAttack.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        HeightIncrease();

                    }));

                }

            }



            if (isCollision2)
            {
                if (picJetAttack.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        HeightIncrease();
                    }));


                }


            }

            if (isCollision3)
            {

                if (picJetAttack.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {

                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJetAttack.Location = new Point(picJetAttack.Location.X, picJetAttack.Location.Y + 1);

                        }

                        SpeedIncrease();

                    }));


                }


            }

            if (isCollision4)
            {

                if (picJetAttack.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJetAttack.Location = new Point(picJetAttack.Location.X, picJetAttack.Location.Y + 1);

                        }

                        SpeedIncrease();

                    }));


                }


            }

            if (isCollision5)
            {

                if (picJetAttack.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJetAttack.Location = new Point(picJetAttack.Location.X, picJetAttack.Location.Y + 1);

                        }
                        SpeedIncrease();
                    }));


                }


            }

            if (isCollision6)
            {

                if (picJetAttack.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJetAttack.Location = new Point(picJetAttack.Location.X, picJetAttack.Location.Y + 1);

                        }
                        SpeedIncrease();
                    }));


                }


            }

            if (isCollision7)
            {
                if (picJetAttack.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJetAttack.Location = new Point(picJetAttack.Location.X, picJetAttack.Location.Y + 1);

                        }
                        SpeedIncrease();
                    }));


                }


            }

            if (isCollision8)
            {
                if (picJetAttack.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {

                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJetAttack.Location = new Point(picJetAttack.Location.X, picJetAttack.Location.Y + 1);

                        }
                        SpeedIncrease();
                    }));

                }

            }
        }
        public void DodgeObject()
        {
            Rectangle recJet = new Rectangle(picJet.Location.X, picJet.Location.Y, picJet.Width * 2, picJet.Height);
            Rectangle recTitan = new Rectangle(pnlTitan.Location.X, pnlTitan.Location.Y, pnlTitan.Width, pnlTitan.Height * 2); //Height increases
            Rectangle recAnza = new Rectangle(pnlAnza.Location.X, pnlAnza.Location.Y, pnlAnza.Width, pnlAnza.Height * 2); //Height Increase
            Rectangle recFlak = new Rectangle(pnlFlakpanzer.Location.X, pnlFlakpanzer.Location.Y, pnlFlakpanzer.Width, pnlFlakpanzer.Height * 2); //Dodges
            Rectangle recIronDome = new Rectangle(pnlIronDome.Location.X, pnlIronDome.Location.Y, pnlIronDome.Width, pnlIronDome.Height * 2); //Dodges
            Rectangle recMachbet = new Rectangle(pnlmachbet.Location.X, pnlmachbet.Location.Y, pnlmachbet.Width, pnlmachbet.Height * 2); //Dodges
            Rectangle recPatriot = new Rectangle(pnlPatriot.Location.X, pnlPatriot.Location.Y, pnlPatriot.Width, pnlPatriot.Height * 2); //Dodges
            Rectangle recSpyder = new Rectangle(pnlSpyder.Location.X, pnlSpyder.Location.Y, pnlSpyder.Width, pnlSpyder.Height * 2); //Dodges
            Rectangle recThel = new Rectangle(pnlThel.Location.X, pnlThel.Location.Y, pnlThel.Width, pnlThel.Height); //Dodges


            int toAvoid = recTitan.Width;

            bool isCollision = recJet.IntersectsWith(recTitan);
            bool isCollision2 = recJet.IntersectsWith(recAnza);
            bool isCollision3 = recJet.IntersectsWith(recFlak);
            bool isCollision4 = recJet.IntersectsWith(recIronDome);
            bool isCollision5 = recJet.IntersectsWith(recMachbet);
            bool isCollision6 = recJet.IntersectsWith(recPatriot);
            bool isCollision7 = recJet.IntersectsWith(recSpyder);
            bool isCollision8 = recJet.IntersectsWith(recThel);


            if (isCollision)
            {
                if (picJet.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        HeightIncrease();

                    }));

                }

            }



            if (isCollision2)
            {
                if (picJet.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        HeightIncrease();
                    }));


                }


            }

            if (isCollision3)
            {

                if (picJet.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {

                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJet.Location = new Point(picJet.Location.X, picJet.Location.Y + 1);

                        }

                        SpeedIncrease();

                    }));


                }


            }

            if (isCollision4)
            {

                if (picJet.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJet.Location = new Point(picJet.Location.X, picJet.Location.Y + 1);

                        }

                        SpeedIncrease();

                    }));


                }


            }

            if (isCollision5)
            {

                if (picJet.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJet.Location = new Point(picJet.Location.X, picJet.Location.Y + 1);

                        }
                        SpeedIncrease();
                    }));


                }


            }

            if (isCollision6)
            {

                if (picJet.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJet.Location = new Point(picJet.Location.X, picJet.Location.Y + 1);

                        }
                        SpeedIncrease();
                    }));


                }


            }

            if (isCollision7)
            {
                if (picJet.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJet.Location = new Point(picJet.Location.X, picJet.Location.Y + 1);

                        }
                        SpeedIncrease();
                    }));


                }


            }

            if (isCollision8)
            {
                if (picJet.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {

                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJet.Location = new Point(picJet.Location.X, picJet.Location.Y + 1);

                        }
                        SpeedIncrease();
                    }));

                }

            }

        }

        public void HeightIncrease()
        {
            height += 5;
            lblHeight.Text = height.ToString() + " feet";
        }

        public void SpeedIncrease()
        {

            speed += 50;
            lblSpeed.Text = speed.ToString() + " km/hr";

        }
        //Setting enemy base location names
        public void randomTerritories(int number)
        {
            if (number == 1)
            {
                lbl1.Text = "Armory";
                lbl2.Text = "Quaters";
                lbl3.Text = "Head Office";
                lbl4.Text = "Aid Station";
                lbl5.Text = "Mess Hall";
            }
            if (number == 2)
            {
                lbl1.Text = "Head Office";
                lbl2.Text = "Quaters";
                lbl3.Text = "Mess Hall";
                lbl4.Text = "Armory";
                lbl5.Text = "Aid Station";
            }
            if (number == 3)
            {
                lbl1.Text = "Aid Station";
                lbl2.Text = "Armory";
                lbl3.Text = "Quaters";
                lbl4.Text = "Mess Hall";
                lbl5.Text = "Head Office";
            }
        }

        public void HeightDecrease()
        {
            if (height > 0)
            {
                height -= 200;
                lblHeight.Text = height.ToString() + " feet";
            }
        }

        public void SpeedDecrease()
        {
            if (speed > 0)
            {
                speed -= 10;
                lblSpeed.Text = speed.ToString() + " km/hr";
            }
        }

    }
}
