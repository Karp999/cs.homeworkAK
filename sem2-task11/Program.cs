/* 11. Напишите программу, которая выводит случайное трёхзначное 
число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
Console.WriteLine("Введите трехзначное число: ");
int getRandomNumber() 
{
    int result = new Random().Next(100, 999);
    return result;
}
int num = getRandomNumber();
int firstNumber = num/100;
int secondNumber = num%10; 


Console.WriteLine($"{num} - {firstNumber}{secondNumber}");

