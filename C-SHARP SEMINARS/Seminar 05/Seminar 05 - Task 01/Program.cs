﻿// 💡 **Задача 1:**

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9

// 1) Ввести значения для количества строк и столбцов
// 2) Создать двумерный массив (метод GenerateArray2) 
// 3) Заполнить его случайными числами (метод PrintArray2)
// 3) Создать методы для каждого этапа

Console.WriteLine("Задача 01 - нахождение позиции элемента в двумерном массиве и возвращение его значения");

Console.Write("Введите количество строк массива (x): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (y): ");
int y = Convert.ToInt32(Console.ReadLine());

double[,] Array2D = new double[x, y];
Console.Write("Введите номер строки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int y2 = Convert.ToInt32(Console.ReadLine());

// Теперь нужно создать и заполнить массив



void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
Array2D[i,j] = rand.NextDouble();
Console.Write($"{Array2D[i,j]:F2} ");
}
Console.WriteLine();
}
}


mas(m,n);
if (m2<1 || n2<1)
Console.Write(«Позиции строк не могут быть отрицательными»);
else if (m2 <= m+1 && n2 <= n+1)
Console.Write($»Значение элемента равно {randomArray[m2-1,n2-1]:F2} «);
else Console.Write(«Такого элемента нет в массиве»);


// int [,] GenerateArray2()
// {

//     int[,] array2 = new int[2,3]; // двумерный массив размером 2 на 3
//     for (int i = 0; i < array2.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             array2[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array2;
// }                    


// // 2) Метод вывода двумерного массива в консоль
// void PrintArray2(int[,] array2) // void ничего не возвращает
// {
//     for (int i = 0; i < array2.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             Console.Write(array2[i, j] + "\t"); // значения выводятся через рассстояние tab (\t)
//         }
//         Console.WriteLine();
//     }
// }

// // Метод проверки существования позиции в массиве (по сути проверка размера массива) 
// // Проверка происходит через одномерный массив (в данном случае array1),
// // построчной проверкой ранее созданного массива
// // Метод возвращает значение элемента, если позиция найдена

// void IndexExist(int [,] array2, int [] array1) 
// {
//     if (array1[0] < array2.GetLength(0) && array1[1] < array2.GetLength(1))  
//     // если элемент массива array1 < 
//     {
//         Console.Write($"ЭЛЕМЕНТ МАССИВА {array2[array1[0],array1[1]]}");    
//     }
//         else 
//         {
//                 Console.Write("Такого элемента не сущестует");
//         }   
// }



// int[] EnterNumbers() //метод ввода чисел через , позиции элемента массива
// {
//     Console.Write("Введите номер позиции массива через , ");
//     string input = Console.ReadLine();
//     string[] arrayNumbers = input.Split(","); // .Split метод разделения текста (символ которым разделяют | , # и тд .)
//     int[] numbers = new int[arrayNumbers.Length];
//     for(int i  = 0; i < arrayNumbers.Length; i++)
//     {
//         numbers[i] = Convert.ToInt32(arrayNumbers[i]);
//     }
//     return numbers;
// }

// int[,] mass = GenerateArray2(); //инициализируем двумерный массив
// PrintArray(mass); //выводим массив на экран 
// int [] mass1 = EnterNumbers(); //чтобы прочитать два числа введенных через , создадим одномерный массив 
// IndexExist(mass,mass1); //выдаём в терминал число которое хранится в данном элементе или получаем ошибку если позиция введена не правильно
