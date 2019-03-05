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

            //Moving the jet to the start of the airstrip

            pnlAirStripStart.Hide();
            picJet.Location = new Point(pnlAirStripStart.Location.X, pnlAirStripStart.Location.Y);
            picJet.BorderStyle = BorderStyle.None;
            //Rotating the jet

            Image imgJet = picJet.BackgroundImage;
            imgJet.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picJet.BackgroundImage = imgJet;
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
        bool minHeightReached;
        public void MoveJet(object sender, EventArgs e)
        {
            Rectangle recJet = new Rectangle(picJet.Location.X, picJet.Location.Y, picJet.Width, picJet.Height);
            Rectangle recEBase = new Rectangle(pnlEnemyBase.Location.X, pnlEnemyBase.Location.Y, pnlEnemyBase.Width, pnlEnemyBase.Height);
          
            bool isCollision = recJet.IntersectsWith(recEBase);

            if (height < 31000)
            {
                height = height + 1000;
                lblHeight.Text = height.ToString() + " feet";
            }



            if (isCollision)
            {
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


        public void ReturnBase()
        {
            Image imgJet2 = picJet.BackgroundImage;
            imgJet2.RotateFlip(RotateFlipType.Rotate180FlipNone);
            picJet.BackgroundImage = imgJet2;



            timeMoveBack.Start();
            timeMoveBack.Interval = 50;
            timeMoveBack.Tick += MoveBack;

        }
        bool check = true;
        public void MoveBack(object sender, EventArgs e)
        {

            Rectangle recJet = new Rectangle(picJet.Location.X, picJet.Location.Y, picJet.Width, picJet.Height);
            Rectangle recHQBase = new Rectangle(pnlReturnBase.Location.X, pnlReturnBase.Location.Y, pnlReturnBase.Width, pnlReturnBase.Height);
            Rectangle recHQborder = new Rectangle(pnlHQBorder.Location.X, pnlHQBorder.Location.Y, pnlHQBorder.Width, pnlHQBorder.Height);
            bool isCollision_Base = recJet.IntersectsWith(recHQBase);
            bool isCollision_Border = recJet.IntersectsWith(recHQborder);


            if (isCollision_Base)
            {
                EndTrip();
                timeMoveBack.Stop();
            }
            else
            {
                picJet.Location = new Point(picJet.Location.X - 5, picJet.Location.Y);
            }

            if (check)
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
            }

        }
        bool onlyOnce = true;
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

                picJet.Location = new Point(picJet.Location.X - 1, picJet.Location.Y);
            }
            else
            {
                timeJetMoveUp.Stop();
            }
        }

        public void EndTrip()
        {
            //Show status of damage, fuel etc..
        }

        public void DodgeObject()
        {
            Rectangle recJet = new Rectangle(picJet.Location.X, picJet.Location.Y, picJet.Width * 2, picJet.Height);
            Rectangle recTitan = new Rectangle(pnlTitan.Location.X, pnlTitan.Location.Y, pnlTitan.Width, pnlTitan.Height * 2);
            Rectangle recAnza = new Rectangle(pnlAnza.Location.X, pnlAnza.Location.Y, pnlAnza.Width, pnlAnza.Height * 2);
            Rectangle recFlak = new Rectangle(pnlFlakpanzer.Location.X, pnlFlakpanzer.Location.Y, pnlFlakpanzer.Width, pnlFlakpanzer.Height * 2);
            Rectangle recIronDome = new Rectangle(pnlIronDome.Location.X, pnlIronDome.Location.Y, pnlIronDome.Width, pnlIronDome.Height * 2);
            Rectangle recMachbet = new Rectangle(pnlmachbet.Location.X, pnlmachbet.Location.Y, pnlmachbet.Width, pnlmachbet.Height * 2);
            Rectangle recPatriot = new Rectangle(pnlPatriot.Location.X, pnlPatriot.Location.Y, pnlPatriot.Width, pnlPatriot.Height * 2);
            Rectangle recSpyder = new Rectangle(pnlSpyder.Location.X, pnlSpyder.Location.Y, pnlSpyder.Width, pnlSpyder.Height * 2);
            Rectangle recThel = new Rectangle(pnlThel.Location.X, pnlThel.Location.Y, pnlThel.Width, pnlThel.Height);


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
                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJet.Location = new Point(picJet.Location.X, picJet.Location.Y + 1);

                        }



                    }));


                }


            }


            if (isCollision2)
            {

                if (picJet.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {

                        for (int i = 0; i < toAvoid; i++)
                        {
                            picJet.Location = new Point(picJet.Location.X, picJet.Location.Y + 1);

                        }



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



                    }));


                }


            }



        }

    }
}
