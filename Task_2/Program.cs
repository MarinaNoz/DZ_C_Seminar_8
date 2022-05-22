// Задайте прямоугольный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

Console.Write("Введите количество строк m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);
Console.WriteLine("Индекс строки с наименьшей суммой элементов " + RowSumNumber(array));

int RowSumNumber(int[,]array)
{
    int sum = 0;
    int minSum = 0;
    int minNumber = 0;
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += array[i, j];
                minSum += array[i,j];
            }
            else sum +=array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNumber = i;
        }
        sum = 0;
    }
    return minNumber;     
} 
void FillArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)  
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10); 
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}