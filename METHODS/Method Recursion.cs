﻿// https://metanit.com/sharp/tutorial/2.11.php

// Рекурсивная функция факториала
// Возьмем, к примеру, вычисление факториала, которое использует формулу n! = 1 * 2 * … * n. 
// То есть по сути для нахождения факториала числа мы перемножаем все числа до этого числа. 
// Например, факториал числа 4 равен 24 = 1 * 2 * 3 * 4, а факторил числа 5 равен 120 = 1 * 2 * 3 * 4 * 5.

// Определим метод для нахождения факториала:

// 1
// 2
// 3
// 4
// 5
// 6
// int Factorial(int n)
// {
//     if (n == 1) return 1;
 
//     return n * Factorial(n - 1);
// }
// При создании рекурсивной функции в ней обязательно должен быть некоторый базовый вариант, 
// с которого начинается вычисление функции. В случае с факториалом это факториал числа 1, 
// который равен 1. Факториалы всех остальных положительных чисел будет начинаться с вычисления 
// факториала числа 1, который равен 1.

// На уровне языка программирования для возвращения базового варианта применяется оператор return:

// 1
// if (n == 1) return 1;
// То есть, если вводимое число равно 1, то возвращается 1

// Другая особенность рекурсивных функций: все рекурсивные вызовы должны обращаться к подфункциям, 
// которые в конце концов сходятся к базовому варианту:

// 1
// return n * Factorial(n - 1);
// Так, при передаче в функцию числа, которое не равно 1, при дальнейших рекурсивных вызовах подфункций 
// в них будет передаваться каждый раз число, меньшее на единицу. И в конце концов мы дойдем до ситуации, 
// когда число будет равно 1, и будет использован базовый вариант. Это так называемый рекурсивный спуск.

// Используем эту функцию:

int Factorial(int n)
{
    if (n == 1) return 1;
 
    return n * Factorial(n - 1);
}
 
int factorial4 = Factorial(4);  // 24
int factorial5 = Factorial(5);  // 120
int factorial6 = Factorial(6);  // 720
 
Console.WriteLine($"Факториал числа 4 = {factorial4}");
Console.WriteLine($"Факториал числа 5 = {factorial5}");
Console.WriteLine($"Факториал числа 6 = {factorial6}");
