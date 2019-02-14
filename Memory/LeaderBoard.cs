using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class LeaderBoard : Form
    {
        public LeaderBoard(Settings.User[] _TopPlayers)
        {
            InitializeComponent();

            //Place names
            Label nameLabel = new Label();
            for (int i = 0; i < 10; i++)
            {
                nameLabel.Text += _TopPlayers[i].name + Environment.NewLine;
            }
            nameLabel.Location = new Point(46, 9);
            nameLabel.AutoSize = true;
            Controls.Add(nameLabel);

            //Place scores
            Label scoreLabel = new Label();
            for (int i = 0; i < 10; i++)
            {
                scoreLabel.Text += _TopPlayers[i].score.ToString() + Environment.NewLine;
            }
            scoreLabel.Location = new Point(162, 9);
            scoreLabel.AutoSize = true;
            Controls.Add(scoreLabel);

            //Place times
            Label timeLabel = new Label();
            for (int i = 0; i < 10; i++)
            {
                timeLabel.Text += (_TopPlayers[i].minutes < 10 ? "0" : "") + _TopPlayers[i].minutes.ToString() + ":" + (_TopPlayers[i].seconds < 10 ? "0" : "") + _TopPlayers[i].seconds.ToString() + Environment.NewLine;
            }
            timeLabel.Location = new Point(209, 9);
            timeLabel.AutoSize = true;
            Controls.Add(timeLabel);
        }
    }
}
