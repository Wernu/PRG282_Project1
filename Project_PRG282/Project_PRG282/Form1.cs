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
            pnlAirStripEnd.BorderStyle = BorderStyle.None;
            pnlAttackStart.BorderStyle = BorderStyle.None;
            pnlAttackEnd.BorderStyle = BorderStyle.None;
            pbObstacleZone.BorderStyle = BorderStyle.None;
            pnlTitan.BorderStyle = BorderStyle.None;

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
            Thread thMoveEnemy = new Thread(MovingToEnemy);
            thMoveEnemy.Start();

        }

        public void MovingToEnemy()
        {

            if (picJet.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    for (int i = pnlAirStripStart.Location.X; i < pnlAttackStart.Location.X; i++)
                    {
                        for (int k = pnlAirStripStart.Location.Y; k > pnlAttackStart.Location.Y; k++)
                        {
                            picJet.Location = new Point(i,k);
                            Thread.Sleep(30);
                        }
                    }
                    

                }));


            }

          
        }

    }
}
