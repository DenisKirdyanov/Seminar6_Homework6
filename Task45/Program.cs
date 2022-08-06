// Задача45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

int[] GetArray(int size, int min, int max)
{
    Console.Write("Ваш массив: ");
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    foreach (int i in result)
    {
        Console.Write($"  {i}  ");
    }
    Console.WriteLine();
    return result;
}

int[] r;

r = GetArray(8, 0, 20);

int[] Copy(int[] locArray)
{
    int[] copyArray = new int[locArray.Length];

    for (int i = 0; i < locArray.Length; i++)
    {
        copyArray[i] = locArray[i];
    }

    return copyArray;
}

Console.Write("Копия:      ");
foreach (int i in Copy(r) )
{
    Console.Write($"  {i}  ");
    
}
