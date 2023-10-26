// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество 
// чётных чисел в массиве.
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4


Console.WriteLine("Задача 02 - нахождение количества чётных чисел в массиве из 10 целых чисел");

int[] array = new int[10];

Console.WriteLine("Получен массив:");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + "; ");
}        

int count = 0;

Console.WriteLine(" ");
Console.WriteLine("Количество чётных чисел в массиве: ");
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    count++;
}

Console.Write(count);