// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// void PrintArray(int[] array)
// {
//     Console.Write("Массив: ");

//     for(int i = 0; i < array.Length; i ++)
//     {
//         array[i] = new Random().Next(-9, 9);
//         Console.Write(array[i] +" ");
//     }
// }

// int[] array = new int[12];
// PrintArray(array);

// void SumNumbers()
// {
//     int sumNegativ = 0;
//     int sumPositive = 0;
    
//     for(int i = 0; i < array.Length; i ++)
//     {
//         if(array[i] < 0)
//         {
//             sumNegativ += array[i];
//         }
//         else
//         {
//             sumPositive += array[i];
//         }
//     }
    
//     Console.WriteLine("Сумма отрицательных элементов = " +sumNegativ);
//     Console.WriteLine("Сумма положительных элементов = " +sumPositive);
// }

// Console.WriteLine();
// SumNumbers();



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] numbers = {-4, -8, 8, 2};

// for(int i = 0; i < 4; i ++)
//     {
//         numbers[i] = numbers[i] * (-1);
//         Console.Write(numbers[i] +" ");
//     }



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// void PrintArray(int[] array)
// {
//     Console.Write("Массив: ");

//     for(int i = 0; i < array.Length; i ++)
//     {
//         array[i] = new Random().Next(0, 100);
//         Console.Write(array[i] +" ");
//     }
// }

// int[] array = new int[5];
// PrintArray(array);

// bool IsInArray()
// {
//     Console.Write("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());

//     for(int i = 0; i < 5; i ++)
//     {
//         if(array[i] == number) return true;
//     }
    
//     return false;
// }

// Console.Write(IsInArray());



// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

void PrintArray(int[] array)
{
    Console.Write("Массив: ");

    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(0, 123);
        Console.Write(array[i] +" ");
    }
}

int[] array = new int[123];
PrintArray(array);

void AmountOfNumbers()
{
    int count = 0;

    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        {
            count += 1;
        }
    }

    Console.Write("Количество элементов массива в отрезке [10,99]: " +count);
}

AmountOfNumbers();
