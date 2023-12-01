// **Задача 1**

// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


Console.WriteLine("Задача № 1 - выведение в консоль всех натуральных чисел от M до N");

void PrintNaturalNumbers(int m, int n) // Рекурсивный метод вывода на печать чисел в диапазоне от M до N
{
    if (m > n)
    {return;}

    Console.Write($"{m}  ");
    PrintNaturalNumbers(m + 1, n);
}


Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

while (m <= 0 || n <=0) // Проверка чисел на натуральность
        {
            Console.WriteLine("Оба числа должны быть натуральными.");
            Console.WriteLine("Введите число M: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

Console.WriteLine("Диапазон значений от M до N: ");
PrintNaturalNumbers(m, n);