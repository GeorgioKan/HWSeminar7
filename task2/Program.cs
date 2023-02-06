// Задача 50. Напишите программу, которая на вход принимает число, 
// возвращает индексы этого элемента в двумерном массиве или же указание,
//  что такого числа нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


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

void ElementFinder(int element, int[,] mass)
{
    bool isExist = false;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (element == mass[i, j])
                isExist = true;
        }
    }
    switch (isExist)
    {
        case true:
        System.Console.WriteLine($"Число {element} является элементом матрицы.");
        break;
        
        case false:
        System.Console.WriteLine("Такого числа нет в матрице.");
        break;
    }
}

int[,] array2d = MatrixGeneration(4,4);
MatrixDisplay(array2d);
System.Console.WriteLine("Введите число которое нужно найти: ");
int numb = Convert.ToInt32(Console.ReadLine());
ElementFinder(numb,array2d);

