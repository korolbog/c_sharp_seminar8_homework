/*
Задача 54: Задайте двумерный массив.
Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/

int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];

FillArray();
Console.WriteLine("Исходный массив:");
PrintArray();

SortArray();
Console.WriteLine("Сортировка построчно от большего к меньшему:");
PrintArray();

void SortArray()
{
for (int i = 0; i < rows; i++)
{
    int length = columns;
    for (int j = 0; j < columns; j++)
    {
        int posMin = (length-1);
// Console.WriteLine($"Последний элемент {array[i, (length-1)]} назначается минимальным значением");
        for (int k = 0; k > -1 && k < length-1; k++)
        {
// Console.WriteLine($"Сравним значение {array[i, k]} c минимальным значением = {array[i, posMin]}");
            if (array[i, k] <= array[i, posMin])
            {
                posMin = k;
// Console.WriteLine($"Минимальным значением назначается {array[i, posMin]}");
            }
//             else
//             {
// Console.WriteLine($"Минимальным значением остается {array[i, posMin]}");
//             }
        }
// Console.WriteLine($"Поменяем местами минимальное значение {array[i, posMin]} и последний элемент {array[i, (length-1)]}");
        int temp = array[i, posMin];
        array[i, posMin] = array[i, (length-1)];
        array[i, (length-1)] = temp;
        length = (length-1);
        // PrintArray();
    }
}
}

void FillArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(-100,101);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


//Отсортировать по убыванию одномерный массив

// int size = 6;
// int[] array = new int[size];
// FillArray();
// PrintArray();
// SortArray();
// PrintArray();


// void SortArray()
// {
//     for (int j = 0; j < array.Length; j++)
//     {
//         int posMin = size-1;
//         for (int i = 0; i < size-1; i++)
//         {
//             if (array[i] <= array[posMin])
//             {
//                 posMin = i;
//             }
//         }
//         int temp = array[posMin];
//         array[posMin] = array[size-1];
//         array[size-1] = temp;
//         size = size-1; 
//     }
// }

// void FillArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100,101);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} \t");
//     }
//     Console.WriteLine();    
// }