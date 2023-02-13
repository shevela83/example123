//три числа на ввод max
Console.Write ("Введите первое число: ");
int first = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите третье число: ");
int third = int.Parse(Console.ReadLine() ?? "0");
int max = first;
if(second > first)
{
    second = max;
}
if(third > max)
{
    max = third;
}
{
    Console.WriteLine ("Число " + max);
}