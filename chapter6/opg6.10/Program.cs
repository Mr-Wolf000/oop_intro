bool isprime = true;
for (int num=3; num<=1000000;num+=2){
    isprime = true;
    for (int i = 2; i<num; i++) {
        if (num%i==0) {
            isprime = false;
            break;
        } 
    }
    if (isprime==true) {
        Console.WriteLine(num);
    }
}
Console.WriteLine(counter);
/*
for (int i=3; i<=1000000; i+=2) {
    isprime = true;
    for (int j=2; j<i; j++) {
        if (i%j==0) {
            isprime = false;
            break;
        }
    }
    if (isprime==true) {
        Console.WriteLine(i);
    }
}
*/