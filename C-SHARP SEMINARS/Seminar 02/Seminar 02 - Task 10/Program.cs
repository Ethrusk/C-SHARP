// **Задача 10:** Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает **вторую** цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Задача № 10 - определение и вывод в консоль второй цифры трёхзначного числа");
Console.WriteLine("Введите любое трёхзначное число и программа отобразит вторую цифру этого числа");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введённое вами число ");
Console.Write(number);

Console.WriteLine(" ");

if (100 < number && number < 1000)
{
    int SecondNumber = number % 100 / 10;
    Console.Write("Вторая цифра введённого вами числа - ");
    Console.Write(SecondNumber);
}
else
{
    Console.WriteLine("Введите число меньше 1000");
}