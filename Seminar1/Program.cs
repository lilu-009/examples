// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if(number1 == (number2 * number2))
// {
//    Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//    Console.WriteLine("Первое число НЕ является квадратом второго");
// }

Console.Write("Укажите номер дня недели: ");
int numberday = Convert.ToInt32(Console.ReadLine());
if(numberday >=1 && numberday <= 7)
{
if (numberday == 1) Console.WriteLine("понедельник");
if (numberday == 2) Console.WriteLine("вторник");
if (numberday == 3) Console.WriteLine("среда");
if (numberday == 4) Console.WriteLine("четверг");
if (numberday == 5) Console.WriteLine("пятница");
if (numberday == 6) Console.WriteLine("суббота");
if (numberday == 7) Console.WriteLine("воскресенье");
}
else
{
  Console.Write("Такого дня недели нет");  
}