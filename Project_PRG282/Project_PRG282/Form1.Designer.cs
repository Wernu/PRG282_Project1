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
            this.pnlJet = new System.Windows.Forms.Panel();
            this.pnlAttackStrip = new System.Windows.Forms.Panel();
            this.pnlAirStripEnd = new System.Windows.Forms.Panel();
            this.pnlAirStripStart = new System.Windows.Forms.Panel();
            this.pnlOnstacleZone = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addObstaclesToolStripMenuItem,
            this.removeAllObstaclesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addObstaclesToolStripMenuItem
            // 
            this.addObstaclesToolStripMenuItem.Name = "addObstaclesToolStripMenuItem";
            this.addObstaclesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.addObstaclesToolStripMenuItem.Text = "Add Obstacles";
            // 
            // removeAllObstaclesToolStripMenuItem
            // 
            this.removeAllObstaclesToolStripMenuItem.Name = "removeAllObstaclesToolStripMenuItem";
            this.removeAllObstaclesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.removeAllObstaclesToolStripMenuItem.Text = "Remove All Obstacles";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnlJet
            // 
            this.pnlJet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlJet.BackColor = System.Drawing.Color.Transparent;
            this.pnlJet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlJet.BackgroundImage")));
            this.pnlJet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlJet.Location = new System.Drawing.Point(208, 358);
            this.pnlJet.Margin = new System.Windows.Forms.Padding(4);
            this.pnlJet.Name = "pnlJet";
            this.pnlJet.Size = new System.Drawing.Size(43, 40);
            this.pnlJet.TabIndex = 1;
            // 
            // pnlAttackStrip
            // 
            this.pnlAttackStrip.BackColor = System.Drawing.Color.Transparent;
            this.pnlAttackStrip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAttackStrip.Location = new System.Drawing.Point(1044, 185);
            this.pnlAttackStrip.Name = "pnlAttackStrip";
            this.pnlAttackStrip.Size = new System.Drawing.Size(48, 330);
            this.pnlAttackStrip.TabIndex = 0;
            // 
            // pnlAirStripEnd
            // 
            this.pnlAirStripEnd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAirStripEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAirStripEnd.Location = new System.Drawing.Point(286, 271);
            this.pnlAirStripEnd.Name = "pnlAirStripEnd";
            this.pnlAirStripEnd.Size = new System.Drawing.Size(23, 22);
            this.pnlAirStripEnd.TabIndex = 1;
            // 
            // pnlAirStripStart
            // 
            this.pnlAirStripStart.BackColor = System.Drawing.Color.Transparent;
            this.pnlAirStripStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAirStripStart.Location = new System.Drawing.Point(93, 261);
            this.pnlAirStripStart.Name = "pnlAirStripStart";
            this.pnlAirStripStart.Size = new System.Drawing.Size(23, 22);
            this.pnlAirStripStart.TabIndex = 2;
            // 
            // pnlOnstacleZone
            // 
            this.pnlOnstacleZone.BackColor = System.Drawing.Color.Transparent;
            this.pnlOnstacleZone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOnstacleZone.Location = new System.Drawing.Point(463, 31);
            this.pnlOnstacleZone.Name = "pnlOnstacleZone";
            this.pnlOnstacleZone.Size = new System.Drawing.Size(443, 517);
            this.pnlOnstacleZone.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.pnlOnstacleZone);
            this.Controls.Add(this.pnlAirStripStart);
            this.Controls.Add(this.pnlAirStripEnd);
            this.Controls.Add(this.pnlAttackStrip);
            this.Controls.Add(this.pnlJet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Panel pnlJet;
        private System.Windows.Forms.Panel pnlAttackStrip;
        private System.Windows.Forms.Panel pnlAirStripEnd;
        private System.Windows.Forms.Panel pnlAirStripStart;
        private System.Windows.Forms.Panel pnlOnstacleZone;
    }
}

