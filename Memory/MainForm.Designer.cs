namespace Memory
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImagesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.leaderBoardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resetImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.booToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.booToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.White;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(218, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenu,
            this.endGameToolStripMenuItem,
            this.booToolStripMenuItem,
            this.loadImagesMenu,
            this.resetImagesToolStripMenuItem,
            this.booToolStripMenuItem1,
            this.leaderBoardMenu,
            this.booToolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameMenu
            // 
            this.newGameMenu.Name = "newGameMenu";
            this.newGameMenu.ShortcutKeyDisplayString = "F2";
            this.newGameMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newGameMenu.Size = new System.Drawing.Size(186, 22);
            this.newGameMenu.Text = "New Game";
            this.newGameMenu.Click += new System.EventHandler(this.newGameMenu_Click);
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.endGameToolStripMenuItem.Text = "End Game";
            this.endGameToolStripMenuItem.Visible = false;
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.endGameToolStripMenuItem_Click);
            // 
            // loadImagesMenu
            // 
            this.loadImagesMenu.Name = "loadImagesMenu";
            this.loadImagesMenu.Size = new System.Drawing.Size(186, 22);
            this.loadImagesMenu.Text = "Load Custom Images";
            this.loadImagesMenu.Click += new System.EventHandler(this.loadImagesMenu_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.White;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(172, 4);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(34, 15);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00";
            this.timeLabel.Visible = false;
            // 
            // leaderBoardMenu
            // 
            this.leaderBoardMenu.Name = "leaderBoardMenu";
            this.leaderBoardMenu.Size = new System.Drawing.Size(186, 22);
            this.leaderBoardMenu.Text = "Leaderboard";
            this.leaderBoardMenu.Click += new System.EventHandler(this.leaderBoardMenu_Click);
            // 
            // resetImagesToolStripMenuItem
            // 
            this.resetImagesToolStripMenuItem.Name = "resetImagesToolStripMenuItem";
            this.resetImagesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resetImagesToolStripMenuItem.Text = "Reset Images";
            this.resetImagesToolStripMenuItem.Click += new System.EventHandler(this.resetImagesToolStripMenuItem_Click);
            // 
            // booToolStripMenuItem
            // 
            this.booToolStripMenuItem.Name = "booToolStripMenuItem";
            this.booToolStripMenuItem.Size = new System.Drawing.Size(183, 6);
            // 
            // booToolStripMenuItem1
            // 
            this.booToolStripMenuItem1.Name = "booToolStripMenuItem1";
            this.booToolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // booToolStripMenuItem2
            // 
            this.booToolStripMenuItem2.Name = "booToolStripMenuItem2";
            this.booToolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 205);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Memory Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameMenu;
        private System.Windows.Forms.ToolStripMenuItem loadImagesMenu;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ToolStripMenuItem leaderBoardMenu;
        private System.Windows.Forms.ToolStripSeparator booToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator booToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator booToolStripMenuItem2;
    }
}

