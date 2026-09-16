int[] normalYear = [31,28,31,30,31,30,31,31,30,31,30,31];
int[] leapYear = [31,29,31,30,31,30,31,31,30,31,30,31];
int month = 0;

for (int year = 0 ; year<=2000 ; year++) {
    if (year%4==0) {
        for (month = 0; month<leapYear.Length; month++) {
            Console.WriteLine(year+" month: "+month+" days: "+leapYear[month]);
        }
    }
    else {
        for (month = 0; month<normalYear.Length; month++) {
            Console.WriteLine(year+" month: "+month+" days: "+normalYear[month]);
        }
    }
}