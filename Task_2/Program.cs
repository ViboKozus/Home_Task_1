Console.Clear ();
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

Console.Write("Введите число a: ");
string text1 = Console.ReadLine();
int a = int.Parse(text1);
Console.Write("Введите число b: ");
string text2 = Console.ReadLine();
int b = int.Parse(text2);
 if (a > b)
{
    Console.Write("минимальное число = ");
    Console.WriteLine(b); 
    Console.Write("максимальное число = ");
    Console.WriteLine(a); 
}
else 
{
    Console.Write("минимальное число = ");
    Console.WriteLine(a);
    Console.Write("максимальное число = ");
    Console.WriteLine(b); 
};