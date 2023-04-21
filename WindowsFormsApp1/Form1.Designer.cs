namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ai2 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.Ai1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.RoadTrack2 = new System.Windows.Forms.PictureBox();
            this.RoadTrack1 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ai2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.Ai2);
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.Ai1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.RoadTrack2);
            this.panel1.Controls.Add(this.RoadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 512);
            this.panel1.TabIndex = 0;
            // 
            // Ai2
            // 
            this.Ai2.Image = global::WindowsFormsApp1.Properties.Resources.carGreen;
            this.Ai2.Location = new System.Drawing.Point(265, 31);
            this.Ai2.Name = "Ai2";
            this.Ai2.Size = new System.Drawing.Size(50, 101);
            this.Ai2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ai2.TabIndex = 2;
            this.Ai2.TabStop = false;
            this.Ai2.Tag = "carRight";
            // 
            // explosion
            // 
            this.explosion.Image = global::WindowsFormsApp1.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(40, 369);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 2;
            this.explosion.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::WindowsFormsApp1.Properties.Resources._1star;
            this.award.Location = new System.Drawing.Point(40, 152);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(390, 211);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.award.TabIndex = 2;
            this.award.TabStop = false;
            // 
            // Ai1
            // 
            this.Ai1.Image = global::WindowsFormsApp1.Properties.Resources.ambulance;
            this.Ai1.Location = new System.Drawing.Point(144, 32);
            this.Ai1.Name = "Ai1";
            this.Ai1.Size = new System.Drawing.Size(50, 100);
            this.Ai1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ai1.TabIndex = 2;
            this.Ai1.TabStop = false;
            this.Ai1.Tag = "carLeft";
            // 
            // player
            // 
            this.player.Image = global::WindowsFormsApp1.Properties.Resources.carOrange;
            this.player.Location = new System.Drawing.Point(217, 388);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // RoadTrack2
            // 
            this.RoadTrack2.Image = global::WindowsFormsApp1.Properties.Resources.roadTrack;
            this.RoadTrack2.Location = new System.Drawing.Point(0, 0);
            this.RoadTrack2.Name = "RoadTrack2";
            this.RoadTrack2.Size = new System.Drawing.Size(475, 512);
            this.RoadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack2.TabIndex = 1;
            this.RoadTrack2.TabStop = false;
            this.RoadTrack2.Tag = "roadTrack1";
            // 
            // RoadTrack1
            // 
            this.RoadTrack1.Image = global::WindowsFormsApp1.Properties.Resources.roadTrack;
            this.RoadTrack1.Location = new System.Drawing.Point(0, -450);
            this.RoadTrack1.Name = "RoadTrack1";
            this.RoadTrack1.Size = new System.Drawing.Size(475, 428);
            this.RoadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack1.TabIndex = 0;
            this.RoadTrack1.TabStop = false;
            this.RoadTrack1.Tag = "roadTrack1";
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(19, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(196, 29);
            this.txtScore.TabIndex = 2;
            this.txtScore.Tag = "score";
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gametimerEvent);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(184, 573);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 38);
            this.btnStart.TabIndex = 3;
            this.btnStart.Tag = "btnStart";
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(499, 623);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = " Car game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ai2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox Ai2;
        private System.Windows.Forms.PictureBox Ai1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox RoadTrack2;
        private System.Windows.Forms.PictureBox RoadTrack1;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btnStart;
    }
}

