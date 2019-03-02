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
            pnlAirStripStart.BorderStyle = BorderStyle.None;
            pnlAirStripEnd.BorderStyle = BorderStyle.None;
            pnlAttackStrip.BorderStyle = BorderStyle.None;
            pnlOnstacleZone.BorderStyle = BorderStyle.None;
        }
    }
}
