Console.Write("Введите число1:    ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2:    ");
int b=Convert.ToInt32(Console.ReadLine());
int c=b*b;
if (c==a)
    Console.WriteLine("Верно! " + b + " является квадратом числа " + a);
else
{
  Console.WriteLine("Не верно! " + b + " не является квадратом числа " + a);  
}
