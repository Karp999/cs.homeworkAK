/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
 находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
Console.WriteLine("Введите X1: ");
int userX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X2: ");
int userX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
int userY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
int userY2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((userX2-userX1)*(userX2-userX1)+(userY2-userY1)*(userY2-userY1));
distance = Math.Round(distance, 2);
Console.WriteLine($"Расстояние равно: {distance}");




