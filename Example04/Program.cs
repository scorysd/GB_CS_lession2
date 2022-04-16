Console.Clear();
Console.WriteLine("Введите число, соотвтетствуещее дню недели: ");
int date = Convert.ToInt32(Console.ReadLine());
if (date>7 | date<0)
{
    Console.WriteLine($"Введеное число: {date} не соответствует дню недели"); 
}
else if (date==6 | date==7)
{
    Console.WriteLine($"Выходной"); 
}
else 
{
    Console.WriteLine($"Нет, не выходной"); 
}    
    