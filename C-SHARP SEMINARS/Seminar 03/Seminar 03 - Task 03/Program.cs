// Урок 3. Массивы
// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// массив [10 21 14 93 23] => 2

Console.WriteLine("Задача 03 - нахождение значений в отрезке [20, 90] для массива из 10 целых чисел");

int[] array = new int[10];
bool inSpase = false;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + "; ");     
}

Console.WriteLine(" ");   

if(array[i] > 20 && array[i] < 90)
{
    inSpase = true;
    Console.Write(array[i] + "; ");
}