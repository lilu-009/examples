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



// Console.Write("Укажите номер дня недели: ");
// int numberday = Convert.ToInt32(Console.ReadLine());
// if(numberday >=1 && numberday <= 7)
// {
// if (numberday == 1) Console.WriteLine("понедельник");
// else if (numberday == 2) Console.WriteLine("вторник");
// else if (numberday == 3) Console.WriteLine("среда");
// else if (numberday == 4) Console.WriteLine("четверг");
// else if (numberday == 5) Console.WriteLine("пятница");
// else if (numberday == 6) Console.WriteLine("суббота");
// else if (numberday == 7) Console.WriteLine("воскресенье");
// }
// else
// {
//  Console.Write("Такого дня недели нет");  
// }



// Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = -number1;
// while(number2 <= number1)
// {
//    Console.Write(number2 +",");
//    number2 ++;
// }



Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
    int lastnumber = number % 10;
    Console.WriteLine("Последняя цифра числа: " +lastnumber);
}
else
{
    Console.WriteLine("Это число не трехзначное");
}