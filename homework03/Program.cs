Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int i = 2;
while(i <= n)
    {
        Console.WriteLine(i);
        i = i + 2;
    } 