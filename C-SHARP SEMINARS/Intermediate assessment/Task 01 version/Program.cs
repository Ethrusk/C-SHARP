// **Задача 1**

// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.




Console.WriteLine("Задача № 1 - выведение в консоль всех натуральных чисел от M до N");

// Метод проверки числа на натуральность



Console.WriteLine("Введите значения M и N:");
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        while (m <= 0 || n <=0)
        {
            Console.WriteLine("Оба числа должны быть натуральными.");
            Console.WriteLine("Введите значения M и N:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
        }

        PrintNaturalNumbers(m, n);
    

    void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintNaturalNumbers(m + 1, n);
        }
    }

bool IsNaturalNumber(int number)
    {
        return !(number % 1 == 0);
    }
