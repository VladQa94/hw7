﻿/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

int[,] generate2DArray(int countRow, int countCol, int deviation)
{
    int[,] array = new int[countRow,countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            array[i,j] = new Random().Next(-deviation,deviation +1);
        }
    }
    return array;
}

void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс числа: ");
int index = Convert.ToInt32(Console.ReadLine());
int[,] arrayOfElements = generate2DArray(m,n,10);
print2dArray(arrayOfElements);

int countOfElementsInArray = m * n - 1;
if (index <= countOfElementsInArray)
{
   int i = index / n;
   int j = index % n;
   int value = arrayOfElements[i, j];
   Console.WriteLine($"Под индексом {index} число {value}");
}
else
{
    Console.WriteLine("Число с таким индексом отсутствует");
}