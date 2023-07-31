// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void Print2DMassiv(double[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]:F2}\t");
        }
        Console.WriteLine();
    }
}

double[,] Generate2DMassive(int rows, int columns, int startValue, int finishValue)
{
    double[,] matrix = new double[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().NextDouble()* (startValue - (finishValue + 1)) + finishValue ;
        }
    }
    return matrix;
}


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите колличество строк массива: ");
int n = GetInput("Введите колличество столбцов массива: ");
double [,] massiv = Generate2DMassive(m, n, -1 , 9);
Print2DMassiv(massiv);