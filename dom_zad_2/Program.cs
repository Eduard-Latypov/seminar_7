// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();
const int M = 5;
const int N = 5;
FindItem(FillArray(M, N));



int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}


int[,] FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
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

void FindItem(int[,] arr)
{
    try
    {
        int rows = inputNumber("Введите значение для строки массива: ");
        int columns = inputNumber("Введите значение для столбца массива: ");
        PrintArray(arr);
        System.Console.WriteLine($"Элемент по введенным значениям:  {arr[rows, columns]}");
    }
    catch
    {
        System.Console.WriteLine("Отсутствуют данные по введенным значениям!");
    }
}