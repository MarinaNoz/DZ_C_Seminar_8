// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int x = new Random().Next(1,5);
int y = new Random().Next(1,5);
int z = new Random().Next(1,5);
Console.WriteLine($"Создан массив {x},{y},{z}");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
void CreateArray(int[,,] array3D)
{
  int[] tempArray = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < tempArray.GetLength(0); i++)
  {
    tempArray[i] = new Random().Next(10, 100);
    number = tempArray[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (tempArray[i] == tempArray[j])
        {
          tempArray[i] = new Random().Next(10, 100);
          j = 0;
          number = tempArray[i];
        }
          number = tempArray[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = tempArray[count];
        count++;
      }
    }
  }
}
