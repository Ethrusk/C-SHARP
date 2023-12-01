// **Задача 3**

// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


Console.WriteLine("Задача № 3 - выведение в консоль элементов произвольного  массива с помощью рекурсии");


// Создаём массив из 10 элементов, заполняем его произвольными числами и выводим в консоль

int[] MyArray = new int[10];

Console.WriteLine("Получен массив:");
for(int i = 0; i < MyArray.Length; i++)
{
    MyArray[i] = new Random().Next(1, 101);
    Console.Write(MyArray[i] + ", ");
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