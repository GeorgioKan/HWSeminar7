// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] MatrixGeneration(int n, int m)
{
    Random rand = new Random();
    double[,] mass = new double[n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mass[i,j] = rand.NextDouble() * 10;
        }
    }
    return mass;
}

void MatrixDisplay(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write((Math.Round(matrix[i,j],1)) + "\t");
        }
        Console.WriteLine();
    }
}

System.Console.WriteLine("Введите число строк:");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
double[,] array2d = MatrixGeneration(n,m);
MatrixDisplay(array2d);
