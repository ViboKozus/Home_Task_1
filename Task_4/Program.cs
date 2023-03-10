Console.Clear ();
Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

Console.Write("Введите число a: ");
string text1 = Console.ReadLine();
int a = int.Parse(text1);
Console.Write("Введите число b: ");
string text2 = Console.ReadLine();
int b = int.Parse(text2);
Console.Write("Введите число c: ");
string text3 = Console.ReadLine();
int c = int.Parse(text3);
int max = a;
 if (a > max) max = a;
 if (b > max) max = b;
 if (c > max) max = c;
{
    Console.Write("максимальное число = ");
    Console.WriteLine(max); 
};