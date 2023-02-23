// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

System.Console.WriteLine("введите строку первой и второй матрицы");
int line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите столбец первой и второй матрицы");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[line, column];
int[,] array2 = new int[line, column];
int[,] result = new int[line, column];

System.Console.WriteLine("первая матрица");
OutputArray(FillRandomArr(array1));
System.Console.WriteLine();
System.Console.WriteLine("вторая матрица");
OutputArray(FillRandomArr(array2));
System.Console.WriteLine();
System.Console.WriteLine("произведение первой и второй матрицы");
OutputArray(MultiplyArr(array1, array2, result));

int[,] FillRandomArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 9);
        }
    }
    return arr;
}
void OutputArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int[,] MultiplyArr(int[,] arr1, int[,] arr2, int[,] res)
{
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            res[i, j] = sum;
        }
    }
    return res;
}







