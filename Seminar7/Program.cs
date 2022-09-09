// Задача 46: Задайте двумерный массив размером m×n,заполненный случайными целыми числами.

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// void PrintArray(int[,] array) 
// {
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write(array[i, j] +" ");
//         }
//          Console.WriteLine();
//     }
// }

// int[,] array = new int[rows, columns];
// PrintArray(array);



// Задача 48: Задайте двумерный массив размера m на n,каждый элемент в массиве находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// void PrintArray(int[,] array) 
// {
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array[i, j] = i + j;
//             Console.Write(array[i, j] +" ");
//         }
//          Console.WriteLine();
//     }
// }

// int[,] array = new int[rows, columns];
// PrintArray(array);



// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// void PrintArray(int[,] array) 
// {
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write(array[i, j] +" ");
//         }
//          Console.WriteLine();
//     }
// }

// void NewArray(int[,] array) 
// {
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             if(i != 0 && j != 0 && i % 2 == 0 && j % 2 == 0)
//             {
//                 Console.Write(Math.Pow(array[i, j], 2) +" ");
//             }
            
//             else
//             {
//                 Console.Write(array[i, j] +" ");
//             }
//         }
//          Console.WriteLine();
//     }
// }

// int[,] array = new int[rows, columns];
// PrintArray(array);
// Console.WriteLine();
// NewArray(array);



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] array) 
{
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] +" ");
        }
         Console.WriteLine();
    }
}

int[,] array = new int[rows, columns];
PrintArray(array);

int sumElements = 0;

for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                sumElements = sumElements + array[i, j];
            }
            
        }
    }

Console.Write("Сумма элементов, находящихся на главной диагонали = " +sumElements);