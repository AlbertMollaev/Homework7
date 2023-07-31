// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void CheckNumber(int[,] massiv)
{
    int number = GetInput("Введите число для проверки на присуствие в массиве: ");
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {      
            if (number == massiv[i,j]) 
            {
                Console.WriteLine($"{number} -> присутствует в массиве"); 
                return;
            }
        }
    }
    Console.WriteLine($"{number} -> отсутствует в массиве");
}

void Print2DMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Generate2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(startValue, finishValue + 1);
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
int [,] massiv = Generate2DMassive(m, n, 1 , 9);
Print2DMassiv(massiv);
CheckNumber(massiv);