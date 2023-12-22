﻿// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения 
// на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, 
//    если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, 
//    что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// *Задача*:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// *Примеры*:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Результат:");
        foreach (string s in resultArray)
        {
            Console.WriteLine(s);
        }
    }

    static string[] FilterArray(string[] inputArray)
    {
        int count = 0;
        foreach (string s in inputArray)
        {
            if (s.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        foreach (string s in inputArray)
        {
            if (s.Length <= 3)
            {
                resultArray[index] = s;
                index++;
            }
        }

        return resultArray;
    }
}
