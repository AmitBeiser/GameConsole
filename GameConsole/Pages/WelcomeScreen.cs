using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
	internal class WelcomeScreen: Screen
	{
		public WelcomeScreen() : base("WELCOME TO FIRST PAGE!")
        {
            Show();
        }

        public override void Show()
        {
            base.Show();

            String bob = "baruch aba";
            CenterText(bob);
            Console.ReadKey();
            Screen next = new MainMenu();
            next.Show();
        }
	}
}
