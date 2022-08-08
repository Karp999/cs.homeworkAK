/* Задача 7: напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа. Пример:
456 -> 6
782 -> 2
918 -> 8
*/
Console.WriteLine("Введите трехзначное число: ");
int userNumb1 = Convert.ToInt32(Console.ReadLine());
int userNumb2 = userNumb1%10;
Console.WriteLine(userNumb2);
