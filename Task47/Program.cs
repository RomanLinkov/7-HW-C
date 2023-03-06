// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Здравствуйте! Спасибо, что проверяете моё дз и особенно большое спасибо за комментарии!");

int n=NumberInput("Введите количество строк двумерного массива: ");
int m=NumberInput("Введите количество столбцов двумерного массива: ");

int min=NumberInput("Введите максимальный элемент массива: ");
int max=NumberInput("Введите минимальный элемент массива: ");

double[,] twoDimDoubleArray = new double[n,m]; // задавание массива целых чисел

FillTwoDimDoubleArray(twoDimDoubleArray, min, max);

PrintTwoDimDoubleArray(twoDimDoubleArray);

void FillTwoDimDoubleArray(double[,] twoDimDoubleArray2, int min, int max)
{
    int rows1=twoDimDoubleArray2.GetLength(0); // число строк
    int columns1=twoDimDoubleArray2.GetLength(1); // число столбцов

    Random rand = new Random();

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            double value = rand.NextDouble()*(max-min)+min;
            twoDimDoubleArray2[i,j]=value;
        }
    }
}

void PrintTwoDimDoubleArray(double[,] twoDimDoubleArray1)
{
    Console.WriteLine("Сгенерированный двумерный массив: ");

    int rows=twoDimDoubleArray1.GetLength(0); // число строк
    int columns=twoDimDoubleArray1.GetLength(1); // число столбцов

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{Math.Round(twoDimDoubleArray1[i,j],1)} ");
        }
        Console.WriteLine();
    }
}

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}