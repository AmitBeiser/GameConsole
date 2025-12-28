using GameConsole.Base;
using GameConsole.Games;
using GameConsole.Interfaces;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class GameScreen : Screen
    {
        private IGamePlay game;

        public GameScreen(IGamePlay g) : base(g.Name, ConsoleColor.Green)
        {
            game = g;
        }

        public override void Show()
        {
            base.Show();
            CenterText($"Starting {game.Name}...");
            game.Play();
            HighScore highScore = new HighScore (game.Name, consoleGameApp.user.Username, game.Score);
            CenterText($"Your score: {game.Score}");
            consoleGameApp.user.ChangeHighScore(highScore);
            Console.ReadKey();
            Screen next = new ConnectedScreen();
            next.Show();
        }
    }
}