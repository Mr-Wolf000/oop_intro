const int timestamp = 100000000;
const int day_t = 24 * 60 * 60;
const int year_t = 365 * day_t;
int day;
int year;
year = timestamp/year_t;
day = timestamp/day_t-year*365;
Console.WriteLine(day);
Console.WriteLine(year);
