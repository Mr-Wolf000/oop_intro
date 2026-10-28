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