// Рекурсивный метод вывода на печать чисел в диапазоне от M до N
// Рекурсивная функция - это функция, которая вызывает саму себя в своем теле. 
// В данном случае, если "m" больше "n", то функция просто возвращает управление ({return;}),
// Если "m" меньше или равно "n", то она выводит "m" в консоль и затем вызывает себя рекурсивно для "m + 1" и "n"
// Это продолжается, пока "m" не станет больше "n", после чего цикл/процесс прекращается и функция завершается.

void PrintNaturalNumbers(int m, int n) 
{
    if (m > n)
    {return;}

    Console.Write($"{m}  ");
    PrintNaturalNumbers( m + 1, n);
    Console.Write();
}