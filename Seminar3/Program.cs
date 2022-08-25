// Console.Write("Введите номер четверти: ");
// int number = Convert.ToInt32(Console.ReadLine());

// switch (number)
// {
//     case 1: System.Console.WriteLine("X > 0, y > 0"); break;
//     case 2: System.Console.WriteLine("X < 0, y > 0"); break;
//     case 3: System.Console.WriteLine("X < 0, y < 0"); break;
//     case 4: System.Console.WriteLine("X > 0, y < 0"); break;
//     default: System.Console.WriteLine("Такой четверти нет"); break;
// }



// Console.WriteLine("Введите координаты первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Расстояние = {Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2))}");



Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

for(int number2 = 1; number2 <= number1; ++ number2)
{
    Console.Write(Math.Pow(number2, 2) +",");
}