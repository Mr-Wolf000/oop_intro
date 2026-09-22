const double pi = 3.1415;
double area(int r) {
    return r*r*pi;
}
for (int i = 1 ; i<=10 ; i+=2) {
    Console.WriteLine("For a cirkle with radius: {1} the area is {0:F2}", area(i), i);
}