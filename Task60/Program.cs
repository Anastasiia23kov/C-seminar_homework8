// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двухзначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента. Массив размером 2x2x2.
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Функция заполнения и вывода трёхмерного массива из неповторяющихся двузначных чисел.
void InputMatrix(int[,,] matrix)
{
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            matrix[i, j, k] = matrix[i, j, k] + count;
            count = count + 7;
            Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
int[,,] matrix = new int[2, 2, 2];
Console.WriteLine("Трёхмерный массив размером 2x2x2 с индексами каждого элемента: ");
InputMatrix(matrix);