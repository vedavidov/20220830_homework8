// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = new int[2, 2];

FillArray(matrix);
Console.WriteLine("Прямоугольный двумерный массив: ");
PrintArray(matrix);
Console.WriteLine();
int minSum = Int32.MaxValue;
int row = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        row++;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {row} (сумма элементов = {minSum})");

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