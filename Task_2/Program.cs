/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

// int number = Convert.ToInt16 (Console.ReadLine()); 


System.Console.WriteLine( "Введите число: ");

string number = Console.ReadLine();

if (number.Length > 2) Console.WriteLine($"Результат: {number [2]}");
else Console.WriteLine("Результат: третьей цифры нет");



