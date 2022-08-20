/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Задача 1");
Console.Write("Введите первое число: ");
int firstNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumb = Convert.ToInt32(Console.ReadLine());
if (firstNumb>secondNumb)
{
    Console.WriteLine("Максимальное число = "+firstNumb+"\n"+"Минимальное число = "+secondNumb);
}
else if(firstNumb==secondNumb)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine("Максимальное число = "+secondNumb+"\n"+"Минимальное число = "+firstNumb);
}

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Задача 2");
Console.Write("Введите первое число: ");
firstNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
secondNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumb = Convert.ToInt32(Console.ReadLine());
int max = firstNumb;
if (secondNumb>max) max = secondNumb;
if (thirdNumb>max) max = thirdNumb;
Console.WriteLine("Максимальное число = "+max);

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Задача 3");
Console.Write("Введите число на проверку четности: ");
int evenNumb = Convert.ToInt32(Console.ReadLine());
if (evenNumb%2==0) 
{
    Console.WriteLine("Число "+evenNumb+" четное");
}
else
{
    Console.WriteLine("Число "+evenNumb+" НЕ четное");
}
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Задача 4");
Console.Write("Введите введите конечное число ряда: ");
int nNumb = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= nNumb)
{
    if (count%2==0) Console.Write(count+" ");
    count++;
}