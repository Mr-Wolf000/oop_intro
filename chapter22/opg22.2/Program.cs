double time1 = Math.Pow(10,3);
double time2 = Math.Pow(10,4);
double time3 = Math.Pow(10,5);
double time4 = Math.Pow(10,6);

DateTime date1 = DateTimeOffset.FromUnixTimeMilliseconds((long)time1).DateTime;
DateTime date2 = DateTimeOffset.FromUnixTimeMilliseconds((long)time2).DateTime;
DateTime date3 = DateTimeOffset.FromUnixTimeMilliseconds((long)time3).DateTime;
DateTime date4 = DateTimeOffset.FromUnixTimeMilliseconds((long)time4).DateTime;

Console.WriteLine(date1);
Console.WriteLine(date2);
Console.WriteLine(date3);
Console.WriteLine(date4);