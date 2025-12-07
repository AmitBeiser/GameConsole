using System;
using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
namespace GameConsole.Pages;
internal class UpdateScreen : Screen
{
    public UpdateScreen() : base("Update Screen")
    {
    }
    public override void Show()
    {
        base.Show();
        User currentUser = consoleGameApp.user;
        CenterText("For Update Your Profile:");
        CenterText("Enter new name:");
        string newName = Console.ReadLine();
        CenterText("Enter new password:");
        string newPassword = Console.ReadLine();
        currentUser.Name = newName;
        currentUser.Password = newPassword;
        UserDb.Update(currentUser);
        CenterText("Profile updated successfully!");
        CenterText("Press any key to return to the main menu...");
        Console.ReadKey();
        Screen next = new MainMenu();
        next.Show();
    }
}