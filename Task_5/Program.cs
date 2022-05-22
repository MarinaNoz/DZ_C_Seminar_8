// Заполните спирально массив 4 на 4.

int n = 4;
int[,] quadArray = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= quadArray.GetLength(0) * quadArray.GetLength(1))
{
  quadArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < quadArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= quadArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > quadArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(quadArray);
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
