﻿//Напишите программу, которая 1. на вход принимает два
//числа и 2. проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int square = number2 * number2;

if (square == number1)
Console.WriteLine ("да");
else Console.WriteLine ("нет");
    
