// В двумерном массиве заменить элементы, у которых оба индекса четные, на их квадраты

void FillMatrix (int[,] matrix, int m, int n)
{   
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          matrix[i,j] = new Random().Next(-10, 10);   
}

void PrintMatrix (int [,] matrix)
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
void ChangeMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
           if (i%2==0 && j%2==0)
           {
            matrix[i,j]=matrix[i,j]*matrix[i,j];
           }   
}
Console.WriteLine ("Задайте размер массива mxn");
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [m,n];
FillMatrix(matrix, m, n);
Console.WriteLine("Ваш массив: ");
PrintMatrix(matrix);
ChangeMatrix(matrix);
Console.WriteLine("Новый массив: ");
PrintMatrix(matrix);
