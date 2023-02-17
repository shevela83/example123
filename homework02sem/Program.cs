Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int n = int.Parse(Console.ReadLine());
n = (n / 10) % 10;
Console.WriteLine(n);
