using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroGame
{
    internal class Player
    {
        private string name;
        private Image image;
        private Image symbol;

        public string Name { get => name; set => name = value; }
        public Image Image { get => image; set => image = value; }
        public Image Symbol { get => symbol; set => symbol = value; }

        public Player(string name, Image image, Image symbol)
        {
            this.Name = name;
            this.Image = image;
            this.Symbol = symbol;
        }
    }
}
