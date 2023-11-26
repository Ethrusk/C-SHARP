// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии


Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void AllEvenNaturalNumbers(int m, int n)
    {
        if (m > n)
        return;

        if (m % 2 == 0)
            {
                Console.Write($"{m}, ");
            }
        AllEvenNaturalNumbers(m+1,n);
    }

AllEvenNaturalNumbers(m,n);

