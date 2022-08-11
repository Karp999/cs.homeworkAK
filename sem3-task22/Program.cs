/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("1");
for(int i = 2; i<=userNumber; i++) 
{
    int square = i*i;
    Console.Write($",{square}");
}


/* if i=userNumber;
    {
        Console.Write($"{square}");
    } */