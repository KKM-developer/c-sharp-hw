/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
string palindrome(int number)
{
    if (number/10000 == number%10 && (number/1000)%10==(number%100)/10) return "число является палиндромом";
    else return "число НЕ является палиндромом";
}
try
{
    Console.WriteLine("Задача 1");
    Console.Write("Введите пятизначное число, чтобы проверить является ли оно палиндромом: ");
    int someNumb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(palindrome(someNumb));
}
catch
{
    Console.WriteLine("Необходимо ввести целое пятизначное число");
}
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
string getDistance()
{
    Console.Write("Введите X координату первой точки ");
    int firstX = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Y координату первой точки ");
    int firstY = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Z координату первой точки ");
    int firstZ = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите X координату второй точки ");
    int secondX = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Y координату второй точки ");
    int secondY = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Z координату второй точки ");
    int secondZ = Convert.ToInt32(Console.ReadLine());
    double distance = Math.Round(Math.Sqrt(Math.Pow(firstX-secondX, 2)+Math.Pow(firstY-secondY, 2)+Math.Pow(firstZ-secondZ, 2)), 2);
    return $"расстояние между двумя точками в 3D пространстве {distance}";
}
try
{
    Console.WriteLine("Задача 2");
    Console.WriteLine(getDistance());
}
catch
{
    Console.WriteLine("Необходимо вводить коортинаты целыми числами");    
}
/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
string returnPOW()
{
    Console.Write("Введите число, для составления таблици кубов ");
    int powNumb = Convert.ToInt32(Console.ReadLine());
    int start = 1;
    List<int> answer = new List<int> {};
    while (start <= powNumb)
    {
        int numb = Convert.ToInt32(Math.Pow(start, 3));
        start += 1;
        answer.Add(numb);
    }
    string answer1 = string.Join(", ", answer.ToArray());
    return answer1;

}
try
{
    Console.WriteLine("Задача 3");
    Console.WriteLine(returnPOW());
}
catch
{
    Console.WriteLine("Необходимо вводить целыми числами");  
}

/*
задача необязательная
Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, пока сумма 
введённых чисел не будет равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.
Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, после этого считывание продолжать не нужно.
В примере мы считываем числа 1, -3, 5, -6, -10, 13; в этот момент замечаем, что сумма этих чисел равна нулю и выводим сумму 
их квадратов, не обращая внимания на то, что остались ещё не прочитанные значения.

На входе:
1
-3
5
-6
-10
13
На выходе:
340
*/
int sumCube()
{
    int sum = 0;
    int cube = 0;
    int numb = 0;
    Console.WriteLine("Вводите целые числа (прогамма не остановится пока сумма выших чисел не будет равна 0): ");
    numb = Convert.ToInt32(Console.ReadLine());
    sum += numb;
    cube += Convert.ToInt32(Math.Pow(numb, 2));
    Console.WriteLine($"Текущая сумма Ваших чисел равна {sum}");
    while (sum != 0)
    {
        numb = Convert.ToInt32(Console.ReadLine());
        sum += numb;
        cube += Convert.ToInt32(Math.Pow(numb, 2));
        Console.WriteLine($"Текущая сумма Ваших чисел равна {sum}");
    }
    return cube;
}
try
{
    Console.WriteLine("Задача 4");
    Console.WriteLine("Сумма квадратов Ваших чисел равна " + sumCube());
}
catch
{
    Console.WriteLine("Необходимо вводить целыми числами");  
}