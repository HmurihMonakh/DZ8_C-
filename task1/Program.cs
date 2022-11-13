// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк: ");
int NumberStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int NumberQuan = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[NumberStr, NumberQuan];

FillArrayRandomNumbers(numbers);
Console.WriteLine();
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int t = 0; t < numbers.GetLength(1) - 1; t++)
        {
            if (numbers[i, t] < numbers[i, t + 1])
            {
                int temp = numbers[i, t];
                numbers[i, t] = numbers[i, t + 1];
                numbers[i, t + 1] = temp;
            }
        }
    }
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine();
PrintArray(numbers);
