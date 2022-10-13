// Задача 47. Задайте двумерный массив размером 
// m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

 
void ArreyRondomNum (double [,] arrey )
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine() ?? "");

double [,] arrey  = new double [n, m];

ArreyRondomNum(arrey);
PrintArray(arrey);
