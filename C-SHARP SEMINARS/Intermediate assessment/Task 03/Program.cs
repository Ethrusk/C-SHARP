// **Задача 3**

// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


Console.WriteLine("Задача № 3 - выведение в консоль элементов произвольного  массива с помощью рекурсии");


// 1) Создаём массив из 10 элементов, заполняем его произвольными числами и выводим в консоль

// int[] array = new int[10];

// Console.WriteLine("Получен массив:");
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 101);
//     Console.Write(array[i] + "; ");
// }        
// 2) Теперь, с помощью рекурсии, выводим в консоль элементы этого массива в обратном порядке



void PrintReverseArray (int[] MyArray, int size)
{
    if(size <= 1)
    {return;}
    else 
    {
        int temp;
        int i=0;
        temp = MyArray[i];
        MyArray[i] = MyArray[size-1];
        MyArray[size-1] = temp;
        PrintReverseArray (MyArray[i], size-2);
    }    
    //     Console.Write(" " + MyArray[i++]);
    //     // Console.Write(" ");
    //     PrintArray(MyArray, i);
    // }
}

// void Main(string[] args)
// {
    int[] MyArray = {1, 2, 5, 0, 10, 34};
    PrintArray(MyArray);
// }
//*******************************************************

// Print(int[] array, int current = 0)
//         {
//             if (current == array.Length) return;
//             else
//             {
//                 Console.Write(" " + array[current++]);
//                 Print(array, current);
//             }
//         }

