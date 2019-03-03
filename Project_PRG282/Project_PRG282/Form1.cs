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


        private void Form1_Load(object sender, EventArgs e)
        { 
            //Creating obstacle menu
            pnlTitan.Enabled = false;
            ControlExtension.Draggable(pnlTitan, true);

            //Hiding zones (Obstacle zone, running strip)
            pnlAirStripStart.BorderStyle = BorderStyle.None;
            pbObstacleZone.BorderStyle = BorderStyle.None;
            pnlEnemyBase.BorderStyle = BorderStyle.None;
            pnlTitan.BorderStyle = BorderStyle.None;
            pnlReturnBase.BorderStyle = BorderStyle.None;

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
            pnlTitan.BackColor = Color.Black;
            pbObstacleZone.BackColor = Color.Red;
        }

        //Hiding Obstacle Menu
        private void removeAllObstaclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = true;
            pbObstacleZone.BackColor = Color.Transparent;

            //Keeping dragabels
            if (pnlTitan.Location.X > pbObstacleZone.Location.X && pnlTitan.Location.X + pnlTitan.Width < pbObstacleZone.Location.X + pbObstacleZone.Width)
            { 
                check = false;
            }
            else
            {
                MessageBox.Show("Obstacles can only be place in the red zone");
            }
            if (check)
            {
                pnlTitan.BackColor = Color.Transparent;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;
            timeMove.Start();
            timeMove.Interval = 1;
            timeMove.Tick += Move;

        }

        public void Move (object sender, EventArgs e)
        {


            Rectangle recJet = new Rectangle(picJet.Location.X, picJet.Location.Y, picJet.Width, picJet.Height);
            Rectangle recEBase = new Rectangle(pnlEnemyBase.Location.X, pnlEnemyBase.Location.Y, pnlEnemyBase.Width, pnlEnemyBase.Height);

            bool isCollision = recJet.IntersectsWith(recEBase);

            

            if (isCollision)
            {
               
                timeMove.Stop();
                ReturnBase();
            }
            else
            {
                picJet.Location = new Point(picJet.Location.X + 5, picJet.Location.Y);
            }

          

        }


        public void ReturnBase()
        {
            Image imgJet2 = picJet.BackgroundImage;
            imgJet2.RotateFlip(RotateFlipType.Rotate180FlipNone);
            picJet.BackgroundImage = imgJet2;

           

            timeMoveBack.Start();
            timeMoveBack.Interval = 1;
            timeMoveBack.Tick += MoveBack;

        }


        public void MoveBack(object sender, EventArgs e)
        {

            Rectangle recJet = new Rectangle(picJet.Location.X, picJet.Location.Y, picJet.Width, picJet.Height);
            Rectangle recHQBase = new Rectangle(pnlReturnBase.Location.X, pnlReturnBase.Location.Y, pnlReturnBase.Width, pnlReturnBase.Height);


            bool isCollision = recJet.IntersectsWith(recHQBase);


            if (isCollision)
            {
                EndTrip();
                timeMoveBack.Stop();
            }
            else
            {
                picJet.Location = new Point(picJet.Location.X - 5, picJet.Location.Y);
            }

            
        }

        public void EndTrip()
        {
            //Show status of damage
        }





    }
}
