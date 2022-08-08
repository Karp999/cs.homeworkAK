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