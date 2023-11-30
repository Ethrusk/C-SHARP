// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
