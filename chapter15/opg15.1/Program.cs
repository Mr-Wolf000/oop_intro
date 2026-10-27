Inventory inventory = new Inventory();
inventory.AddItem(new FoodItem("Bread",9.99,2000));
inventory.AddItem(new NonFoodItem("Hammer",200.75,["Metal","Wood"]));

Console.WriteLine(inventory.GetInventoryValue());
inventory.PrintInventory();

// Classes
public class Item {
    public string name;
    public double price;

    public Item(string nameInput, double priceInput) {
        name = nameInput;
        price = priceInput;
    }
    
    public double GetPrice() {
        return price;
    }

    public string GetName() {
        return name;
    }

    public override string ToString() {
        return ("Name: "+name+"\nPrice: "+price);
    }
}

public class FoodItem : Item {
    int expiresAt;
    
    public FoodItem(string nameInput, double priceInput, int expiresAtInput) : base(nameInput, priceInput) {
        expiresAt = expiresAtInput;
    }
    public override string ToString() {
        return (base.ToString()+"\nExpires at: "+expiresAt);
    }
    public int GetExpiresAt() {
        return expiresAt;
    }
}

public class NonFoodItem : Item {
    string[] materials;

    public override string ToString() {
        string display = "";
        foreach (string mat in materials) {
            display += mat+", ";
        }
        return (base.ToString()+"\nMaterials list: "+display);
    }

    public string[] GetMaterials() {
        return materials;
    }
    
    public NonFoodItem(string nameInput, double priceInput, string[] materialsInput) : base(nameInput, priceInput) {
        materials = materialsInput;
    }
}

class Inventory {
    private Item[] items = new Item[100];

    public void AddItem(Item item) {
        for (int i = 0 ; i<items.Length ; i++) {
            if (items[i]==null) {
                items[i]=item;
                break;
            }
        }
    }
    public void RemoveItem(Item item) {
        for (int i = 0 ; i<items.Length ; i++) {
            if (item == items[i]) {
                items[i] = item;
            }
        }
    }
    public double GetInventoryValue() {
        double value = 0;
        foreach (Item item in items) {
            if (item== null) continue;
            value += item.GetPrice();
        }
        return value;
    }
    public void PrintInventory() {
        foreach (Item item in items) {
            if (item == null) continue;
            Console.WriteLine(item.GetName());
        }
    }
}