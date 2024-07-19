using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    public partial class fChessBoard : Form
    {
        #region Properties

        ChessBoardManager managerBoard;

        #endregion

        #region Initialize

        public fChessBoard()
        {
            InitializeComponent();
            managerBoard = new ChessBoardManager(pnChessBoard, txtName, pictureMark);
            managerBoard.DrawChessBoard();

            progressBarCountDown.Maximum = Const.COUNT_DOWN_TIME;
            timerProgressBar.Interval = Const.COUNT_DOWN_INTERVAL;
            progressBarCountDown.Step = Const.COUNT_DOWN_STEP;

            managerBoard.PlayerTick += ManagerBoard_PlayerTick;
            managerBoard.EndedGame += ManagerBoard_EndedGame;
        }

        private void ManagerBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void ManagerBoard_PlayerTick(object sender, EventArgs e)
        {
            timerProgressBar.Start();
            progressBarCountDown.Value = 0;
        }

        #endregion

        #region Methods

        void EndGame()
        {
            pnChessBoard.Enabled = false;
            pnChessBoard.BackColor = Color.LightBlue;
            timerProgressBar.Stop();
            undoGameToolStripMenuItem.Enabled = false;
            MessageBox.Show("Kết thúc ", "Thông báo");
        }

        void StartGame()
        {
            pnChessBoard.BackColor = Color.DarkGray;
            pnChessBoard.Enabled = true;
            btnStart.Enabled = false;
        }

        void NewGame()
        {
            pnChessBoard.Controls.Clear();
            managerBoard.DrawChessBoard();
            btnStart.Enabled = true;
            progressBarCountDown.Value = 0;
            timerProgressBar.Stop();
            undoGameToolStripMenuItem.Enabled = true;
        }

        void UndoGame()
        {
            managerBoard.isUndo();

        }

        void ExitGame()
        {
            Application.Exit();
        }

        #endregion

        #region Events

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarCountDown.PerformStep();
            if (progressBarCountDown.Value >= progressBarCountDown.Maximum)
            {
                EndGame();
            }
        }

        private void btnSendMess_Click(object sender, EventArgs e)
        {
            lbMessage.Text = txtMess.Text;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnNewPlay_Click(object sender, EventArgs e)
        {
           
            NewGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitGame();
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewGame();
        }

        private void undoGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitGame();
        }

        private void fChessBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
        }

        private void btnNewPlay_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ToolTip info = new ToolTip
            {
                AutomaticDelay = 500,
            };
            info.SetToolTip(btn, "New Game");
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ToolTip info = new ToolTip
            {
                AutomaticDelay = 500,
            };
            info.SetToolTip(btn, "Start Game");
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ToolTip info = new ToolTip
            {
                AutomaticDelay = 500,
            };
            info.SetToolTip(btn, "Quit Game");
        }

        #endregion
    }
}
