public class FoodItem : Item {
    DateTime expiresAt;
    
    public FoodItem(string nameInput, double priceInput, DateTime expiresAtInput) : base(nameInput, priceInput) {
        expiresAt = expiresAtInput;
    }
    public override string ToString() {
        return (base.ToString()+"\nExpires at: "+expiresAt);
    }
    public DateTime GetExpiresAt() {
        return expiresAt;
    }
    public override bool IsExpired() {
    if (DateTime.Now > expiresAt) {
        return true;
    } else {
        return false;
    }
    }
}