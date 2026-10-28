Inventory inventory = new Inventory();
inventory.AddItem(new FoodItem("Bread",9.99,2000));
inventory.AddItem(new NonFoodItem("Hammer",200.75,["Metal","Wood"]));

Console.WriteLine(inventory.GetInventoryValue());
inventory.PrintInventory();
