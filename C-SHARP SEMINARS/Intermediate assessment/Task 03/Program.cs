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



// void PrintReverseArray (int[] MyArray, int size)
// {
//     if(size <= 1)
//     {return;}
//     else 
//     {
//         int temp;
//         int i=0;
//         temp = MyArray[i];
//         MyArray[i] = MyArray[size-1];
//         MyArray[size-1] = temp;
//         PrintReverseArray (MyArray[i], size-2);
//     }    
//     //     Console.Write(" " + MyArray[i++]);
//     //     // Console.Write(" ");
//     //     PrintArray(MyArray, i);
//     // }
// }


// // void Main(string[] args)
// // {
//     int[] MyArray = {1, 2, 5, 0, 10, 34};
//     PrintReverseArray(MyArray);
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


//  static void Print2(object[] arr)
//         {
//             if (arr.Length == 0) return;
//             else
//             {
//                 Console.Write(" " + arr[0]);
//                 Print2(arr.Skip(1).ToArray());
//             }
//         }

// int[] numbers = { 1, 2, 5, 0, 10, 34 };
             
// int n = numbers.Length; // длина массива
// int k = n / 2;          // середина массива
// int temp;               // вспомогательный элемент для обмена значениями
// for(int i=0; i < k; i++)
// {
//     temp = numbers[i];
//     numbers[i] = numbers[n - i - 1];
//     numbers[n - i - 1] = temp;
// }
// foreach(int i in numbers)
// {
//     Console.Write($"{i} \t");
// }
//*********************************

void PrintReverseArray(int [] MyArray, int i = 0)
        {
            if (i < MyArray.Length)
            {PrintReverseArray(MyArray, i+1);
            Console.WriteLine(MyArray[i]);}
        }

int[] MyArray = {1, 2, 5, 0, 10, 34};
PrintReverseArray(MyArray);