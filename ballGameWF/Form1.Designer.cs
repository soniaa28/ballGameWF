﻿namespace ballGameWF
{
    partial class GameBall
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBall));
            this.txtScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.iconPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtScore.Location = new System.Drawing.Point(21, 13);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(68, 22);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Бали : ";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.ForeColor = System.Drawing.Color.RosyBrown;
            this.progressBar1.Location = new System.Drawing.Point(543, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 23);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 100;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPlayer.Location = new System.Drawing.Point(49, 66);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(83, 18);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Гравець :";
            // 
            // iconPlayer
            // 
            this.iconPlayer.Location = new System.Drawing.Point(2, 57);
            this.iconPlayer.Name = "iconPlayer";
            this.iconPlayer.Size = new System.Drawing.Size(41, 36);
            this.iconPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPlayer.TabIndex = 3;
            this.iconPlayer.TabStop = false;
            // 
            // GameBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconPlayer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBall";
            this.Text = "Гра в мишку";
            ((System.ComponentModel.ISupportInitialize)(this.iconPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtScore;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label lblPlayer;
        private PictureBox iconPlayer;
    }
}