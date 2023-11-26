﻿// Рекурсивный вывод массива
// Написать процедуру, выводящую на экран разделенные пробелами элементы массива, переданного в качестве параметра: void printArr(object[] arr). Использовать рекурсию вместо циклов.
// Показать работоспособность процедуры printArr на трех примерах.

// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


 static void Print(int[] array, int current = 0)
        {
            if (current == array.Length) return;
            else
            {
                Console.Write(" " + array[current++]);
                Print(array, current);
            }
        }

// иначе

 static void Print2(object[] arr)
        {
            if (arr.Length == 0) return;
            else
            {
                Console.Write(" " + arr[0]);
                Print2(arr.Skip(1).ToArray());
            }
        }


//  спасибо. Возник вопрос не по заданию. Что происходит с памятью при таком решении? Массив при каждом шаге рекурсии
// дублируются в меньшем размере или же тут по ссылкам идет обработка части исходного массива?

// На каждой итерации создается новый массив меньшего размера, решение очень неэффективно по используемой памяти.