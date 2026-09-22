int sum(int a, int b) {
    return a+b;
}

// Makes a table with i being the height and j being the length
for (int i = 1 ; i<15 ; i++) {
    for (int j = 1 ; j<10 ; j++) {
        Console.Write("{0,3}",sum(i,j));
    }
    Console.WriteLine("");
}