// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void NewArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == 0)
//             {
//                 int temp = array[array.GetLength(0) - 1, j];
//                 array[array.GetLength(0) - 1, j] = array[i, j];
//                 array[i, j] = temp;
//                 Console.Write(array[i, j] + " ");
//             }

//             else
//             {
//                 array[i, j] = array[i, j];
//                 Console.Write(array[i, j] + " ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = new int[3, 3];
// PrintArray(array);
// Console.WriteLine();
// NewArray(array);



// Задача 55: Задайте двумерный массив. Напишите программу,которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void NewArray(int[,] array)
// {
//     int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

//     if (array.GetLength(0) == array.GetLength(1))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 newArray[i, j] = array[j, i];
//                 Console.Write(newArray[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
        
//     }

//     else
//     {
//         Console.Write("Строки на столбцы заменить нельзя");
//     }
// }

// int[,] array = new int[3, 4];
// PrintArray(array);
// Console.WriteLine();
// NewArray(array);



// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[3, 4];
PrintArray(array);

int min = array[0, 0];
int imin = 0;
int jmin = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(array[i, j] < min) 
        {
            min = array[i, j];
            imin = i;
            jmin = j;
        }    
    }
}

void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i != imin && j != jmin)
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
NewArray(array);