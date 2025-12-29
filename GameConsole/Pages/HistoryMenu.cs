using System;
using GameConsole.Base;
namespace GameConsole.Pages;
internal class HistoryMenu : MenuScreen
{
    public HistoryMenu() : base(@$"
╻ ╻╻┏━┓╺┳╸┏━┓┏━┓╻ ╻
┣━┫┃┗━┓ ┃ ┃ ┃┣┳┛┗┳┛
╹ ╹╹┗━┛ ╹ ┗━┛╹┗╸ ╹ ")
    {
        Add("View Total History", new TotalHistoryScreen());
        Add("View History By Name", new HistoryByName());
        Add("View History By Score", new HistoryByScore());
        Add("View Last Game Played", new LastGameScreen());
    }
}
