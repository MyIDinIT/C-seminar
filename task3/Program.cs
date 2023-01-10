Console.Write("Введите число:    ");
int a = Convert.ToInt32(Console.ReadLine());

int b=a*(-1);

while (b<(a))
{
    Console.Write(b+", ");
    b=b+1;
}
if (b==a)
{
    Console.Write(b);
}