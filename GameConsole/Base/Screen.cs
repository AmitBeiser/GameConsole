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
			CenterTitle(Title, TextColor);
		}
		public void CenterTitle(string title, ConsoleColor color)
		{
			var previousColor = Console.ForegroundColor;
			try
			{
				Console.ForegroundColor = color;
				
			var lines = title.Replace("\r", "").Split('\n');
			int startRow = Console.CursorTop; 
			for (int i = 0; i < lines.Length; i++)
			{
				string line = lines[i];
				if (line.Length > Console.WindowWidth) line = line.Substring(0, Console.WindowWidth);

				int x = Math.Max(0, (Console.WindowWidth - line.Length) / 2); 
				int y = startRow + i;
				if (y >= Console.WindowHeight) break;

				try
				{
					Console.SetCursorPosition(x, y);
					Console.ForegroundColor = color;
					Console.Write(line);
				}
				catch
				{
					Console.WriteLine(line);
					continue;
				}
			}
			int finalCursorRow = Math.Min(Console.WindowHeight - 1, startRow + lines.Length);
			try { Console.SetCursorPosition(0, finalCursorRow); } catch { }
			
			}
			finally
			{
				try { Console.ForegroundColor = previousColor; } catch { }
			}
		}

		public void CenterText(string text)
		{
			Console.SetCursorPosition((Console.WindowTop + Console.WindowWidth / 2)-text.Length/2, Console.CursorTop);
			Console.ForegroundColor = TextColor;
			Console.WriteLine(text);
		}

		

		

	}
}
