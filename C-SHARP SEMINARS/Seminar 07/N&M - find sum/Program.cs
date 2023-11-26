// Через рекурсию напишите программу, которая находит сумму натуральных элементов в промежутке от M до N

Volga_, Вот код со скрином:

Console.WriteLine("Чтобы узнать сумму натуральных чисел между числами M и N, введите целое положительное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чтобы узнать сумму натуральных чисел между числами M и N, введите целое положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
 
int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
            else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
            else if (M == N) return M;                       // Если M=N
            else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
            else return N + SumNumbers(M, N + 1);            // Если M>N
}
void Main(string[] args)
{
    Console.Write("M = ");
    int M = int.Parse(Console.ReadLine());
    Console.Write("N = ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
    Console.ReadLine();
}


// иначе


Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
Console.ReadLine();
 
static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
    else return N + SumNumbers(M, N + 1);            // Если M>N
}