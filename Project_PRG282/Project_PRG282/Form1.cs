using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
