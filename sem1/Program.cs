/*Задача 0: написать программу, которая на вход принимает число 
и выдаёт его квадрат (число умноженное само на себя)/
Пример: 4*4=16, (-3)*(-3)=9, (-7)*(-7)=49 */

int userNumber = new int ();
/*нужно,чтоб пользователь ввёл данные: */
Console.WriteLine("Введите число: ");
/*дальше меняем конструкцию вместо "userNumber = -7".
Console.ReadLine()-возвращает строку,которую ввёл пользователь после нажатия enter;
Convert.ToInt32(Console.ReadLine()) - преобразует то, что в скобках в числовое значение;
может быть и Convert.ToInt64(Console.ReadLine()) - зависит от размерности, 
но по умолчанию 32*/
userNumber = Convert.ToInt32(Console.ReadLine());

int result = (userNumber*userNumber);
/*дальше меняем конструкцию вместо Console.WriteLine(result), 
пишем КОНКАТЕНАЦИЮ - то, что нижу в скобках(метод склеивания,
добавления,вставки,слияния строк):

- Console.WriteLine("Степень числа "+userNumber+" = "+result); 

//а теперь Console.WriteLine("Степень числа "+userNumber+" = "+result);
в более симпатичную:*/ 
Console.WriteLine($"Степень числа {userNumber} = {result}");

/*Задача 1: напишите программу, которая на вход принимает два
 числа и проверяет, является ли второе число квадратом первого*/

int userNumber1 = new int ();
int userNumber2 = new int ();

Console.WriteLine("Введите число 1: ");
userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 (возможный квадрат 1-го): ");
userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber2 == userNumber1*userNumber1)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}

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


/* Задача 5: напишите программу, которая на вход принимает одно число (N), а на выходе
 показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2" 
*/

Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
for(int i = -userNum; i<=userNum; i++) //здесь i-отрицательное,меньше или равно отрицательное+прибавка по 1
{
    Console.WriteLine(i);
}



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

