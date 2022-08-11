/*Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
void getCoordinatefromQuoter (int quoter)
{
    if (quoter == 1)
    {
        Console.WriteLine($"x>0 и y>0");
    }
    else if (quoter == 2)
    {
        Console.WriteLine($"x<0 и y>0");
    }
     else if (quoter == 3)
    {
        Console.WriteLine($"x<0 и y<0");
    }
     else if (quoter == 4)
    {
        Console.WriteLine($"x>0 и y<0");
    }
    else 
    {
         Console.WriteLine($"ОШИБКА: количество четвертей всего четыре!!!");
    }
}
Console.WriteLine("Введите четверть:");
int userQuoter = Convert.ToInt32(Console.ReadLine());

getCoordinatefromQuoter (userQuoter);
