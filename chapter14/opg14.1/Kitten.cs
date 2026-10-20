class Kitten {
    public double cuteness;
    public static int count = 0;

    public Kitten(double cutenessInput) {
        this.cuteness = cutenessInput;
        Kitten.count++;
    }
    
    public static void Main(string[] args) {
        Kitten[] cats = new Kitten[10];
        for (int i = 0 ; i<10 ; i++) {
            cats[i] = new Kitten(i);
        }
        
        foreach (Kitten cat in cats) {
            Console.WriteLine($"Cuteness: {cat.cuteness}");
        }
        Console.WriteLine(Kitten.count);
    }
}