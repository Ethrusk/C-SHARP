// Тренировка Example005-2.0_If_Else
Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine()!;

if(username.ToLower()! == "мила")
{
    Console.WriteLine("Ура! Это же Мила!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
