class Program {
    public static void Main(string[] args) {
        Test<int> something = new Test<int>();
        something.Append(6);
        something.Append(6327);
        something.Append(67);
        something.Remove(1);
        something.Insert(1, 999);
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
        count++;
        T[] temp = new T[limit];
        for (int j = 0 ; j<i ; j++) {
            temp[j] = array[j];
        }
        temp[i] = element;
        for (int j = i+1 ; j<limit ; j++) {
            temp[j] = array [j-1];
        }
        array = temp;
    }
     public void Remove (int i) {
         T[] temp = new T[limit];
         for (int j = 0 ; j<i ; j++) {
             temp[j]=array[j];
         }
         for (int j = i+1 ; j<limit ; j++) {
             temp[j-1] = array[j]; 
         }
         array = temp;
         count--;
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