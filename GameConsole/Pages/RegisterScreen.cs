using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Data;
using GameConsole.Models;
namespace GameConsole.Pages
{
	internal class RegisterScreen : Screen
	{
		public RegisterScreen() : base("Register Page", ConsoleColor.DarkMagenta)
		{
		}
		public override void Show()
		{
			base.Show();
			CenterText("Enter Your Desired Details");
			CenterText("Name:");
			string name = Console.ReadLine();
			CenterText("Username:");
			string username = Console.ReadLine();
			CenterText("Password:");
			string password = Console.ReadLine();
			var newUser = UserDb.RegisterUser(name, username, password);
			consoleGameApp.user = newUser;
			CenterText("Registration Successful! Press any key to continue...");
			Console.ReadKey();
			Screen next = new MainMenu();
			next.Show();
		}
	}
}
