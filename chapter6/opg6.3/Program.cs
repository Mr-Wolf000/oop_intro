int time = 21816000;
double price = 599.95;
int day_t = 24*60*60;
int month_t = day_t*30;
int month = (time/month_t);
Console.WriteLine("The month is: "+month);

if (month+1==12) {
    Console.WriteLine("Therefore the price is: "+price*0.7);
} else {
    Console.WriteLine("Therefore the price is: "+price);
}