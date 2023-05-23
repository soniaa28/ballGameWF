using System;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.DataFormats;

namespace ballGameWF
{
    public partial class GameBall : Form
    {
        Random rand = new Random();
        GraphicsPath path = new GraphicsPath();
        List<PictureBox> items = new List<PictureBox>();
        string[] files = Directory.GetFiles(@"C:\Users\WellDone\source\repos\ballGameWF\ballGameWF\img\", "*.png");
        SoundPlayer playerPopMouse = new SoundPlayer(@"C:\Users\WellDone\source\repos\ballGameWF\ballGameWF\sound\soundMouse.wav");
        SoundPlayer gameSound = new SoundPlayer(@"C:\Users\WellDone\source\repos\ballGameWF\ballGameWF\sound\gameSound.wav");
        SoundPlayer playerPopFish = new SoundPlayer(@"C:\Users\WellDone\source\repos\ballGameWF\ballGameWF\sound\clickedpop.wav");
        int score = 0;
        
        public GameBall()

        {
            InitializeComponent();
            this.Cursor = new Cursor(@"C:\Users\WellDone\source\repos\ballGameWF\ballGameWF\img\cur.cur");
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            gameSound.Play();
            Start start = new Start();
            start.PlayerCreated += Form1_PlayerCreated;
            start.ShowDialog();
        }
        
        private void MakePictureBox()
        {
            PictureBox newPic = new PictureBox();
            newPic.SizeMode = PictureBoxSizeMode.StretchImage;
            newPic.BackgroundImageLayout = ImageLayout.Stretch;
            string temp = files[rand.Next(files.Length)];
            newPic.BackgroundImage = Image.FromFile(temp);
            newPic.Tag = Path.GetFileNameWithoutExtension(temp);
            newPic.Height = 70;
            newPic.Width = 70;
            this.BackColor = Color.Transparent;
            int x = rand.Next(100, this.ClientSize.Width - newPic.Width);
            int y = rand.Next(10, this.ClientSize.Height - newPic.Height-100);
            newPic.Location = new Point(x, y);
            newPic.Click += NewPic_Click;
            items.Add(newPic);
            this.Controls.Add(newPic);
        }
        private void NewPic_Click(object sender, EventArgs e)
        {
            
            PictureBox temPic = sender as PictureBox;
            if (temPic.Tag.ToString() == "fish")
            {
                //playerPopFish.Play();
                score -= 5;
            }
            else
            {
                //playerPopMouse.Play();
                if (temPic.Tag.ToString() == "greenMouse") score += 5;
                else score += 1;
                
            }
            items.Remove(temPic);
            this.Controls.Remove(temPic);
            txtScore.Text = "Бали : " + score;

        }
        private void TimerEvent(object sender, EventArgs e)
        {
            this.progressBar1.Value -= 3;
            if (this.progressBar1.Value <= 5 || score < -10)
            {
                Game_Over();
            }
            if (score > 15) timer1.Interval = 1300;

                MakePictureBox();
                
                foreach (var x in items.ToList())
                {
                    if (x.Height < 40 && x.Width < 40)
                    {
                        if (x.Tag.ToString() == "pinkMouse") score -= 5;
                        else score -= 2;
                        items.Remove(x);
                        this.Controls.Remove(x);
                        txtScore.Text = "Бали : " + score;
                    }
                    x.Height -= 10;
                    x.Width -= 10;

                }
        }

      
        private void Game_Over()
        {
            timer1.Enabled = false;
            DialogResult dresult = MessageBox.Show("Are you sure ", "Alert"
                              , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dresult == DialogResult.OK)
            {
                this.Hide();
                GameBall g = new GameBall();
                g.Show();
            }
        }
        private void Form1_PlayerCreated(object sender, PlayerEventArgs e)
        {
            // Update the label with the player's name
            lblPlayer.Text = "Гравець: " + e.Player.NickName;
            iconPlayer.Image = e.Player.icon;
            timer1.Enabled = true;
        }

        
    }
    public class PlayerEventArgs : EventArgs
    {
        public Player Player { get; private set; }

        public PlayerEventArgs(Player player)
        {
            Player = player;
        }
    }
}