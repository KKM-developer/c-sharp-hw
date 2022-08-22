/*
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
void thirdNumber(int number)
{
    int lenght = Convert.ToInt32(Math.Log10(number));
    if (lenght>2)
    {
        int pow = Convert.ToInt32(Math.Pow(10, lenght));
        int powDel = pow/100;
        int numb = number / powDel;
        int answer = numb % 10;
        Console.WriteLine($"Третья цифра вашего числа: {answer}");
    }
    else
    {
        Console.WriteLine($"Нет третьей цифры в вашем числе: {number}");
    }


}
Console.WriteLine("Задача 2");
Console.Write("Введите число: ");
someNumb = Convert.ToInt32(Console.ReadLine());
thirdNumber(someNumb);
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/