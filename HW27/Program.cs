// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumbSumm(int numb)
{
    int summ = 0;
    while (numb >= 1)
    {
        summ += numb % 10;
        numb = numb / 10;
    }
    return summ;
}

Console.Clear();
Console.Write("Введите натуральное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
while (numb <= 0)
{
    Console.WriteLine ("Число должно быть натуральным!!! Введите ещё раз: ");
    numb = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Сумма цифр числа равна {NumbSumm(numb)}");
