Customer aCustomer = new Customer("Magnus", 1, 5000);
aCustomer.Withdraw(100);
Console.WriteLine(aCustomer.GetBalance());

public class Customer {
    public string name;
    public int id;
    public double balance;

    // counstructer with all params
    public Customer(string nameInput, int idInput, double balanceInput) {
        name = nameInput;
        id = idInput;
        balance = balanceInput;
    }
    // constructer with only name and id
    public Customer(string nameInput, int idInput) {
        name = nameInput;
        id = idInput;
        balance = 0;
    }

    public void Deposit(double amount) {
        balance += amount;
    }

    public void Withdraw(double amount) {
        if (amount<=balance) {
            balance -= amount;
        } else {
            Console.WriteLine("Not posible, you are too poor");
        }
    }

    public double GetBalance() {
        return(balance);
    }
}