using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameConsole.Base
{
	internal class MenuScreen : Screen
	{
		private List<MenuItem> items;
		public MenuScreen(string title) : base(title, ConsoleColor.Blue)
		{
			items=new List<MenuItem>();
		}
		public void Add(MenuItem item)
		{
			if(item!!=null)
			items.Add(item);
		}
		public void Add(string displayName, Screen sc)
		{
			items.Add(new MenuItem(displayName, sc));
		}
		public override void Show()
		{
			base.Show();

			CenterText("Choose your Screen:");
			bool exit = false;
			while (!exit)
			{
				for (int i = 0; i < items.Count; i++)
				{
					CenterText($"{i + 1} - {items[i].DisplayName}");
				}
				int exitOption = items.Count + 1;
				CenterText($"{exitOption} - Exit");

				CenterText($"Choose between 1-{exitOption}:");
				string? input = Console.ReadLine();
				if (!int.TryParse(input, out int choice))
				{
					CenterText("Invalid selection. Press any key to try again.");
					Console.ReadKey(true);
					Console.Clear();
					base.Show();
					continue;
				}

				if (choice == exitOption)
				{
					exit = true;
					break;
				}

				if (choice >= 1 && choice <= items.Count)
				{
					Console.Clear();
					items[choice - 1].Screen.Show();
					Console.Clear();
					base.Show();
					continue;
				}

				CenterText("Selection out of range. Press any key to try again.");
				Console.ReadKey(true);
				Console.Clear();
				base.Show();
			}
			CenterText("Press any key to continue...");
			Console.ReadKey(true);
		}	
	}
}
