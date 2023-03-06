// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Здравствуйте! Спасибо, что проверяете моё дз и особенно большое спасибо за комментарии!");

int[,] twoDimIntArray = GenerationTwoDimIntArray();

FillTwoDimIntArray(twoDimIntArray);

PrintRowAverage(twoDimIntArray);

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

void PrintRowAverage(int[,] twoDimIntArray1)
{
    int rows=twoDimIntArray1.GetLength(0); // число строк
    int columns=twoDimIntArray1.GetLength(1); // число столбцов

    for (int i = 0; i < rows; i++)
    {
        double rowAverage=0;
        for (int j = 0; j < columns; j++)
        {
            rowAverage=rowAverage+twoDimIntArray1[i,j];
            Console.Write($"{twoDimIntArray1[i,j]} ");
        }
        double result = rowAverage/columns;
        Console.WriteLine($" -> Среднее арифметическое {Math.Round(result,2)}");
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