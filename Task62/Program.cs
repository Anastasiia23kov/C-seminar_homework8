// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Функция вывода массива
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]); // Приписываю "0" для чисел меньше 10.
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер квадратного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];

// Заполнение массива по спирали, начиная с 01
int number = 1;
int i = 0;
int j = 0;

while (number <= size * size)
{
    matrix[i, j] = number;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    number++;
}

Console.WriteLine("Массив, заполненный по спирали, начиная с 01");
InputMatrix(matrix);
