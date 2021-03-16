using System;
using System.Collections.Generic;
using System.Linq;

namespace Proj12_2_Wizard_Inventory {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("The Wizard Inventory game");

			List<String> inventory = new List<String>();
			inventory.Add("wooden staff");
			inventory.Add("wizard hate");
			inventory.Add("cloth shoes");

			String Command = "";

			while (!Command.Contains("exit")) {
				Console.WriteLine("COMMAND MENU");
				Console.WriteLine("show - Show all items");
				Console.WriteLine("grab - Grab an item");
				Console.WriteLine("edit - Edit an item");
				Console.WriteLine("drop - Drop an item");
				Console.WriteLine("exit - Exit program");
				String choice = MyConsole.getRequiredString("Command: ");

				switch (Command) {
					case "show":
						//show - show all items - loop through 'items' and display each
						//			NOTE: item # is NOT the index #, its index + 1
						for (int i = 0; i < inventory.Count(); i++) {
							Console.WriteLine((i + 1) + ". " + inventory[i]);
						}
						break;
					case "grab":
						//check # of items. max is 4
						if (inventory.Count() >= 4) {
							Console.WriteLine("Max items reached. Drop an item before adding.");
						} else {
							String name = MyConsole.getRequiredString("Name:  ");
							inventory.Add(name);
							Console.WriteLine(name + " was added.");
						}
						//grab - grab an item (add n ew item to 'items')
						//			Prompt user for new item name and add to 'items'
						break;
					case "edit":
						//edit - change the name of an item
						//			Prompt user for item #, validate that item #
						int itemNbr = MyConsole.GetInt("Number: ", 0, (inventory.Count() + 1));
						//			Prompt user for update name, save that in the list
						if (validateItemNumber(itemNbr, inventory)) {
							String updName = MyConsole.getRequiredString("Updated name: ");
							inventory.Insert((itemNbr - 1), updName);
							Console.WriteLine("Item " + itemNbr + " was updated.");
							//			"Item x was updated"
						} else {
							Console.WriteLine("Item nbr not valid.");
						}

						break;
					case "drop":
						//drop - drop an item (remove from items)
						//			Prompt user for item #, validate that item #
						itemNbr = MyConsole.GetInt("Number: ", 0, (inventory.Count() + 1));
						if (validateItemNumber(itemNbr, inventory)) {
                            //			Remove item from list and capture item name
                            //			"'Item name' was dropped"
                            String droppedItem = inventory[itemNbr - 1];
							Console.WriteLine(droppedItem + " was dropped.");
						} else {
							Console.WriteLine("Item nbr not valid.");
						}
						break;
					case "exit":
						//exit - exit the app
						break;
					default:
						Console.WriteLine("Invalid command, try again.");
						break;
				}



				Console.WriteLine("Bye");
			}
            static Boolean validateItemNumber(int itemNbr, List<string> inventory) {
				return inventory[itemNbr - 1] != null;
			}
		}
	}
}
	
