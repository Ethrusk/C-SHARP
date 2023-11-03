﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// 1. Cоздать цикл приема чисел А и Б 
// 2. Использовать метод Math.Pow(A,Б) для возведения числа А в натуральную степень B 


void numberAB(double a , double b) // Понятие метода. Примеры методов в классах. Возврат из метода. 
                                   // Оператор return. Методы без параметров. Ключевое слово void
                                   // https://www.bestprog.net/ru/2018/10/25/the-concept-of-the-method-examples-of-methods-in-classes-return-from-method-the-return-statement-methods-without-parameters-the-void-keyword_ru/
                                   // Если метод ничего не возвращает, то вместо типа указывается слово void
                                        // void MethodName(parameters_list)
                                        // {
                                        //     // ...
                                        // }
                                        // где parameter_list – список параметров метода с именем MethodName, которые он получает.


{    
    while(a < 10 && b < 10) // этот цикл возводит числа в степень, начиная от введённых с консоли
                            // и заканчивая числом меньше 10 (9)
                            // Если хотим возведения в степнеь только одного числа, то нужно убрать цикл с шагами
    {
        double result = Math.Pow(a,b); // Math.Pow Возвращает указанное число, возведенное в указанную степень.
        Console.WriteLine($" {a} ^ {b} = {result}");
        a++;
        b++;
    }
  
}

Console.Write("Введите число A : ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B : ");
double y = Convert.ToDouble(Console.ReadLine());
numberAB(x,y);


//-------------------------------------------------------
// int Promt(string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }















   
