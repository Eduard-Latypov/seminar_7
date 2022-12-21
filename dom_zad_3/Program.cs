// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] myArray = FillArray(5, 4);
PrintArray(myArray);
FindSumColumns(myArray);





int[,] FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);

        }
    }
    return arr;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


void FindSumColumns(int[,] myArray)
{
    double result = 0;
    for (int i = 0; i < myArray.GetLength(1); i++)
    {
        for (int j = 0; j < myArray.GetLength(0); j++)
        {
            result += myArray[j, i];
        }
        System.Console.Write(result / myArray.GetLength(0) + "\t");
        result = 0;
    }
}