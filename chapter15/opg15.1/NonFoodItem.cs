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