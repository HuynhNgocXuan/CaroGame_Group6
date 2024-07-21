using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroGame
{
    [Serializable]
    internal class DataInfo
    {
        private int command;
        private Point point;
        private string message;

        public int Command { get => command; set => command = value; }
        public Point Point { get => point; set => point = value; }
        public string Message { get => message; set => message = value; }

        public DataInfo(int command, string message, Point point)
        {
            this.Command = command;
            this.Message = message;
            this.Point = point;
        }
    }
    internal enum DataCommand
    {
        NOTIFY,
        SEND_POINT,
        NEW_GAME,
        END_GAME,
        UNDO,
        EXIT
    }
}
