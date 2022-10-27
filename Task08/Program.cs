Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

int Index = 0;

while (Index <= number1)
{
    if (Index % 2 > 0)
    {
      Console.Write("");
    }

     else
    {
       Console.Write($"{Index},");
    }
   
    Index++;
}



