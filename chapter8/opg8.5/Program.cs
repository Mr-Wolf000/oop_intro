// This number is the number that determens how presice we are.
// With the way bits work for floats (e.g 101.1011 being 5+(1/2)+(1/8)+(1/16)) we know that a bit n after the the "." is of value 1/(2^n)
// For what we are doing, its nice to only use number that we know the machine can reprecent nicely like 1/(2^16) (e.g 0.1 cant be reprecentet presicely)
const double dexNum = 1D/65536D; // 65536 = 2^16

// The function looks for the value that is closest to having i*i=n, by taking the number just before said number^2 before its greater than n
double sqrt(double n) {
    for (double i = 0 ; i<n ; i+=dexNum) {
        if (i*i>n) {
            return i-dexNum;
        }
    }
    
    // Case of no answer
    Console.WriteLine("A error happend, and sqrt({0}) could not be found",n);
    return -1;
}
Console.WriteLine(sqrt(2000));
Console.WriteLine(exp(2,16));
// The above implementation works, but its likely very slow, as it goes through the loop at a low increments, a way to improve this would be to go in larger and larger increments.
// (e.g start out by the increment of 1/2, and when i^2 > n then go to increment of 1/4, then 1/8, 1/16 ... 1/2^16) this should mean overall less steps

int exp(int b, int e) {
    int result = b;
    for (int i = 1; i<e ; i++) {
        result*=b;
    }
    return result;
}