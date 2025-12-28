using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Towel.Measurements;

namespace GameConsole.Base
{
	public class Screen
	{
		public string Title
		{
			get; set;
		}
		public ConsoleColor TextColor { get; set; }
		public Screen(string title, ConsoleColor textColor)
		{
			Title = title;
			TextColor = textColor;
		}
		public virtual void Show()
		{
			Console.Clear();
			CenterText(Title);
		}

		public void CenterText(string text)
		{
			Console.SetCursorPosition((Console.WindowTop + Console.WindowWidth / 2)-text.Length/2, Console.CursorTop);
			Console.ForegroundColor = TextColor;
			Console.WriteLine(text);
		}

		

		

	}
}
