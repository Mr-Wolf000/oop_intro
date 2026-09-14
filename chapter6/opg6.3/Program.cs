int time = 21816000; // 21816000 is max and december 30th iin a 30 day pr month calender
double price = 599.95;
int day_t = 24*60*60;
int month_t = day_t*30;
int month = (time/month_t);
Console.WriteLine("The month is: "+month);

if (month==12) {
    Console.WriteLine("Therefore the price is: "+price*0.7);
} else {
    Console.WriteLine("Therefore the price is: "+price);
}