/* Задача 52.Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] array = GetArrayRandom(5, 5);
PrintArray(array);
Console.WriteLine();
ArithmeticMeanOfEachColumn(array);



int[,] GetArrayRandom(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 100);
        }
    }

    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanOfEachColumn(int[,] array)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += sum[i, j];
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(Convert.ToDouble(sum / array.GetLength(0)));
    }
}