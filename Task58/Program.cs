// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Задание изменено на: элементы третьей матрицы - это попарное произведение элементов 
// из первой и второй матрицы, расположенных на одинаковых позициях

// Функция заполнения 2мерного массива случайными числами для матрицы 1.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// Функция заполнения 2мерного массива случайными числами для матрицы 2.
void InputMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix2[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
int[,] matrix2 = new int[coord[0], coord[1]];
int[,] matrix3 = new int[coord[0], coord[1]];

Console.WriteLine("Массив 1");
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Массив 2");
InputMatrix2(matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица (массив 3)");

// Нахождение элементов 2мерного массива для матрицы 3.
for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        matrix3[i, j] = matrix[i, j] * matrix2[i, j]; // [1, 10]
        Console.Write($"{matrix3[i, j]} \t");
    }
    Console.WriteLine();
}