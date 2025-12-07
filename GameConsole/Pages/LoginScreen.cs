using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
	internal class LoginScreen : Screen
	{
		public LoginScreen() : base("Login Page")
		{
		}
		public override void Show()
		{
			base.Show();
			CenterText("Enter Login Info");
			CenterText("Username:");
			string username = Console.ReadLine();
			CenterText("Password:");
			string password = Console.ReadLine();
			UserDb.Login(username, password);
			CenterText("Login Successful! Press any key to continue...");
			Console.ReadKey();
			Screen next = new MainMenu();
			next.Show();
		}
	}
}
