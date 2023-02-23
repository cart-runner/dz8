// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
System.Console.WriteLine("введите строку");
int line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите столбец");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[line,column];

FillArray(array);
OutputArray(array);
System.Console.WriteLine();
OutputArray(SortArray(array));

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,9);
        }
    }
    return array;
}
void OutputArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
    
}
int[,] SortArray(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i,k] < arr[i,k + 1])
                {
                    int result = arr[i,k + 1];
                    arr[i,k + 1] = arr[i,k];
                    arr[i,k] = result;
                }
            }
        }
    }
    return arr;
    
}