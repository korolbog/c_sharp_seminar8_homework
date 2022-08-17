/*
Задача 58.
Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1   2   3   4
12  13  14  5
11  16  15  6
10  9   8   7

*/

int rows = 4;
int columns = 4;
int[] array1D = new int[rows*columns];
int[,] array2D = new int[rows,columns];
Fill1DArray();
Print1DArray();
Sort2DArray();
Print2DArray();

void Sort2DArray()
{
    int k = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array2D[i,j] = array1D[k];
            k++;
        }
    }
    for (int j = 3; j < 4; j++)
    {
        for (int i = 1; i < 4; i++)
        {
            array2D[i,j] = array1D[k];
            k++;
        }
    }
    for (int i = 3; i < 4; i++)
    {
        for (int j = 2; j > -1; j--)
        {
            array2D[i,j] = array1D[k];
            k++;
        }
    }
    for (int j = 0; j < 1; j++)
    {
        for (int i = 2; i > 0; i--)
        {
           array2D[i,j] = array1D[k];
           k++;
        }
    }
    for (int i = 1; i < 2; i++)
    {
        for (int j = 1; j < 3; j++)
        {
           array2D[i,j] = array1D[k];
           k++;
        }
    }
    for (int i = 2; i < 3; i++)
    {
        for (int j = 2; j > 0; j--)
        {
           array2D[i,j] = array1D[k];
           k++;
        }
    }
}
void Fill1DArray()
{
for (int k = 0; k < array1D.Length; k++)
{
    array1D[k] = k + 11;
}
}
void Print1DArray()
{
Console.WriteLine("Исходная последовательность: ");
for (int k = 0; k < array1D.Length; k++)
{
    Console.Write(array1D[k] + " ");
}
Console.WriteLine();
Console.WriteLine();
}
void Print2DArray()
{
    Console.WriteLine("Отсортированный спиралью массив: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array2D[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

