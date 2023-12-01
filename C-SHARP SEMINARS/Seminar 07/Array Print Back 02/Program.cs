// Вот пример кода на C#, который создает массив из 10 элементов и выводит его элементы, 
// начиная с конца, используя рекурсию:

int[] array = new int[10];

        FillArray(array, 1); // Заполняем массив значениями от 1 до 10 с помощью рекурсии

        foreach (var element in ReverseArray(array))
        {
            Console.WriteLine(element);
        }
    

    void FillArray(int array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            arrayi = value;
            if (i < array.Length - 1)
            {
                FillArray(array, value + 1);
            }
        }
    }

    int ReverseArray(int array)
    {
        if (array == null || array.Length <= 0)
        {
            throw new ArgumentException("Массив не может быть пустым");
        }

        int[] reversedArray = new int array.Length();
        int index = 0;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            reversedArrayindex = arrayi;
            index++;
        }

        return reversedArray;
    }



// Этот код создает массив из 10 элементов, заполняет его значениями от 1 до 10 с помощью рекурсии, 
// а затем выводит его элементы, начиная с конца, также с помощью рекурсии.