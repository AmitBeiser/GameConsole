using System;
using GameConsole.Base;
namespace GameConsole.Pages;
public class HistoryByScore : Screen
{
    public HistoryByScore() : base("History By Score Screen", ConsoleColor.DarkBlue)
    {
    }
    public override void Show()
    {
        Console.Clear();
        CenterText("USER GAME HISTORY BY SCORE");
        var history = consoleGameApp.user.HighScores;
        history.OrderBy(h => h.Score).ToList();
        if (history.Count == 0)
        {
            CenterText("No game history available.");
        }
        else
        {        
            foreach (var record in history)
            {
                CenterText($"{record.GameName} - Score: {record.Score} - Date: {record.Date}");
            }
        }
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
        var next = new ConnectedScreen();
        next.Show();
    }
}
