Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number < 999)
{
    Console.WriteLine(number%10);
}
else
{
    do 
    {
    number = number/10;
    }
    while (number > 999);
    number = number%10;
    Console.WriteLine(number);
} 
