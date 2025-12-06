using GameConsole.Base;
using GameConsole.Interfaces;
using GameConsole.Pages;
namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            consoleGameApp app = new consoleGameApp();
            app.StartApp();
		}
    }
}
