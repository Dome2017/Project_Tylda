using System;

public class Class1
{
	public Class1()
	{
		public static void ShopMenu()
		{
			Console.WriteLine("Witaj w sklepie!");
			Console.WriteLine("Co chcesz kupić?");
			Console.WriteLine("1 - Mikstura zdrowia (20 złota)");
			switch ShopItem
			{
                case "1":
                    Console.WriteLine("Kupiłeś miksturę zdrowia!");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej opcji.");
                    break;
            }
        }
	}
}
