FoodItem[] foods = new FoodItem[10];
for (int i = 0 ; i<foods.Length ; i++) {
    foods[i] = new FoodItem("Apple",15,i);
}
foreach (FoodItem food in foods) {
    Console.WriteLine(food);
}

NonFoodItem[] nonFoods = new NonFoodItem[10];
for (int i = 0 ; i<nonFoods.Length ; i++) {
    nonFoods[i] = new NonFoodItem("Hammer",i*20,["Steel","Rubber"]);
}
foreach (NonFoodItem nonFood in nonFoods) {
    Console.WriteLine(nonFood);
}

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

    public string GetMaterials() {
        string display = "";
        foreach (string mat in materials) {
            display += mat+", ";
        }
        return display;
    }
    
    public NonFoodItem(string nameInput, double priceInput, string[] materialsInput) : base(nameInput, priceInput) {
        materials = materialsInput;
    }
}