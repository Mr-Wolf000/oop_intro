int[] accounts = {903, 716, 67};

int GetAccountNumber () {
    Console.WriteLine("Enter an account number: ");
    try {
    return Convert.ToInt32(Console.ReadLine());
    } catch (FormatException) {
        Console.WriteLine("Invalid input, make sure you input a int");
        return GetAccountNumber ();
    }
}
void PrintAccountState (int accountId) {
        Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}
while (true) {
    int accountId = GetAccountNumber();
    try {
        PrintAccountState(accountId);
    } catch (IndexOutOfRangeException) {
        Console.WriteLine("Account {0} is not found in the database", accountId);
    }
}