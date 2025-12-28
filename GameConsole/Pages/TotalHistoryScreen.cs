using System;
using GameConsole.Base;
namespace GameConsole.Pages;
internal class TotalHistoryScreen : Screen
{
    public TotalHistoryScreen() : base("Total History Screen", ConsoleColor.DarkBlue)
    {
    }
    public override void Show()
    {
        Console.Clear();
        CenterText("=== Game History ===");
        Console.WriteLine();
        if (consoleGameApp.user.HighScores.Count == 0)
            CenterText("No game history available.");
        else
            foreach (var score in consoleGameApp.user.HighScores)
                CenterText($"{score.GameName} - {score.Score} - {score.Date}");

        Console.WriteLine();
        CenterText("Press any key to return to the Connected Screen...");
        Console.ReadKey();
        Screen next = new ConnectedScreen();
        next.Show();
    }
}