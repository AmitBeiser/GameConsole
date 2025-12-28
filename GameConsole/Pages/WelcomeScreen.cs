using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
	internal class WelcomeScreen : Screen
	{
		public WelcomeScreen() : base($@"
        ╻ ╻┏━╸╻  ┏━╸┏━┓┏┳┓┏━╸
        ┃╻┃┣╸ ┃  ┃  ┃ ┃┃┃┃┣╸ 
        ┗┻┛┗━╸┗━╸┗━╸┗━┛╹ ╹┗━╸", ConsoleColor.Cyan)
        {
            Show();
        }

        public override void Show()
        {
            base.Show();
            System.Console.WriteLine();
            System.Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine($@"  ____                             _ _       _____    _                         _    ____       _ 
 |  _ \            /\             (_) |     |_   _|  | |                       | |  / __ \     (_)
 | |_) |_   _     /  \   _ __ ___  _| |_      | |  __| | ___     __ _ _ __   __| | | |  | |_ __ _ 
 |  _ <| | | |   / /\ \ | '_ ` _ \| | __|     | | / _` |/ _ \   / _` | '_ \ / _` | | |  | | '__| |
 | |_) | |_| |  / ____ \| | | | | | | |_ _   _| || (_| | (_) | | (_| | | | | (_| | | |__| | |  | |
 |____/ \__, | /_/    \_\_| |_| |_|_|\__( ) |_____\__,_|\___/   \__,_|_| |_|\__,_|  \____/|_|  |_|
         __/ |                          |/                                                        
        |___/");
            CenterText("Press any key to continue...");
            Console.ReadKey();
            Screen next = new MainMenu();
            next.Show();
        }
	}
}
