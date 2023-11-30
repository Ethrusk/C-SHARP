// **Задача 2**

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Задача № 2 - вычисление функции Аккермана с помощью рекурсии");

int Akkerman(int m, int n) // Метод вычисления функции Аккермана (для сверки смотрим иллюстрации в папке)
{
if (m == 0)
    {
        return n + 1;
    }
else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());


AkkermanFunction(m,n);

// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
Console.Write(Akkerman(m, n));
}

// функция Аккермана
int Akkerman(int m, int n)
{
if (m == 0)
    {
        return n + 1;
    }
else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


while (m <= 0 || n <=0) // Проверка чисел на натуральность
        {
            Console.WriteLine("Оба числа должны быть натуральными.");
            Console.WriteLine("Введите значение M: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

Console.WriteLine("Диапазон значений от M до N: ");
PrintNaturalNumbers(m, n);