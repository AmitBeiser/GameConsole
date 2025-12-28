using System;
using GameConsole.Base;
using System.Linq;
namespace GameConsole.Pages;
public class LastGameScreen : Screen
{
    public LastGameScreen() : base("Last Game Screen", ConsoleColor.DarkBlue)
    {
    }
    public override void Show()
    {
        base.Show();
        var lastGame = consoleGameApp.user.HighScores.OrderByDescending(hs => hs.Date).FirstOrDefault();
        if (lastGame != null)
        {
            CenterText($"Last Game Played: {lastGame.GameName}");
            CenterText($"Score: {lastGame.Score}");
            CenterText($"Date: {lastGame.Date}");
        }
        else
            CenterText("No games played yet.");
        CenterText("Press any key to return to History Menu...");
        Console.ReadKey();
        Screen next = new HistoryMenu();
        next.Show();
    }
}
