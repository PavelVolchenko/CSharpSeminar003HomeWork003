﻿/*  Задача 19: Напишите программу, которая принимает на вход 
    пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да                                              */    
int backOfNumber(int number)
{
    int backOfNumber = number;
    backOfNumber %= 100;
    return backOfNumber;
}

int frontOfNumber(int number)
{
    int frontOfNumber = number;
    frontOfNumber /= 1000;
    return frontOfNumber;
}

int reverseBackOfNumber(int backOfNumber)
{
    int result = backOfNumber % 10;
    result *= 10;
    backOfNumber /= 10;
    result = result + backOfNumber;
    return result;
}

int number = 14252;
int toReverseNumber = backOfNumber(number);
Console.WriteLine("Входное число: " + number);

if(reverseBackOfNumber(toReverseNumber) == frontOfNumber(number)) 
{
    Console.WriteLine("ДА! Это число палиндром!");
}
else Console.WriteLine("НЕТ! Это число не является палиндромом!");
