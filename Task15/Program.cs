/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int num = int.Parse(Console.ReadLine());
if (num < 8 && num > 0)
    if (num < 8 && num > 5)
        Console.WriteLine($"{num} -> да, выходной!");
    else
        Console.WriteLine($"{num} -> нет");
else
    Console.WriteLine($"{num} -> такого дня недели нет!");