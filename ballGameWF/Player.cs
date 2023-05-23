using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace ballGameWF
{
    public class Player
    {
        public string NickName { get; set; }    
        public int score { get; set; }
        public Image icon { get; set; }

        public Player(string name , Image _icon )
        {
            NickName = name;
            icon = _icon;
        }

        public Player(string name, int _score)
        {
            NickName = name;
           
            score = _score;
        }
        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(NickName);
                writer.WriteLine(score);
            }
        }
    }
}
