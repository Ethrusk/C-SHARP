
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию

Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNaturalNumbers(int m, int n)
{
    if (m > n)
    return;

    Console.Write($"{m}, ");
    PrintNaturalNumbers(m+1, n);
    Console.WriteLine();
}

PrintNaturalNumbers(m,n);