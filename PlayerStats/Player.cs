using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private int playedGames;
        private int wonGames;

        private float highScore;
        public float HighScore
        {
            get => highScore;
            set
            {
                if (value>highScore)
                    highScore = value;
            }
        }

        public string Name { get; }

        public float WinRate
        {
            get
            {
                if (playedGames==0)
                    return 0f;
                else
                    return (wonGames / playedGames);
            }
        }

        public Player (string name)
        {
            Name = name;
            playedGames = 0;
            wonGames = 0;
            highScore = 0;
        }

        public void PlayGame(bool win)
        {
            playedGames += 1;
            if (win)
                wonGames += 1;
        }

    }
}