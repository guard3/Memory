using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class MainForm : Form
    {
        // Array that holds up all the Cards in the game
        Card[] cardArray = new Card[20];

        Settings gameSettings;
        //bool isGameRunning = false;
        Random rand = new Random();
        int firstClickedCard = -1;
        int foundPairs = 0;
        int numTries = 0;

        //Important in order to prevent card selections while delaying the flipping
        bool awaiting = false;

        //Timer
        int minutes = 0;
        int seconds = 0;
        public MainForm()
        {
            InitializeComponent();

            //Load settings
            try
            {
                using (Stream stream = File.Open("memory.set", FileMode.Open))
                {
                    gameSettings = (Settings)new BinaryFormatter().Deserialize(stream);
                }
            }
            catch (Exception)
            {
                gameSettings = new Settings();
            }

            //Place Cards
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cardArray[4 * i + j] = new Card();
                    cardArray[4 * i + j].Visible = false;
                    cardArray[4 * i + j].Size = new Size(34, 34);
                    cardArray[4 * i + j].BorderStyle = BorderStyle.FixedSingle;
                    cardArray[4 * i + j].Location = new Point(8 + i * 42, ClientRectangle.Y + mainMenuStrip.Height + 8 + j * 44);
                    cardArray[4 * i + j].BackColor = Color.LightBlue;
                    cardArray[4 * i + j].Id = 4 * i + j;
                    cardArray[4 * i + j].Click += async (object o, EventArgs a) =>
                    {
                        if (awaiting) return;
                        if (!((Card)o).Clicked)
                        {
                            if (!timer.Enabled)
                            {
                                timer.Enabled = true;
                                timer.Start();
                            }
                            ((Card)o).Clicked = true;
                            ((Card)o).ImageLocation = gameSettings.ImageFolderPath + "//" + ((Card)o).ImageId.ToString() + ".png";
                            if (firstClickedCard == -1) firstClickedCard = ((Card)o).Id;
                            else
                            {
                                numTries++;
                                this.Text = "Tries: " + numTries.ToString();
                                if (cardArray[firstClickedCard].ImageId == ((Card)o).ImageId)
                                {
                                    foundPairs++;
                                }
                                else
                                {
                                    awaiting = true;
                                    await Task.Delay(500);
                                    awaiting = false;
                                    cardArray[firstClickedCard].ImageLocation = "";
                                    cardArray[firstClickedCard].Clicked = false;
                                    ((Card)o).ImageLocation = "";
                                    ((Card)o).Clicked = false;
                                }
                                firstClickedCard = -1;
                            }
                        }
                        if (foundPairs == 10)
                        {
                            timer.Stop();
                            gameSettings.UpdateTopPlayers(numTries, minutes, seconds);
                            endGame();
                        }
                    };
                    Controls.Add(cardArray[4 * i + j]);
                }
            }
        }

        private void loadImagesMenu_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            if (folderDialog.SelectedPath != "") gameSettings.ImageFolderPath = folderDialog.SelectedPath;
        }

        private void newGameMenu_Click(object sender, EventArgs e)
        {
            timeLabel.Visible = true;
            endGameToolStripMenuItem.Visible = true;
            booToolStripMenuItem.Visible = false;
            loadImagesMenu.Visible = false;
            resetImagesToolStripMenuItem.Visible = false;
            firstClickedCard = -1;
            foundPairs = 0;
            numTries = 0;
            this.Text = "Tries: " + numTries.ToString();
            timeLabel.Text = "00:00";
            //Reset card appearance, make cards visible and apply random image ids
            int[] ids = new int[20];
            for (int i = 0; i < 10; i++)
            {
                ids[i] = i;
                ids[19 - i] = i;
            }
            for (int i = 0; i < 20; i++)
            {
                int index = rand.Next(20);
                int temp = ids[i];
                ids[i] = ids[index];
                ids[index] = temp;
            }
            for (int i = 0; i < 20; i++)
            {
                cardArray[i].ImageLocation = "";
                cardArray[i].Visible = true;
                cardArray[i].ImageId = ids[i];
                cardArray[i].Clicked = false;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            endGame();
        }

        void endGame()
        {
            timer.Stop();
            timer.Enabled = false;
            minutes = 0;
            seconds = 0;
            timeLabel.Visible = false;
            this.Text = "Memory Game";
            for (int i = 0; i < 20; i++) cardArray[i].Visible = false;
            booToolStripMenuItem.Visible = true;
            loadImagesMenu.Visible = true;
            resetImagesToolStripMenuItem.Visible = true;
            endGameToolStripMenuItem.Visible = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save settings
            using (Stream stream = File.Open("memory.set", FileMode.Create))
            {
                new BinaryFormatter().Serialize(stream, gameSettings);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 60)
            {
                timer.Enabled = false;
                MessageBox.Show("Time Out");
                endGame();
            }
            timeLabel.Text = (minutes < 10 ? "0" : "") + minutes.ToString() + ":" + (seconds < 10 ? "0" : "") + seconds.ToString();
        }

        private void leaderBoardMenu_Click(object sender, EventArgs e)
        {
            new LeaderBoard(gameSettings.topPlayers).ShowDialog();
        }

        private void resetImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSettings.ImageFolderPath = "default";
        }
    }
}
