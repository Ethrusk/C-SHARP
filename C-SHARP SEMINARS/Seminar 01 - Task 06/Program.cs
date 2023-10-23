// ### Задача 6:
// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// 3 -> нет
// 7 -> нет

Console.WriteLine("Задача №6 - определение чётности или нечётности числа");

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Number);

if (Number % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(Number);
    Console.Write(" ");
    Console.Write("чётное");
}

else
{
    Console.Write("Число ");
    Console.Write(Number);
    Console.Write(" ");
    Console.Write("нечётное");
}