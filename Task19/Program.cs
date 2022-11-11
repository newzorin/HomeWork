Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 10000 && number <= 99999)
{



void ThirdNum(int num)
{
    int a = num /10000;
    int b = num %10;
    int c = num /10 % 10;
    int d = num /1000 % 10;

    if(a == b && c == d)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
 
ThirdNum(number);

}

else
{
   Console.WriteLine("это не пятизначное число");
}