using System;
using GameConsole.Base;
using GameConsole.Models;
namespace GameConsole.Pages;
public class DetailsScreen : Screen
{
    public DetailsScreen() : base("Details Screen", ConsoleColor.DarkGray)
    {
    }
    public override void Show()
    {
        base.Show();
        User currentUser = consoleGameApp.user;
        CenterText("User Profile:");
        CenterText($"Name: {currentUser.Name}");
        CenterText($"Username: {currentUser.Username}");
        CenterText("Press any key to return to the main menu...");
        Console.ReadKey();
        Screen next = new ConnectedScreen();
        next.Show();
    }
}
