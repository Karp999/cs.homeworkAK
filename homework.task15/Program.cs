/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. 
Пример:
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) 
{
    Console.WriteLine("Понедельник - рабочий день.");
}
else if (day == 2) 
{
    Console.WriteLine("Вторник - рабочий день.");
}
else if (day == 3) 
{
    Console.WriteLine("Среда - рабочий день.");
}
else if (day == 4) 
{
    Console.WriteLine("Четверг - рабочий день.");
}
else if (day == 5) 
{
    Console.WriteLine("Пятница - рабочий день.");
}
else if (day == 6) 
{
    Console.WriteLine("Суббота - выходной.");
}
else if (day == 7) 
{
    Console.WriteLine("Воскресенье - выходной.");
}
else if(day <= 0 || day > 7) 
{
    Console.WriteLine("Нет такого дня недели!");
}
