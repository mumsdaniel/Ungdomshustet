using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuTest
{
	class Menu
	{
		public static void MainMenu()
		{
			Console.WriteLine("Vælg \n" +
				"1. Udlån\n" +
				"2. Udlånt\n" +
				"3. Hjemme\n" +
				"4. Aflever" +
				"\n"+
				"\n"+
				"\n"+
				"\n"+
				"\n"+
				"0. Afslut");

			string input = Console.ReadLine();

			switch(input){
				case "1":
					HomeMenu();
					break;
				case "2":

					break;
				case "3":

					break;
				case "4":

					break;
				case "0":
					Environment.Exit();



			}



		}

		public static void HomeMenu()
		{
			Console.Clear();
			Console.WriteLine("du kom");
			Console.ReadLine();
		}
	}
}
