// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Сколько чисел вы хотите ввести: ");
int n = int.Parse(Console.ReadLine());

int Enter(int num)
{
    int count = 0;
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент");
        array[i] = int.Parse(Console.ReadLine());
        if (array[i] > 0) count = count + 1;
    }

    return count;
}

Console.WriteLine($"Больше ноля: {Enter(n)}");
