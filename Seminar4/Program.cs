// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к» заменить большими «К», а большие «С» заменить на маленькие «с».

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replase(string text, char oldValue, char newValue)
// {
//     string result= string.Empty;
//     int length = text.Length;

//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replase(text, ' ', '-');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replase(text, 'С', 'с');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replase(text, 'к', 'К');
// Console.WriteLine(newText);



// Упорядочивание данных внутри массива

// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
    
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }

// Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
        
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
        
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);

// SelectionSort(arr);
// PrintArray(arr);



// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for(int i = 1; i <= A; i++)
// {
//     sum = sum + i;
// }

// Console.Write("Сумма = " +sum);



// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// int number1 = number.Length;
// Console.Write("Количество цифр: " +number1);

// int number = Convert.ToInt32(Console.ReadLine());

// int GetDigitsCount(int x)
// {
//     int count = 1;
//     while ((x /= 10) > 0) ++count;
//     return count;
// }

// int result = GetDigitsCount(number);
// Console.Write("Количество цифр: " +result);




// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int result = 1;

// for(int i = 1; i <= N; i++)
// {
//     result = result * i;
// }

// Console.Write("Произведение = " +result);



// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] array = new int[8];

void FillArray(int[] array)
{
    for(int index = 0; index < 8; index ++)
    {
        array[index] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for(int index = 0; index < 8; index ++)
    {
        Console.Write(array[index] +", ");
    }
}

FillArray(array);
PrintArray(array);