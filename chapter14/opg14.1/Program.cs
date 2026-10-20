Console.WriteLine("Hello, World!");

class Kitten {
    public double cuteness;
    public static int count = 0;

    public Kitten(double cutenessInput) {
        this.cuteness = cutenessInput;
        Kitten.count++;
    }
}