﻿/* 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно 
*/
Console.WriteLine("Число 1: ");
int getRandomNumber() 
{
    int result = new Random().Next(1, 999);
    return result;
}
int num1 = getRandomNumber();
int num2 = getRandomNumber();

if (num1 % num2 == 0);
{
    Console.WriteLine("кратно");
}
else
{   
    Console.WriteLine($"не кратно{num1 % num2}");
}
