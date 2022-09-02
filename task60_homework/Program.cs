// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int lengthX = 2;
int lengthY = 2;
int lengthZ = 2;
int minNum = 0;
int maxNum = 99;
int[,,] resultArray = new int[lengthX, lengthY, lengthZ];

Console.WriteLine();
FillArray(resultArray, minNum, maxNum);
PrintArray(resultArray);

void FillArray(int[,,] array, int minNum = 0, int maxNum = 99)
{
    Random randomNum = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int number = randomNum.Next(minNum, maxNum + 1);

                    if (MultiArray(array, number) == false)
                    {
                        array[i, j, k] = number;
                    }
                }

            }
        }
    }
}

bool MultiArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write("({0},{1},{2})  ", i, j, k);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}