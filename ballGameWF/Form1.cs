using System;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using System.Drawing.Drawing2D;

namespace ballGameWF
{
    
    public partial class GameBall : Form

    {

        Random rand = new Random();
        GraphicsPath path = new GraphicsPath();
        List<PictureBox> items = new List<PictureBox>();
        
        string[] files = Directory.GetFiles(@"C:\Users\WellDone\source\repos\ballGameWF\ballGameWF\img\", "*.png");
        
      
        int spawnRate = 60;
        int currentRate = 0;
        int lastScore = 0;
        int health = 0;
        int posX;
        int posY;
        int score = 0;
        bool gameover = false;
        public System.Timers.Timer aTimer = new System.Timers.Timer(2000);
        public GameBall()

        {
           
            
                
            this.Cursor = new Cursor(@"C:\Users\WellDone\source\repos\ballGameWF\ballGameWF\img\cur.cur");
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            currentRate = spawnRate;
           

        }
        
        static Color[] colors = { Color.Red, Color.Green, Color.Black};
        static Color GetRandomColor()
        {
            var random = new Random();
            return colors[random.Next(colors.Length)];
        }
        private void GameLoop(object sender, ElapsedEventArgs e)
        {
          
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


            int x = rand.Next(10, this.ClientSize.Width - newPic.Width);
            int y = rand.Next(10, this.ClientSize.Height - newPic.Height);
            newPic.Location = new Point(x, y);
            newPic.Click += NewPic_Click;
            items.Add(newPic);
            this.Controls.Add(newPic);
        }
        private void NewPic_Click(object sender, EventArgs e)
        {
            PictureBox temPic = sender as PictureBox;
            if (temPic.Tag.ToString() == "greenMouse") score += 5;
            else score += 1;
            items.Remove(temPic);
            this.Controls.Remove(temPic);
            txtScore.Text = "Score: " + score;
        }
        private void TimerEvent(object sender, EventArgs e)
        {

            if (this.progressBar1.Value <= 5)
            {
               
                Game_Over();
               
            }
            MakePictureBox();
           
           
            this.progressBar1.Value -= 5;
            

            foreach (var x in items.ToList())
            {
                if (x.Height <40 && x.Width < 40)
                {
                    if (x.Tag.ToString() == "pinkMouse") score -= 5;
                    else score -= 2;
                    items.Remove(x);
                    this.Controls.Remove(x);
                    txtScore.Text = "Score: " + score;


                }
                x.Height -= 10;
                x.Width -= 10;


            }
        }

        private void GameBall_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.GetType() is PictureBox)

            {
                PictureBox pic = sender as PictureBox;
            }

        }
        private void Game_Over()
        {
            timer1.Enabled = false;
            MessageBox.Show("Game Over" + Environment.NewLine + "You Scored: " + score + Environment.NewLine + "Click Ok to play again!", "Moo Says: ");
        }

       
    }
}