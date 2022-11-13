// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк: ");
int NumberStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int NumberQuan = Convert.ToInt32(Console.ReadLine());

int[,] NumberArr = new int[NumberStr, NumberQuan];
FillArrayRandomNumbers(NumberArr);
PrintArray(NumberArr);
Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(NumberArr)}");

int GetRowNumber(int[,] NumberArr)
{
    int lines = 0;
    int minsum = 0;
    for (int i = 0; i < NumberArr.GetLength(1); i++)
    {
        minsum = minsum + NumberArr[0,i];
    }
    for (int i = 1; i < NumberArr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < NumberArr.GetLength(1); j++)
        {
            sum = sum + NumberArr[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            lines = i;
        }
    }
    return lines;
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







