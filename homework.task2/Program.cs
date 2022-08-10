/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее. Пример:
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int userNumber1 = new int ();
int userNumber2 = new int ();

Console.WriteLine("Введите число 1: ");
userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1>userNumber2)
{
    Console.WriteLine($"Max: {userNumber1} , Min: {userNumber2}  ");
}
else
{
    Console.WriteLine($"Max: {userNumber2} , Min: {userNumber1}  ");
}


