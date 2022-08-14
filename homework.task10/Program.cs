/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа. Пример:
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int secondANDthirdNumber = userNumber%100; 
int thirdNumber = userNumber%10;
int secondNumber = ((userNumber%100-userNumber%10)/10);

Console.WriteLine(secondNumber);

