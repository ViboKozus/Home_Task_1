Console.Clear ();
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

int N;
int A = 2;
Console.WriteLine("Введите число N: ");
int.TryParse(Console.ReadLine ()!, out N);

while (A <= N)
{
    Console.Write($"{A}, ");
    A = A + 2;
}
