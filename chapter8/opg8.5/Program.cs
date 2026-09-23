// Calculates b^e
double exp(double b, int e) {
    if (e<0) return 1D/exp(b,-e);
    if (e==0) return 1;
    double result = b;
    for (int i = 1; i<e ; i++) {
        result*=b;
    }
    return result;
}
// With the way bits work for floats (e.g 101.1011 being 5+(1/2)+(1/8)+(1/16)) we know that a bit n after the the "." is of value 1/(2^n)
// For what we are doing, its nice to only use number that we know the machine can reprecent nicely like 1/(2^16) (e.g 0.1 cant be reprecentet presicely in binary)

double sqrt(double n) {
    if (n<=0) return -1; //guard for invalid input
    double result = 0;
    double increment;
    // This for loop determens bit we use for the check, e.g j=-16 we look at the bit 16 after the . so the bit that represents 1/2^16.
    for (int j = 8; -32<j ; j--) {
        increment = exp(2,j); // Makes a increment that is the size of the bit we are working with (1/2^j)
        // When result^2 is not over n we can add the increment we are working with.
        while (result*result<=n) {
            result+=increment;
        }
        // Goes back to the value just before we went over, this ensures that the next increment will still have a impact
        result-=increment;
    } 
    return result;
}

Console.WriteLine(sqrt(75000));