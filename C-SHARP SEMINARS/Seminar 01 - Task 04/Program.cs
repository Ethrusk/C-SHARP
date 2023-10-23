// ### Задача 4:
// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача №4 - определение максимального числа из трёх чисел");

Console.Write("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberA);

Console.Write("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberB);

Console.Write("Введите третье число: ");
int NumberС = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberС);

int max=0;

if (NumberA > max) max = NumberA;
if (NumberB > max) max = NumberB;
if (NumberС > max) max = NumberС;

Console.Write("Max = ");
Console.WriteLine(max);