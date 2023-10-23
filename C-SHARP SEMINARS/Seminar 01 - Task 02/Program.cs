// Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Задача № 2 - определение большего числа из двух");
Console.Write("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberA);
Console.Write("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberB);

int max = 0;

if (NumberA > NumberB)
{
    max = NumberA;
    Console.Write("Max = ");
    Console.WriteLine(max);
    Console.Write("Первое число больше второго числа");
}
else 
{
    max = NumberB;
    Console.Write("Max = ");
    Console.WriteLine(max);
    Console.Write("Второе число больше первого числа");
}