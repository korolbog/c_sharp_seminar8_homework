/*
Задача 56:
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int rows = 4;
int columns = 3;
int[,] array = new int[rows, columns];

FillArray();
Console.WriteLine("Исходный массив: ");
PrintArray();
AccuArray();

void AccuArray()
{
    int[] accu = new int[rows];
    int posMin = 0;

    Console.WriteLine($"Построчные суммы: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            accu[i] += array[i,j];
        }
    Console.Write(accu[i] + "\t");
    }
    Console.WriteLine();

    for (int i = 0; i < accu.Length; i++)
    {
        if (accu[i] <= accu[posMin])
        {
            posMin = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма: ");
    Console.WriteLine(accu[posMin]);
}

void FillArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(-10,11);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
