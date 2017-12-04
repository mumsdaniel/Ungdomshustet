using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuTest
{
	class Menu
	{
		public static void Menustart()
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
				"9. Afslut");

			string input = Console.ReadLine();

			switch(input){
				case "1":
					HomeMenu();
					break;
				case "2":
					break;



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
