// Создаём одномерный массив заданной длины и заполняем его


int[] array = new int[10];

Console.WriteLine("Получен массив:");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + "; ");
}   