// byte has range 0-255
byte a = 255;
Console.WriteLine(a); // returns 255

a++; // add one to make stack overflow
Console.WriteLine(a); // return 0 due to overflow

// workaround or fix
int b = 255;
Console.WriteLine(b); // retuns 255

b++; // adds one but no overflow due to int
Console.WriteLine(b); // returns 256 (no overflow)