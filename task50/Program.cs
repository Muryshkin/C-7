// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.Write("Введите позицию строки: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите позицию столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
int[,] FillMatrixWithRandom(int row, int column)
{
int[,] matrix = new int[row=4, column=5];
Random rnd = new Random();
//int[,] numbers = new int[5,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(0, 10);
}
}
return matrix;
}
int newMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
{
    Console.WriteLine(matrix[row, column]);
}
else Console.WriteLine($"{row}{column} -> такого числа в массиве нет");
}
}
return matrix[row, column];
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write(matrix[row,column] + " ");
}
Console.WriteLine();
}
}
PrintMatrix(matrix);
System.Console.WriteLine(newMatrix(matrix));