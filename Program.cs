/*
void FillArray(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,20);
        }
    }
}
void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"  {matr[i,j]}  ");
        }
    Console.WriteLine();
    }
}
 int[,] matrix = new int[5,6];
 FillArray(matrix);
 PrintArray(matrix);*/

 //---------------------------------------------------------------------------------------------
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input number rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number minValue = ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number maxValue = ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];
    for(int i = 0; i<rows; i++)
    
        for(int j = 0; j<columns; i++)
            array[i,j] = new Random().Next(minValue, maxValue);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {   
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);*/
//-----------------------------------------------------------------------------------------------------
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            matrix[i,j] = i+j;
            
        }
    }
    return matrix;
}
void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"  {matr[i,j]}  ");
        }
    Console.WriteLine();
    }
}
Console.WriteLine("Input rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillArray(rows, columns);
 
PrintArray(matrix);*/


//-------------------------------------------------------------------------------------------------
//Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            matrix[i,j] = new Random().Next(1,20);
            
        }
    }
    return matrix;
}
void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}  ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void MakeKvadratEvenNumbers(int[,] array)
{
    for (int i = 0; i< array.GetLength(0); i+=2)
        for(int j = 0; j< array.GetLength(1); j+=2)
            array[i,j] *= array[i,j];
}

    Console.WriteLine("Input number rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(rows, columns);
    PrintArray(array);
    MakeKvadratEvenNumbers(array);
    PrintArray(array);*/
    
//----------------------------------------------------------------------------------
//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            matrix[i,j] = new Random().Next(1,20);
            
        }
    }
    return matrix;
}
void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}  ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}
int SumElementMainDiagonal(int[,] array)
{
    int sum = 0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        {
            sum += array[i,i];
        }
    }
 return sum;
}
 
    Console.WriteLine("Input number rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(rows, columns);
    PrintArray(array);
    int sum = SumElementMainDiagonal(array);
    Console.WriteLine($"Сумма элементов главной диагонали = {sum} ");