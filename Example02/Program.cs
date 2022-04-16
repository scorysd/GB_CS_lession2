Console.Clear();
int rnd = new Random().Next(100, 999);
Console.WriteLine(rnd);
int a = rnd%10;
int b = rnd/100;
Console.WriteLine($"{b}{a}");

