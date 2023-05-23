using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ballGameWF
{
    public partial class Start : Form
    {
        public event EventHandler<PlayerEventArgs> PlayerCreated;
        Image icon;
        public Start()
        {
            InitializeComponent();

        }

        private void cat1_CheckedChanged(object sender, EventArgs e)
        {
            if (cat1.Checked)
            {
                pictureCat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                icon = pictureCat1.Image;
            }
            else pictureCat1.BorderStyle = System.Windows.Forms.BorderStyle.None;
          
        }

        private void cat2_CheckedChanged(object sender, EventArgs e)
        {
            if (cat2.Checked)
            {
                pictureCat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                icon = pictureCat2.Image;
            }
            else pictureCat2.BorderStyle = System.Windows.Forms.BorderStyle.None;
           
        }

        private void cat3_CheckedChanged(object sender, EventArgs e)
        {
            if (cat3.Checked)
            {
                pictureCat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                icon = pictureCat3.Image;
            }
            else pictureCat3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            
        }

        private void cat4_CheckedChanged(object sender, EventArgs e)
        {
            if (cat4.Checked)
            {
                pictureCat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                icon = pictureCat4.Image;
            }
            else pictureCat4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != String.Empty)
            {
                string nick;
                nick = textBox1.Text;
                // Create a new player instance
                Player player = new Player(nick, icon);

                // Raise the PlayerCreated event
                OnPlayerCreated(player);
                this.Hide();

            }
            else  MessageBox.Show("Введіть нікнейм!");
          
           

           
        }
        protected virtual void OnPlayerCreated(Player player)
        {
            PlayerCreated?.Invoke(this, new PlayerEventArgs(player));
        }

        private void btnrule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гра в мишку :" + Environment.NewLine + "За певний час Вам потрібно натискати на мишей різних кольорів та отримувати +1 бал (за зелену мишку - ви отримуєте додатково 5 балів)!" + Environment.NewLine + "За пропуск мишки Ви отримуєте штраф -2 бали (за пропуск рожевої мишки -5 балів) " + Environment.NewLine + "Якщо поцілите у рибку, то штраф -10 балів!" + Environment.NewLine + "Приємної гри!");
        }
    }
}
