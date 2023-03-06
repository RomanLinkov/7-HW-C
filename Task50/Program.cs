// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.Clear();
Console.WriteLine("Здравствуйте! Спасибо, что проверяете моё дз и особенно большое спасибо за комментарии!");

int[,] twoDimIntArray = GenerationTwoDimIntArray();

FillTwoDimIntArray(twoDimIntArray);

PrintTwoDimIntArray(twoDimIntArray);

SearchElement(twoDimIntArray);

void SearchElement(int[,] twoDimIntArray3)
{
    int numRow=NumberInput("Введите номер строки искомого элемента: ");
    int numColumn=NumberInput("Введите номер столбца икомого элемента: ");

    if (numRow > twoDimIntArray3.GetLength(0) | numColumn > twoDimIntArray3.GetLength(1))
    {
        Console.WriteLine($"{numRow}, {numColumn} ->  Такого элемента в массиве нет.");
    }
    else
    {
        Console.WriteLine($"{numRow}, {numColumn} ->  {twoDimIntArray3[numRow,numColumn]}");
    }
}

void FillTwoDimIntArray(int[,] TwoDimIntArray2)
{
    int rows1=TwoDimIntArray2.GetLength(0); // число строк
    int columns1=TwoDimIntArray2.GetLength(1); // число столбцов
    int min=NumberInput("Введите максимальный элемент массива: ");
    int max=NumberInput("Введите минимальный элемент массива: ");

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            TwoDimIntArray2[i,j]=new Random().Next(min,max+1);
        }
    }
}

void PrintTwoDimIntArray(int[,] twoDimIntArray1)
{
    Console.WriteLine("Сгенерированный двумерный массив: ");

    int rows=twoDimIntArray1.GetLength(0); // число строк
    int columns=twoDimIntArray1.GetLength(1); // число столбцов

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{twoDimIntArray1[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GenerationTwoDimIntArray()
{
    int n=NumberInput("Введите количество строк двумерного массива: ");
    int m=NumberInput("Введите количество столбцов двумерного массива: ");
    int[,] twoDimIntArray = new int[n,m];
    return twoDimIntArray;
}

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}