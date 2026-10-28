public abstract class Item : IExpireable {
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
    public abstract bool IsExpired();
}