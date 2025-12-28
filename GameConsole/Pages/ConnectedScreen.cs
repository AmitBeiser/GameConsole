using System;
using GameConsole.Base;
namespace GameConsole.Pages;
internal class ConnectedScreen : MenuScreen
{
    public ConnectedScreen() : base("Connected Screen")
    {
        Add("Choose Game", new GamesOptionsScreen());
        Add("Profile", new ProfileMenu());
        Add("History", new HistoryMenu());
    }
}