namespace CaroGame
{
    partial class fChessBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChessBoard));
            this.pnChessBoard = new System.Windows.Forms.Panel();
            this.progressBarCountDown = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSendMess = new System.Windows.Forms.Button();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewPlay = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.menuChessBoard = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureMark = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuChessBoard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnChessBoard
            // 
            this.pnChessBoard.BackColor = System.Drawing.Color.LightBlue;
            this.pnChessBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChessBoard.Location = new System.Drawing.Point(309, 79);
            this.pnChessBoard.Name = "pnChessBoard";
            this.pnChessBoard.Size = new System.Drawing.Size(1042, 740);
            this.pnChessBoard.TabIndex = 0;
            // 
            // progressBarCountDown
            // 
            this.progressBarCountDown.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarCountDown.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBarCountDown.Location = new System.Drawing.Point(12, 41);
            this.progressBarCountDown.Name = "progressBarCountDown";
            this.progressBarCountDown.Size = new System.Drawing.Size(275, 21);
            this.progressBarCountDown.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptbLogo);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 203);
            this.panel2.TabIndex = 2;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbLogo.BackgroundImage = global::CaroGame.Properties.Resources.jesu;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbLogo.Location = new System.Drawing.Point(3, 1);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(272, 199);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 6;
            this.ptbLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSendMess);
            this.panel3.Controls.Add(this.txtMess);
            this.panel3.Controls.Add(this.txtIP);
            this.panel3.Location = new System.Drawing.Point(7, 602);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 217);
            this.panel3.TabIndex = 3;
            // 
            // btnSendMess
            // 
            this.btnSendMess.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSendMess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSendMess.Location = new System.Drawing.Point(68, 110);
            this.btnSendMess.Name = "btnSendMess";
            this.btnSendMess.Size = new System.Drawing.Size(105, 40);
            this.btnSendMess.TabIndex = 9;
            this.btnSendMess.Text = "Gửi";
            this.btnSendMess.UseVisualStyleBackColor = false;
            this.btnSendMess.Click += new System.EventHandler(this.btnSendMess_Click);
            // 
            // txtMess
            // 
            this.txtMess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMess.Location = new System.Drawing.Point(8, 169);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(257, 30);
            this.txtMess.TabIndex = 7;
            this.txtMess.Text = "Message";
            this.txtMess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIP.Location = new System.Drawing.Point(8, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(257, 30);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConnect.Location = new System.Drawing.Point(141, 65);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(124, 40);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Kết Nối";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnConnect);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnNewPlay);
            this.panel4.Location = new System.Drawing.Point(7, 470);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 126);
            this.panel4.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStart.Location = new System.Drawing.Point(8, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 40);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseHover += new System.EventHandler(this.btnStart_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(8, 65);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnNewPlay
            // 
            this.btnNewPlay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPlay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNewPlay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewPlay.Location = new System.Drawing.Point(145, 19);
            this.btnNewPlay.Name = "btnNewPlay";
            this.btnNewPlay.Size = new System.Drawing.Size(120, 40);
            this.btnNewPlay.TabIndex = 6;
            this.btnNewPlay.Text = "Chơi mới";
            this.btnNewPlay.UseVisualStyleBackColor = false;
            this.btnNewPlay.Click += new System.EventHandler(this.btnNewPlay_Click);
            this.btnNewPlay.MouseHover += new System.EventHandler(this.btnNewPlay_MouseHover);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMessage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbMessage.Location = new System.Drawing.Point(319, 41);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(73, 23);
            this.lbMessage.TabIndex = 4;
            this.lbMessage.Text = "Con gà";
            // 
            // menuChessBoard
            // 
            this.menuChessBoard.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuChessBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuChessBoard.Location = new System.Drawing.Point(0, 0);
            this.menuChessBoard.Name = "menuChessBoard";
            this.menuChessBoard.Size = new System.Drawing.Size(1372, 27);
            this.menuChessBoard.TabIndex = 6;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.newGameToolStripMenuItem,
            this.undoGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.startGameToolStripMenuItem.Text = "Start game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoGameToolStripMenuItem
            // 
            this.undoGameToolStripMenuItem.Name = "undoGameToolStripMenuItem";
            this.undoGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoGameToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.undoGameToolStripMenuItem.Text = "Undo game";
            this.undoGameToolStripMenuItem.Click += new System.EventHandler(this.undoGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CaroGame.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureMark);
            this.panel1.Location = new System.Drawing.Point(15, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 187);
            this.panel1.TabIndex = 7;
            // 
            // pictureMark
            // 
            this.pictureMark.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureMark.Location = new System.Drawing.Point(50, 28);
            this.pictureMark.Name = "pictureMark";
            this.pictureMark.Size = new System.Drawing.Size(168, 125);
            this.pictureMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMark.TabIndex = 6;
            this.pictureMark.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(1166, 39);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(185, 30);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // fChessBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1372, 847);
            this.Controls.Add(this.progressBarCountDown);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnChessBoard);
            this.Controls.Add(this.menuChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuChessBoard;
            this.Name = "fChessBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fChessBoard_FormClosing);
            this.Load += new System.EventHandler(this.fChessBoard_Load);
            this.Shown += new System.EventHandler(this.fChessBoard_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.menuChessBoard.ResumeLayout(false);
            this.menuChessBoard.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnChessBoard;
        private System.Windows.Forms.ProgressBar progressBarCountDown;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNewPlay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnSendMess;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuChessBoard;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureMark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

