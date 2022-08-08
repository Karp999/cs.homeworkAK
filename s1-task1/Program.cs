/*Задача 1: напишите программу, которая на вход принимает два
 числа и проверяет, является ли второе число квадратом первого*/

int userNumber1 = new int ();
int userNumber2 = new int ();

Console.WriteLine("Введите число 1: ");
userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 (возможный квадрат 1-го): ");
userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber2 == userNumber1*userNumber1)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}
