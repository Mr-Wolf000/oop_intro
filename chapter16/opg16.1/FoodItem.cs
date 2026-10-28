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
    public override bool IsExpired() {
        return(true);
    }
}