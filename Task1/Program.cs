//Показать двумерный массив размером m×n заполненный вещественными числами

void FillMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = new Random().NextDouble()*100;
}


void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
          {
           Console.Write($"{matrix[i,j]} ");   
          }
         Console.WriteLine();
    }
}
double [,] matrix = new double [3,4];
FillMatrix (matrix);
PrintMatrix (matrix);
