// **Задача 3**

// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


Console.WriteLine("Задача № 3 - выведение в консоль элементов произвольного  массива с помощью рекурсии");


// Создаём массив из произвольного количества элементов, заданного с клавиатуры, заполняем его также данными с клавитауры


Console.Write("Введите число для размера массива - ");
int num = Convert.ToInt32(Console.ReadLine());
int[] MyArray = new int[num];

for(int i = 0; i < MyArray.Length; i++)
{
    // Console.Write("Введите числа для заполнения массива - ");
    Console.WriteLine("Введите число {0}:", i + 1);
    MyArray[i] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n Получен массив:");
        foreach (var item in MyArray)
        {
            Console.Write(i + " ");
        }

    // Console.WriteLine("Получен массив:");
    // Console.Write(MyArray[i] + ", ");
}

void PrintReverseMyArray(int [] MyArray, int i = 0)
        {
            if (i < MyArray.Length)
            {PrintReverseMyArray(MyArray, i+1);
            Console.Write(MyArray[i] + ", ");}
        }

Console.WriteLine(" ");
Console.WriteLine("Элементы массива в обратном порядке: ");
PrintReverseMyArray(MyArray);