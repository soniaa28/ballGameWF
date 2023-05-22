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
        
        public Start()
        {
           
           
            InitializeComponent();
        }

        private void cat1_CheckedChanged(object sender, EventArgs e)
        {
            if(cat1.Checked) pictureCat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            else pictureCat1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void cat2_CheckedChanged(object sender, EventArgs e)
        {
            if (cat2.Checked) pictureCat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            else pictureCat2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void cat3_CheckedChanged(object sender, EventArgs e)
        {
            if (cat3.Checked) pictureCat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            else pictureCat3.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void cat4_CheckedChanged(object sender, EventArgs e)
        {
            if (cat4.Checked) pictureCat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            else pictureCat4.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
