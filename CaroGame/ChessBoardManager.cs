using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    internal class ChessBoardManager
    {
        #region Properties

        private Panel pnChessBoard;
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox pictureMark;
        private List<List<Button>> matrix;
        private Stack<PlayerInfo> playerTimeLine;

        public Panel PnChessBoard { get => pnChessBoard; set => pnChessBoard = value; }
        internal List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox PictureMark { get => pictureMark; set => pictureMark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        internal Stack<PlayerInfo> PlayerTimeLine { get => playerTimeLine; set => playerTimeLine = value; }

        #endregion

        #region Initialize

        public ChessBoardManager(Panel pnChessBoard, TextBox playerName, PictureBox pictureMark)
        {
            this.PnChessBoard = pnChessBoard;
            this.PlayerName = playerName;
            this.PictureMark = pictureMark;

            this.Player = new List<Player>()
            {
                new Player( "Tanjiro", Image.FromFile(Application.StartupPath + "\\Resources\\x.jpg")),
                new Player( "Zenitsu", Image.FromFile(Application.StartupPath + "\\Resources\\ov.jpg")),
            };
            
        }

        #endregion

        #region Methods
         
        public bool isUndo()
        {
            if (PlayerTimeLine.Count == 0) return false; 
            PlayerInfo playerOldStep = playerTimeLine.Pop();
            Button btn = Matrix[playerOldStep.PointMark.Y][playerOldStep.PointMark.X];
            btn.BackgroundImage = null;

            currentPlayer = playerOldStep.CurrentPlayer;
            ShowPlayer();
            return true;
        }

        public void DrawChessBoard()
        {
            currentPlayer = 0;
            ShowPlayer();

            pnChessBoard.Enabled = false;

            Matrix = new List<List<Button>>();
            playerTimeLine = new Stack<PlayerInfo>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };


            for (int i = 0; i < Const.CHESS_BOARD_WIDTH; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= Const.CHESS_BOARD_LENGTH; j++)
                {
                    Button btn = new Button() 
                    { 
                        Width = Const.CELL_WIDTH, 
                        Height = Const.CELL_HEIGHT,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        Tag = i.ToString(),
                        BackColor = Color.NavajoWhite,
                    };


                    btn.Click += Btn_Click;
                    PnChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn.Width = 0;
                oldBtn.Height = 0;
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Const.CELL_HEIGHT);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Point point = GetPoint(btn);

            if (btn.BackgroundImage != null)
                return;
            ChangeImage(btn);

            playerTimeLine.Push(new PlayerInfo(point, currentPlayer));

            currentPlayer = currentPlayer == 0 ? 1 : 0;
            ShowPlayer();


            if (playerTick != null) 
                playerTick(this, new ButtonClickEvent(point));

            if (isEndGame(btn))
                EndGame();
        }

        public void OtherPlayerMark(Point point)
        {
            Button btn = Matrix[point.Y][point.X];

            if (btn.BackgroundImage != null)
                return;
            ChangeImage(btn);

            playerTimeLine.Push(new PlayerInfo(GetPoint(btn), currentPlayer));

            currentPlayer = currentPlayer == 0 ? 1 : 0;
            ShowPlayer();

            if (isEndGame(btn))
                EndGame();
        }
            
        void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        bool isEndGame(Button btn)
        {
            return isEndGameHorizontal(btn) || isEndGameVertical(btn) || isEndGameDiagonalPrimary(btn) || isEndGameDiagonalSecond(btn);
        }

        Point GetPoint(Button btn)
        {
            int y = Convert.ToInt32(btn.Tag);
            int x = Matrix[y].IndexOf(btn);

            Point point = new Point(x, y);

            return point;
        }

        bool isEndGameHorizontal(Button btn)
        {
            int countLeft = 0;
            int countRight = 0;
            Point point = GetPoint(btn);

            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }

            for (int i = point.X + 1; i < Const.CHESS_BOARD_LENGTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }

            return countRight + countLeft >= 5;
        }

        bool isEndGameVertical(Button btn)
        {
            int countTop = 0;
            int countBottom = 0;
            Point point = GetPoint(btn);

            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }

            for (int i = point.Y + 1; i < Const.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countBottom + countTop >= 5;
        }

        bool isEndGameDiagonalPrimary(Button btn)
        {
            int countTop = 0;
            int countBottom = 0;
            Point point = GetPoint(btn);

            for (int i = 0; i <= point.Y; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0) break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < Const.CHESS_BOARD_WIDTH - point.Y; i++)
            {
                if (point.X + i >= Const.CHESS_BOARD_LENGTH || point.Y + i >= Const.CHESS_BOARD_WIDTH) break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countBottom + countTop >= 5;
        }

        bool isEndGameDiagonalSecond(Button btn)
        {
            int countTop = 0;
            int countBottom = 0;
            Point point = GetPoint(btn);

            for (int i = 0; i <= point.Y; i++)
            {
                if (point.X + i >= Const.CHESS_BOARD_LENGTH || point.Y - i < 0) break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < Const.CHESS_BOARD_WIDTH - point.Y; i++)
            {
                if (point.X - i < 0 || point.Y + i >= Const.CHESS_BOARD_WIDTH) break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                {
                    break;
                }
            }

            return countBottom + countTop >= 5;
        }

        void ChangeImage(Button btn)
        {
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackgroundImage = Player[currentPlayer].Image;
        }

        void ShowPlayer()
        {
            PlayerName.Text = Player[currentPlayer].Name;
            PictureMark.BackgroundImage = Player[currentPlayer].Image;
        }

        #endregion

        #region Events

        private event EventHandler<ButtonClickEvent> playerTick;
        public event EventHandler<ButtonClickEvent> PlayerTick
        {
            add { playerTick += value; }
            remove { playerTick -= value; }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add { endedGame += value; }
            remove { endedGame -= value; }
        }

       

        #endregion
    }

    internal class ButtonClickEvent : EventArgs
    {
        private Point point;

        public Point Point { get => point; set => point = value; }

        public ButtonClickEvent(Point point)
        {
            this.Point = point;
        }
    }
}
