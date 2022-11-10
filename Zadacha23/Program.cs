// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

int n = 1;

while (n <= N)
{
    int cubeN = Convert.ToInt32(Math.Pow(n, 3));
    Console.WriteLine(cubeN + " ");
    n++;
}
