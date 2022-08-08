/*Задача 2: напишите программу, которая будет выдавать название дня недели 
по заданному номеру:
3-> среда
5-> пятница
*/

Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) Console.WriteLine("Monday");
else if (day == 2) Console.WriteLine("Tuesday");
else if (day == 3) Console.WriteLine("Wednesday");
else if (day == 4) Console.WriteLine("Thursday");
else if (day == 5) Console.WriteLine("Friday");
else if (day == 6) Console.WriteLine("Saturday");
else if (day == 7) Console.WriteLine("Sunday");
else if(day <= 0 || day > 7) Console.WriteLine("Нет такого дня недели!");

/* мне дз подумать над выводом через массив int day = {Monday[1]..., Tuesday, Wednesday,
 Thursday, Friday, Saturday, Sunday}*/