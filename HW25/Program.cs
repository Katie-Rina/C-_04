// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double PowerNumber(double A, int B)
{
    double mult = 1;
    int i = 1;
    while (i <= B)
    {
        mult *= A;
        i += 1;
    }
    return mult;
}

Console.Clear();
Console.Write("Введите число А: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int B = Convert.ToInt32(Console.ReadLine());
while (B <= 0)
{
    Console.WriteLine ("Число В должно быть натуральным!!! Введите ещё раз: ");
    B = Convert.ToInt32(Console.ReadLine());
}
double pow = PowerNumber(A, B);
Console.WriteLine(pow);