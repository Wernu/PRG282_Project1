namespace Project_PRG282
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addObstaclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllObstaclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAirStripStart = new System.Windows.Forms.Panel();
            this.pnlTitan = new System.Windows.Forms.Panel();
            this.pbObstacleZone = new System.Windows.Forms.PictureBox();
            this.picJet = new System.Windows.Forms.PictureBox();
            this.timeMove = new System.Windows.Forms.Timer(this.components);
            this.pnlEnemyBase = new System.Windows.Forms.Panel();
            this.timeMoveBack = new System.Windows.Forms.Timer(this.components);
            this.pnlReturnBase = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacleZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addObstaclesToolStripMenuItem,
            this.removeAllObstaclesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addObstaclesToolStripMenuItem
            // 
            this.addObstaclesToolStripMenuItem.Name = "addObstaclesToolStripMenuItem";
            this.addObstaclesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addObstaclesToolStripMenuItem.Text = "Open Obstacle Menu";
            this.addObstaclesToolStripMenuItem.Click += new System.EventHandler(this.addObstaclesToolStripMenuItem_Click);
            // 
            // removeAllObstaclesToolStripMenuItem
            // 
            this.removeAllObstaclesToolStripMenuItem.Name = "removeAllObstaclesToolStripMenuItem";
            this.removeAllObstaclesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.removeAllObstaclesToolStripMenuItem.Text = "Close Obstacle Menu";
            this.removeAllObstaclesToolStripMenuItem.Click += new System.EventHandler(this.removeAllObstaclesToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnlAirStripStart
            // 
            this.pnlAirStripStart.BackColor = System.Drawing.Color.Transparent;
            this.pnlAirStripStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAirStripStart.Location = new System.Drawing.Point(69, 213);
            this.pnlAirStripStart.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAirStripStart.Name = "pnlAirStripStart";
            this.pnlAirStripStart.Size = new System.Drawing.Size(18, 19);
            this.pnlAirStripStart.TabIndex = 2;
            // 
            // pnlTitan
            // 
            this.pnlTitan.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitan.Location = new System.Drawing.Point(28, 47);
            this.pnlTitan.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitan.Name = "pnlTitan";
            this.pnlTitan.Size = new System.Drawing.Size(24, 27);
            this.pnlTitan.TabIndex = 4;
            // 
            // pbObstacleZone
            // 
            this.pbObstacleZone.BackColor = System.Drawing.Color.Transparent;
            this.pbObstacleZone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbObstacleZone.Location = new System.Drawing.Point(345, 25);
            this.pbObstacleZone.Margin = new System.Windows.Forms.Padding(2);
            this.pbObstacleZone.Name = "pbObstacleZone";
            this.pbObstacleZone.Size = new System.Drawing.Size(328, 424);
            this.pbObstacleZone.TabIndex = 0;
            this.pbObstacleZone.TabStop = false;
            // 
            // picJet
            // 
            this.picJet.BackColor = System.Drawing.Color.Transparent;
            this.picJet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picJet.BackgroundImage")));
            this.picJet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picJet.Location = new System.Drawing.Point(133, 106);
            this.picJet.Name = "picJet";
            this.picJet.Size = new System.Drawing.Size(34, 34);
            this.picJet.TabIndex = 8;
            this.picJet.TabStop = false;
            // 
            // pnlEnemyBase
            // 
            this.pnlEnemyBase.BackColor = System.Drawing.Color.Transparent;
            this.pnlEnemyBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEnemyBase.Location = new System.Drawing.Point(772, 180);
            this.pnlEnemyBase.Name = "pnlEnemyBase";
            this.pnlEnemyBase.Size = new System.Drawing.Size(125, 223);
            this.pnlEnemyBase.TabIndex = 9;
            // 
            // pnlReturnBase
            // 
            this.pnlReturnBase.BackColor = System.Drawing.Color.Transparent;
            this.pnlReturnBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReturnBase.Location = new System.Drawing.Point(12, 180);
            this.pnlReturnBase.Name = "pnlReturnBase";
            this.pnlReturnBase.Size = new System.Drawing.Size(83, 110);
            this.pnlReturnBase.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.picJet);
            this.Controls.Add(this.pnlTitan);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbObstacleZone);
            this.Controls.Add(this.pnlReturnBase);
            this.Controls.Add(this.pnlEnemyBase);
            this.Controls.Add(this.pnlAirStripStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacleZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addObstaclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllObstaclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAirStripStart;
        private System.Windows.Forms.Panel pnlTitan;
        private System.Windows.Forms.PictureBox pbObstacleZone;
        private System.Windows.Forms.PictureBox picJet;
        private System.Windows.Forms.Timer timeMove;
        private System.Windows.Forms.Panel pnlEnemyBase;
        private System.Windows.Forms.Timer timeMoveBack;
        private System.Windows.Forms.Panel pnlReturnBase;
    }
}

