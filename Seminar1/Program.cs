// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine($"{twoDimIntArray[0,0] }");
// string[,] table=new string[m,n]; Задавание массива строк

Console.Clear();
Console.WriteLine("Здравствуйте! Спасибо, что проверяете моё дз и особенно большое спасибо за комментарии!");

int n=NumberInput("Введите количество строк двумерного массива: ");
int m=NumberInput("Введите количество столбцов двумерного массива: ");

int min=NumberInput("Введите максимальный элемент массива: ");
int max=NumberInput("Введите минимальный элемент массива: ");

int[,] twoDimIntArray = new int[n,m]; // задавание массива целых чисел

FillTwoDimIntArray(twoDimIntArray, min, max);

PrintTwoDimIntArray(twoDimIntArray);

void FillTwoDimIntArray(int[,] TwoDimIntArray2, int min, int max)
{
    int rows1=TwoDimIntArray2.GetLength(0); // число строк
    int columns1=TwoDimIntArray2.GetLength(1); // число столбцов

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

int NumberInput(string msg)