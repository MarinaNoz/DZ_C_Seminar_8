// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 

Console.Write("Введите количество строк первой матрицы m1 ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы n1 ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы m2 ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы n2 ");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] arrayOne = new int[m1, n1];
int[,] arrayTwo = new int[m2, n2]; 

FillArray(arrayOne);
PrintArray(arrayOne);
Console.WriteLine();
FillArray(arrayTwo);
PrintArray(arrayTwo);

int[,] result = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

for (int i = 0; i < arrayOne.GetLength(0); i++)
{
    for (int j = 0; j < arrayTwo.GetLength(1); j++)
    {
        for (int k = 0; k < arrayTwo.GetLength(0); k++)
        {
            result[i, j] += arrayOne[i, k] * arrayTwo[k, j];
        }
    }

}
Console.WriteLine( "Результат произведения двух матриц: ");
PrintArray(result);

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
