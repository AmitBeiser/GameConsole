using System;
namespace GameConsole.Models;
internal class HighScore
{
    public string GameName { get; set; }
    public int Score { get; set; }
    public DateTime Date { get; set; }

    public HighScore(string gameName, int score)
    {
        GameName = gameName;
        Score = score;
        Date = DateTime.Now;
    }
}
