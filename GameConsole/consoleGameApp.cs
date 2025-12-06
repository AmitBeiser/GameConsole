using System;
using GameConsole.Base;
namespace GameConsole;
public class consoleGameApp
{
    private Screen mainPage;
        public consoleGameApp()
        {
            this.mainPage = new Pages.WelcomeScreen();
        }
        public void StartApp()
        {
            mainPage.Show();
        } 
}
