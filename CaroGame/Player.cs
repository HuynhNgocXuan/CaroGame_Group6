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

        public string Name { get => name; set => name = value; }
        public Image Image { get => image; set => image = value; }

        public Player(string name, Image image)
        {
            this.Name = name;
            this.Image = image; 
        }
    }
}
