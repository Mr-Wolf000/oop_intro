bool[] Prime(int n) {
    // gives array that are all true
    bool[] primes = new bool[n-1];
    for (int i = 0 ; i<primes.Length ; i++) {
        primes[i] = true;
    }
    for (int j = 2 ; j<Math.Sqrt(n) ; j++) {
        if (primes[j-2]==true) {
            int x = 0;
            while (j*j+x*j<=n) {
                primes[(j*j+x*j)-2] = false;
                x++;
            }
        }
    }
    return primes;
}

// Gives a sting that contains all the number that are thought of as prime
string print(bool[] bs) {
    string display = "";
    for (int i = 0 ; i<bs.Length ; i++) {
        if (bs[i]==true) {
            display += i+2+", ";
        }
    }
    return display;
}

// test case for the first 50 prime numbers
Console.WriteLine(print(Prime(1000000)));