﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день небели,цифры от 1 до 7");
int week = Convert.ToInt32(Console.ReadLine());
if(week == 6 || week == 7)
{
    Console.WriteLine($"День недели под номером {week} является выходным.");
}
else
{
    Console.WriteLine($"День недели под номером {week} не является выходным.");
}