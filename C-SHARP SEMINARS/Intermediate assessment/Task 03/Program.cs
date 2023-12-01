﻿// **Задача 3**

// Задайте произвольный массив. 
// Например {1, 2, 5, 0, 10, 34} => {34, 10, 0, 5, 2, 1}
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


Console.WriteLine("Задача № 3 - выведение в консоль элементов произвольного  массива с помощью рекурсии");

Console.WriteLine("\nИмеем массив {1, 2, 5, 0, 10, 34}");

void PrintReverseArray(int [] MyArray, int i = 0)
        {
            if (i < MyArray.Length)
            {PrintReverseArray(MyArray, i+1);
            Console.Write(MyArray[i] + ", ");}
        }

int[] MyArray = {1, 2, 5, 0, 10, 34};
Console.WriteLine("Элементы массива в обратном порядке: ");
Console.Write("{");
PrintReverseArray(MyArray);
Console.Write("}");