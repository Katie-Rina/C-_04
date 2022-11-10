// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

int[] CreateArray(int n, int s, int f)
{
    int[] mass = new int[n];
    for (int i = 0; i < n; i++)
    {
        mass[i] = new Random().Next(s, f + 1);
    }
    return mass;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Clear();
int[] array = CreateArray(8, -100, 100);
PrintArray(array);
