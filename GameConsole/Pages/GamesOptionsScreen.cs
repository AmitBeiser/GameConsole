using System;
using GameConsole.Base;
namespace GameConsole.Pages;
internal class GamesOptionsScreen : MenuScreen
{
    public GamesOptionsScreen() : base(@$"┏━╸┏━┓┏┳┓┏━╸┏━┓
┃╺┓┣━┫┃┃┃┣╸ ┗━┓
┗━┛╹ ╹╹ ╹┗━╸┗━┛")
    {
        Add("Play Fluffy Bird", new GameScreen(new Games.FluffyBirdGame()));
        Add("Play PacMan", new GameScreen(new Games.PacManGame()));
        Add("Play Tetris", new GameScreen(new Games.TetrisGame()));
    }
}