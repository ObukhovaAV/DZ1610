//Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillMatrix(int[,] matrix, int m, int n)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)      
            matrix [i,j]= i+j;    
}
void PrintMatrix(int[,] matrix)
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
Console.WriteLine("Задайте размер массива mxn");
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [m,n];
FillMatrix (matrix,  m, n);
Console.WriteLine("Ваш массив: ");                    
PrintMatrix (matrix); 
