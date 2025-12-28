using System;
using GameConsole.Base;
using System.Linq;
namespace GameConsole.Pages;

public class HistoryByName : Screen
{
    public HistoryByName() : base("History By Name Screen", ConsoleColor.DarkBlue)
    {
    }
    public override void Show()
    {
        Console.Clear();
        CenterText("USER GAME HISTORY BY NAME");
        var history = consoleGameApp.user.HighScores;
        history.OrderBy(h => h.GameName).ToList();
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