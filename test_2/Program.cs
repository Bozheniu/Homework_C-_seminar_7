/* Задача 50.Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет
*/

Console.WriteLine("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[5, 5];
GetArrayRandom(array);
CheckingPositionOfElement(n, m);

void GetArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
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

void CheckingPositionOfElement(int n, int m)
{
    if (n > array.GetLength(0) || m > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в заданном массиве нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента {n} строки и {m} столбца равняется {array[n - 1, m - 1]}");
    }
}

PrintArray(array);


