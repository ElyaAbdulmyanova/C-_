/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers (int number)
{
    int count = Convert.ToString(number).Length;
    int sum = 0;

   /* for ( int i = 0; i < count; i++)
    {
        sum += number - ((number - (number % 10)));
        number /= 10;
    } */
    while (number > 0)
    {
        sum += number - ((number - (number % 10)));
        number /= 10;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр числа {number} = {SumNumbers(number)}");