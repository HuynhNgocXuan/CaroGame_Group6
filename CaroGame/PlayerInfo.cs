using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroGame
{
    internal class PlayerInfo
    {
        private Point pointMark;
        private int currentPlayer;
        private Image symbol;
        public Point PointMark { get => pointMark; set => pointMark = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public Image Symbol { get => symbol; set => symbol = value; }

        public PlayerInfo(Point pointMark, int currentPlayer, Image symbol)
        {
            this.PointMark = pointMark;
            this.CurrentPlayer = currentPlayer;
            this.Symbol = symbol;
        }
    }
}
