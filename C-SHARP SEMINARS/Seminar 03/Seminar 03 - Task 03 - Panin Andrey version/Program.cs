double[] array = new double[10];
for(int i = 0; i < array.Length; i++)
{
    double a = new Random().Next(1, 100);
    double b = new Random().NextDouble();
    array[i] = Math.Round(a + b, 2);
    Console.Write(array[i] + " ");
}
double max = array[0];
double min = array[0];
for(int i = 0; i< array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    else if(array[i] < min)
    {
        min = array[i];
    }
}
double result = max - min;
Console.Write($"=> {result}");