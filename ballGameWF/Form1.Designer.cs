namespace ballGameWF
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
            this.txtScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(12, 27);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(68, 22);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Бали : ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
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
            this.lblPlayer.Location = new System.Drawing.Point(12, 70);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(83, 18);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Гравець :";
            // 
            // GameBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtScore);
            this.Name = "GameBall";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtScore;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label lblPlayer;
    }
}