﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int returnSecondNumber(int number)
{
    int updateNumber = number/10;
    return updateNumber%10;
}
Console.WriteLine("Задача 1");
Console.Write("Введите трехзначное число: ");
int someNumb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра вашего числа: {returnSecondNumber(someNumb)}");
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/