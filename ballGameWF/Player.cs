using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ballGameWF
{
    public class Player
    {
        public string NickName { get; set; }    
        public int score { get; set; }
        public Image icon { get; set; }

        public Player(string name , Image _icon)
        {
            NickName = name;
            icon = _icon;
        }
    }
}
