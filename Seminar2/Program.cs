// static void MaxNumber()
// {
//     int number = new Random().Next(10, 100);

//     int number1 = number % 10;
//     int number2 = number / 10;

//     int max = number1;

//     if(number2 > number1) max = number2;

//     Console.WriteLine("Number " +number);
//     Console.WriteLine("Max " +max);
// }

// MaxNumber();





// static void NewNumber()
// {
//     int number = new Random().Next(100, 1000);

//     int number1 = number / 100;
//     int number2 = number % 10;

//     Console.WriteLine("Number " +number);
//     Console.WriteLine("NewNumber " +number1 +number2);
// }

// NewNumber();





Console.Write("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int ost = 0;

if(number2 > number1)
{
    if(number2 % number1 == 0)
    {
        Console.Write(number2 +" кратно " +number1);
    }
    
    else
    {
        ost = number2 % number1;
        Console.Write("Остаток " +ost);
    }
}

else
{
    Console.Write(number1 +" больше " +number2);
}