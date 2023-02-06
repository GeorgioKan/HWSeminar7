// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] MatrixGeneration(int n, int m)
{
    Random rand = new Random();
    int[,] mass = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mass[i, j] = rand.Next(1, 10);
        }
    }
    return mass;
}

void MatrixDisplay(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write((matrix[i,j]) + "\t");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] matrix)
{
    double numb = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            numb += matrix[i,j];
        }
        numb = numb / matrix.GetLength(0);
        Console.WriteLine(Math.Round(numb,2));
        numb = 0;
    }
}

int[,] array2d = MatrixGeneration(4,3);
MatrixDisplay(array2d);
Console.WriteLine();
ArithmeticMean(array2d);
