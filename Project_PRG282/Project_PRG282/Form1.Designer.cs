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
            this.timeObjectMove = new System.Windows.Forms.Timer(this.components);
            this.pnlmachbet = new System.Windows.Forms.Panel();
            this.pnlSpyder = new System.Windows.Forms.Panel();
            this.pnlPatriot = new System.Windows.Forms.Panel();
            this.pnlIronDome = new System.Windows.Forms.Panel();
            this.pnlThel = new System.Windows.Forms.Panel();
            this.pnlAnza = new System.Windows.Forms.Panel();
            this.pnlFlakpanzer = new System.Windows.Forms.Panel();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1181, 28);
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
            this.addObstaclesToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.addObstaclesToolStripMenuItem.Text = "Open Obstacle Menu";
            this.addObstaclesToolStripMenuItem.Click += new System.EventHandler(this.addObstaclesToolStripMenuItem_Click);
            // 
            // removeAllObstaclesToolStripMenuItem
            // 
            this.removeAllObstaclesToolStripMenuItem.Name = "removeAllObstaclesToolStripMenuItem";
            this.removeAllObstaclesToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.removeAllObstaclesToolStripMenuItem.Text = "Close Obstacle Menu";
            this.removeAllObstaclesToolStripMenuItem.Click += new System.EventHandler(this.removeAllObstaclesToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
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
            // pnlAirStripStart
            // 
            this.pnlAirStripStart.BackColor = System.Drawing.Color.Transparent;
            this.pnlAirStripStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAirStripStart.Location = new System.Drawing.Point(92, 262);
            this.pnlAirStripStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAirStripStart.Name = "pnlAirStripStart";
            this.pnlAirStripStart.Size = new System.Drawing.Size(23, 22);
            this.pnlAirStripStart.TabIndex = 2;
            // 
            // pnlTitan
            // 
            this.pnlTitan.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitan.Location = new System.Drawing.Point(37, 58);
            this.pnlTitan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitan.Name = "pnlTitan";
            this.pnlTitan.Size = new System.Drawing.Size(17, 16);
            this.pnlTitan.TabIndex = 4;
            // 
            // pbObstacleZone
            // 
            this.pbObstacleZone.BackColor = System.Drawing.Color.Transparent;
            this.pbObstacleZone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbObstacleZone.Location = new System.Drawing.Point(508, 31);
            this.pbObstacleZone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbObstacleZone.Name = "pbObstacleZone";
            this.pbObstacleZone.Size = new System.Drawing.Size(388, 521);
            this.pbObstacleZone.TabIndex = 0;
            this.pbObstacleZone.TabStop = false;
            // 
            // picJet
            // 
            this.picJet.BackColor = System.Drawing.Color.Transparent;
            this.picJet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picJet.BackgroundImage")));
            this.picJet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picJet.Location = new System.Drawing.Point(177, 130);
            this.picJet.Margin = new System.Windows.Forms.Padding(4);
            this.picJet.Name = "picJet";
            this.picJet.Size = new System.Drawing.Size(44, 41);
            this.picJet.TabIndex = 8;
            this.picJet.TabStop = false;
            // 
            // pnlEnemyBase
            // 
            this.pnlEnemyBase.BackColor = System.Drawing.Color.Transparent;
            this.pnlEnemyBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEnemyBase.Location = new System.Drawing.Point(1010, 197);
            this.pnlEnemyBase.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEnemyBase.Name = "pnlEnemyBase";
            this.pnlEnemyBase.Size = new System.Drawing.Size(184, 299);
            this.pnlEnemyBase.TabIndex = 9;
            // 
            // pnlReturnBase
            // 
            this.pnlReturnBase.BackColor = System.Drawing.Color.Transparent;
            this.pnlReturnBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReturnBase.Location = new System.Drawing.Point(0, 222);
            this.pnlReturnBase.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReturnBase.Name = "pnlReturnBase";
            this.pnlReturnBase.Size = new System.Drawing.Size(109, 134);
            this.pnlReturnBase.TabIndex = 10;
            // 
            // pnlmachbet
            // 
            this.pnlmachbet.BackColor = System.Drawing.Color.Transparent;
            this.pnlmachbet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlmachbet.Location = new System.Drawing.Point(73, 58);
            this.pnlmachbet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlmachbet.Name = "pnlmachbet";
            this.pnlmachbet.Size = new System.Drawing.Size(17, 16);
            this.pnlmachbet.TabIndex = 5;
            // 
            // pnlSpyder
            // 
            this.pnlSpyder.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpyder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSpyder.Location = new System.Drawing.Point(108, 58);
            this.pnlSpyder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSpyder.Name = "pnlSpyder";
            this.pnlSpyder.Size = new System.Drawing.Size(17, 16);
            this.pnlSpyder.TabIndex = 6;
            // 
            // pnlPatriot
            // 
            this.pnlPatriot.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatriot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPatriot.Location = new System.Drawing.Point(144, 58);
            this.pnlPatriot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPatriot.Name = "pnlPatriot";
            this.pnlPatriot.Size = new System.Drawing.Size(17, 16);
            this.pnlPatriot.TabIndex = 7;
            // 
            // pnlIronDome
            // 
            this.pnlIronDome.BackColor = System.Drawing.Color.Transparent;
            this.pnlIronDome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlIronDome.Location = new System.Drawing.Point(37, 89);
            this.pnlIronDome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIronDome.Name = "pnlIronDome";
            this.pnlIronDome.Size = new System.Drawing.Size(17, 16);
            this.pnlIronDome.TabIndex = 8;
            // 
            // pnlThel
            // 
            this.pnlThel.BackColor = System.Drawing.Color.Transparent;
            this.pnlThel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlThel.Location = new System.Drawing.Point(73, 89);
            this.pnlThel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlThel.Name = "pnlThel";
            this.pnlThel.Size = new System.Drawing.Size(17, 16);
            this.pnlThel.TabIndex = 9;
            // 
            // pnlAnza
            // 
            this.pnlAnza.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAnza.Location = new System.Drawing.Point(108, 89);
            this.pnlAnza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAnza.Name = "pnlAnza";
            this.pnlAnza.Size = new System.Drawing.Size(17, 16);
            this.pnlAnza.TabIndex = 10;
            // 
            // pnlFlakpanzer
            // 
            this.pnlFlakpanzer.BackColor = System.Drawing.Color.Transparent;
            this.pnlFlakpanzer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFlakpanzer.Location = new System.Drawing.Point(144, 89);
            this.pnlFlakpanzer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFlakpanzer.Name = "pnlFlakpanzer";
            this.pnlFlakpanzer.Size = new System.Drawing.Size(17, 16);
            this.pnlFlakpanzer.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.pnlFlakpanzer);
            this.Controls.Add(this.pnlAnza);
            this.Controls.Add(this.pnlThel);
            this.Controls.Add(this.pnlIronDome);
            this.Controls.Add(this.pnlPatriot);
            this.Controls.Add(this.pnlSpyder);
            this.Controls.Add(this.pnlmachbet);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Timer timeObjectMove;
        private System.Windows.Forms.Panel pnlmachbet;
        private System.Windows.Forms.Panel pnlSpyder;
        private System.Windows.Forms.Panel pnlPatriot;
        private System.Windows.Forms.Panel pnlIronDome;
        private System.Windows.Forms.Panel pnlThel;
        private System.Windows.Forms.Panel pnlAnza;
        private System.Windows.Forms.Panel pnlFlakpanzer;
    }
}

