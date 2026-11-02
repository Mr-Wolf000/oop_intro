class Program {
    public static void Main(string[] args) {
        Test<int> something = new Test<int>();
        Console.WriteLine(something);
        something.Append(6);
        Console.WriteLine(something);
    }
}

class Test<T> : IDynArray<T> {
    T[] array = new T[20];
    int count = 0;
    int limit = 20;
    
    public void Append(T element) {
        array[count] = element;
        count++;
    }
    public void Insert (int i, T element) { // Not working
        array[i] = element;
    }
     public void Remove (int i) {
         T[] temp = new T[limit];
         for (int j = 0 ; j<count ; j++) {
             if (j==i) {
                 continue;
             } else {
                 temp[j]=array[j];
             }
         }
         array = temp;
     }
    public void Set (int i, T element) {
        array[i] = element;
    }
    public T Get (int i) {
        return (array[i]);
    }
    public int GetFill () {
        return(count);
    }
    public override string ToString() {
        string output = "";
        for (int i = 0 ; i<limit ; i++) {
            output += $"{i}: {array[i]}\n";
        }
        return output;
    }
}

interface IDynArray<T> {
    void Append (T element);
    void Insert (int i, T element);
    void Remove (int i);
    void Set (int i, T element);
    T Get (int i);
    int GetFill ();
}