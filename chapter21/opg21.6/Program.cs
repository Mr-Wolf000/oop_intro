Matrix test = new Matrix(2,2);
Matrix test2 = new Matrix("text.csv");
Console.WriteLine(test);
Console.WriteLine(test2);

class Matrix {
    public double[][] data;

    public Matrix(string filename) {
    }

    
    public Matrix(int a, int b) {
        data = new double[a][];
        for (int i = 0 ; i<a ; i++) {
            data[i] = new double[b];
        }
    }
    public override string ToString() {
        string output = "";
        foreach (double[] line in data) {
            foreach (double num in line) {
                output+=(num+", ");
            }
            output+="\n";
        }
        return output;
    }
}





// TextWriter tw = new StreamWriter(System.IO.File.OpenWrite("text.csv"));
// tw.WriteLine("Something else!");
// tw.Close();

// TextReader tr = new StreamReader(System.IO.File.OpenRead("text.csv"));
// Console.WriteLine(tr.ReadLine());
// tr.Close();