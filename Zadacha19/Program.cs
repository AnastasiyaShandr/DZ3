// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10000 && number < 100000)
{
    int x1 = number % 10;
    int x2 = (number - x1) % 100 / 10;
    int x3 = (number - x2 * 10 - x1) % 1000 / 100;
    int x4 = (number - x3 * 100 - x2 * 10 - x1) % 10000 / 1000;
    int x5 = (number - x4 * 1000 - x3 * 100 - x2 * 10 - x1) % 100000 / 10000;
    if (x1 == x5 | x2 == x4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введенное число не является пятизначным. Введите другое число");
}


