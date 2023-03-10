Console.Clear ();
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

Console.Write("Введите число a: ");
string text1 = Console.ReadLine();
int a = int.Parse(text1);
int ost= (a % 2);
if (ost == 0) 
{
    Console.WriteLine(" Число является четным ");
}
else 
{ 
    Console.WriteLine(" Число НЕ является четным ");
}