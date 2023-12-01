// **Задача 2**

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Задача № 2 - вычисление функции Аккермана с помощью рекурсии");

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

int Akkerman(int m, int n) // Метод вычисления функции Аккермана (для сверки смотрим иллюстрации в папке)
{
if (m == 0)
    {return n + 1;}
else if (n == 0 && m > 0)
    {return Akkerman(m - 1, 1);}
else
    {return (Akkerman(m - 1, Akkerman(m, n - 1)));}
}

Console.WriteLine("Значение функции Аккермана для введённых чисел: ");
Console.Write(Akkerman(m, n));