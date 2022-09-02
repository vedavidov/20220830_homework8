// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] matrix = new int[2, 2];

FillArray(matrix);
Console.WriteLine("Первая матрица: ");
PrintArray(matrix);
//Console.WriteLine();

int[,] matrix2 = new int[2, 2];

FillArray(matrix2);
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);

int[,] multiMatrix = new int[2, 2];

MultiArray(matrix, matrix2, multiMatrix);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(multiMatrix);

void MultiArray(int[,] matrix, int[,] matrix2, int[,] multiMatrix)
{
    for (int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum += matrix[i, k] * matrix2[k, j];
            }
            multiMatrix[i, j] = sum;
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1, 10)
        }
    }
}