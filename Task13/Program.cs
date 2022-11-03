int ThirdNum(int num)
{

if(num > 99)
{



    while(num > 999)
{
     num = num / 10;
}

return num % 10;

}

else
{
   return -1;
}



}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int res = ThirdNum(number);

Console.WriteLine(res);


