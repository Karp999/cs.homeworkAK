/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Пример:
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 99)
{
    while (userNumber > 999)
    {
        userNumber = userNumber / 10;
    }
   Console.WriteLine(userNumber % 10);
}
else
{
    Console.WriteLine("В заданном числе нет третьей цифры.");
}
