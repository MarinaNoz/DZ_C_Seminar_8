// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
DecreaseRow(array);
PrintArray(array);

void FillArray(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10); 
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}
void DecreaseRow(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            for (int k = 0; k < matrix.GetLength(1) - n - 1; k++)
            {
                if (matrix[m, k] < matrix[m, k + 1])
                {
                    int temp = matrix[m, k];
                    matrix[m, k] = matrix[m, k + 1];
                    matrix[m, k + 1] = temp;
                }
            }
        }
    }
}