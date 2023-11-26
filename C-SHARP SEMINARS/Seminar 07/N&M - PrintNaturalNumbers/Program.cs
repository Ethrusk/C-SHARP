
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию
// Исключить отрицательные числа и 0

Console.WriteLine("Введите значение M: ");
double m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
double n = Convert.ToInt32(Console.ReadLine());

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Введите целое положительное число");
}

void PrintNaturalNumbers(int m, int n)
{
    if (m > n)
    {return;}

    Console.Write($"{m}  ");
    PrintNaturalNumbers(m+1, n);
    Console.WriteLine();
}

PrintNaturalNumbers(m,n);


// иначе через цикл

// Задать значение N и M. Создать программу, которая выведет все натуральные числа в промежутке от N до M

Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");