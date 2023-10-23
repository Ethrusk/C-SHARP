// **Задача 13:** Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Сперва надо определить число 3х-значное или нет, или больше
// Если нет, то сразу понятно, что третьего числа нет
// Если 3 и более знака, то третья цифра - это сотни.
// Но 3е число определяется делением 3х=значного числа с остатком на 10
// Таким образом надо сперва определить длину числа и откинуть лишние цифры.
// Или же делить на 10 без остатка до тех пока результат не окажется в диапазоне от 100 до 999
// И надо разделить его с остатком на 10, и получим 3ю цифру.

// Console.WriteLine("Введите любое число");

// int AnyNumber = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Вы ввели число ");
// // Console.Write(AnyNumber);

// int number = 0;

// // for (int i = 0; i <= AnyNumber; i++)
// //     {
// //     int Result = AnyNumber % 10;
    
// //         while (Result > 100 && Result < 999)
// //         {    int ThirdNumber = Result / 10;
// //              Console.Write("Третья цифра введённого числа - ");
// //              Console.Write(ThirdNumber);
// //         }


// //     }

// int ThirdDigit(int AnyNumber)
//         {
//             int result = -1;
//             if (AnyNumber >= 100)
//             {
//                 while (number > 999)
//                 {
//                     number = number / 10;
//                 }
//                 result = number % 10;
//             }
//             return result; 
//         }

// int GetSecond(int k)
//         {
//         while (k >= 100) k /= 10;
//         int d = k % 10;
//         return d;
//         }
//         Console.WriteLine(GetSecond(k));


// Console.WriteLine("Введите трехзначное число");
//         int.TryParse(Console.ReadLine()!, out int k);
    
//         if (k>999 || k<100)
//         {
//         Console.WriteLine("Не трехзначное число!!!");
//         return;
//         }
//         int GetSecond(int k)
//         {
//         while (k >= 100) k /= 10;
//         int d = k % 10;
//         return d;
//         }
//         Console.WriteLine(GetSecond(k));


int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));


// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}