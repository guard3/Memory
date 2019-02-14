using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    [Serializable]
    public class Settings
    {
        public string ImageFolderPath { get; set; } = "default";
        [Serializable]
        public class User
        {
            public string name;
            public int score, minutes, seconds;
            public User(string _Name, int _Score, int _Minutes, int _Seconds)
            {
                name = _Name;
                score = _Score;
                minutes = _Minutes;
                seconds = _Seconds;
            }
        };
        public User[] topPlayers = new User[10];
        public Settings()
        {
            for (int i = 0; i < 10; i++) topPlayers[i] = new User("Anonymous", 999, 0, 0);
        }
        public void UpdateTopPlayers(int _Score, int _Minutes, int _Seconds)
        {
            bool newHighScoreAchieved = false;
            for (int i = 0; i < 10; i++)
            {
                if (_Score <= topPlayers[i].score)
                {
                    NewHighScore highScoreForm = new NewHighScore();
                    highScoreForm.ShowDialog();
                    for (int j = 9; j > i; j--) topPlayers[j] = topPlayers[j - 1];
                    topPlayers[i] = new User(highScoreForm.UserName, _Score, _Minutes, _Seconds);
                    newHighScoreAchieved = true;
                    break;
                }
            }
            if (newHighScoreAchieved)
            {
                new LeaderBoard(topPlayers).ShowDialog();
            }
            else
            {
                MessageBox.Show("Game over");
            }
        }
    }
}
