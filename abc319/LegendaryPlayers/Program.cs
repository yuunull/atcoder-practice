using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PlayersScore> PlayersList = new List<PlayersScore>();
            PlayersList.Add(new PlayersScore("tourist", 3858));
            PlayersList.Add(new PlayersScore("ksun48", 3679));
            PlayersList.Add(new PlayersScore("Benq", 3658));
            PlayersList.Add(new PlayersScore("Um_nik", 3648));
            PlayersList.Add(new PlayersScore("apiad", 3638));
            PlayersList.Add(new PlayersScore("Stonefeang", 3630));
            PlayersList.Add(new PlayersScore("ecnerwala", 3613));
            PlayersList.Add(new PlayersScore("mnbvmar", 3555));
            PlayersList.Add(new PlayersScore("newbiedmy", 3516));
            PlayersList.Add(new PlayersScore("semiexp", 3481));

            string s = Console.ReadLine();

            int result = PlayersList.Where(r => r.PlayerName == s).Select(r => r.Score).FirstOrDefault();

            Console.WriteLine(result);
        }
    }

    public class PlayersScore
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public PlayersScore(string playerName, int score)
        {
            PlayerName = playerName;
            Score = score;
        }
    }
}