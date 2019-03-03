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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addObstaclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllObstaclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAirStripEnd = new System.Windows.Forms.Panel();
            this.pnlAirStripStart = new System.Windows.Forms.Panel();
            this.pnlTitan = new System.Windows.Forms.Panel();
            this.pbObstacleZone = new System.Windows.Forms.PictureBox();
            this.pnlAttackStart = new System.Windows.Forms.Panel();
            this.pnlAttackEnd = new System.Windows.Forms.Panel();
            this.picJet = new System.Windows.Forms.PictureBox();
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
            // pnlAirStripEnd
            // 
            this.pnlAirStripEnd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAirStripEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAirStripEnd.Location = new System.Drawing.Point(214, 220);
            this.pnlAirStripEnd.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAirStripEnd.Name = "pnlAirStripEnd";
            this.pnlAirStripEnd.Size = new System.Drawing.Size(18, 19);
            this.pnlAirStripEnd.TabIndex = 1;
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
            // pnlAttackStart
            // 
            this.pnlAttackStart.BackColor = System.Drawing.Color.Transparent;
            this.pnlAttackStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAttackStart.Location = new System.Drawing.Point(798, 139);
            this.pnlAttackStart.Name = "pnlAttackStart";
            this.pnlAttackStart.Size = new System.Drawing.Size(18, 19);
            this.pnlAttackStart.TabIndex = 5;
            // 
            // pnlAttackEnd
            // 
            this.pnlAttackEnd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAttackEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAttackEnd.Location = new System.Drawing.Point(767, 386);
            this.pnlAttackEnd.Name = "pnlAttackEnd";
            this.pnlAttackEnd.Size = new System.Drawing.Size(18, 19);
            this.pnlAttackEnd.TabIndex = 7;
            // 
            // picJet
            // 
            this.picJet.BackColor = System.Drawing.Color.Transparent;
            this.picJet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picJet.BackgroundImage")));
            this.picJet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picJet.Location = new System.Drawing.Point(142, 179);
            this.picJet.Name = "picJet";
            this.picJet.Size = new System.Drawing.Size(34, 34);
            this.picJet.TabIndex = 8;
            this.picJet.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.picJet);
            this.Controls.Add(this.pnlAttackEnd);
            this.Controls.Add(this.pnlAttackStart);
            this.Controls.Add(this.pnlAirStripStart);
            this.Controls.Add(this.pnlTitan);
            this.Controls.Add(this.pnlAirStripEnd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbObstacleZone);
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
        private System.Windows.Forms.Panel pnlAirStripEnd;
        private System.Windows.Forms.Panel pnlAirStripStart;
        private System.Windows.Forms.Panel pnlTitan;
        private System.Windows.Forms.PictureBox pbObstacleZone;
        private System.Windows.Forms.Panel pnlAttackStart;
        private System.Windows.Forms.Panel pnlAttackEnd;
        private System.Windows.Forms.PictureBox picJet;
    }
}

