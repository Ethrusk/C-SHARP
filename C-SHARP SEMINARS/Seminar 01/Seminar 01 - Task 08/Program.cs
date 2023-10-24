// ### Задача 8:
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 


Console.WriteLine("Введите целое число от 1 до 100");
int anyNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(anyNumber);

Console.Write("Это все числа от 1 до ");
Console.Write(anyNumber);
Console.Write(": ");

for (int i = 1; i <= anyNumber; i++)

{
    Console.Write(i + ", ");    
}

Console.WriteLine(" ");

Console.Write("Это все чётные числа от 1 до ");
Console.Write(anyNumber);
Console.Write(": ");

int even = 0;

while (even < (anyNumber - 1))
{
    even += 2;
    Console.Write(even + ", ");
}