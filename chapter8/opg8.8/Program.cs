ulong fac(ulong n) {
    switch(n) {
        case 0:
            return 0;
        case 1:
            return 1;
        default:
            return n*fac(n-1);
    }
}
Console.WriteLine(fac(6));