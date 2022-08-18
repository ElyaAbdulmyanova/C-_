/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Write("Введите ряд чисел через запятую : ");
string num = Console.ReadLine();

int [] ArrayOfNumbers (int size)

{
    string num = new char [num.Length];
    int [] result = new int [size];
    for (int i = 0; i< num.Length; i++)
    {
       result [i] = num[i];
               
    }
    return result;
}
int [] array = ArrayOfNumbers(8);

Console.WriteLine(array);
Console.Write($"Результат: [ {String.Join("; ", array )} ]");