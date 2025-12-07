using System;
using GameConsole.Base;
using GameConsole.Models;
namespace GameConsole;
internal class consoleGameApp
{
    private Screen mainPage;
    public static User user { get; set; }
    public consoleGameApp()
    {
        this.mainPage = new Pages.WelcomeScreen();
    }
    public void StartApp()
    {
        mainPage.Show();
    } 
}