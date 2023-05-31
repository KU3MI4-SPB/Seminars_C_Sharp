// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

/*
void FillArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-30,30);
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            System.Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);

*/

/*
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные,  
// и замените эти элементы на их квадраты. 
// Например, изначально массив 
//  выглядел вот так: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
 
void FillArray(int [,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i,j] = new Random().Next(-30,30); 
        } 
    } 
 
} 
 
void ChangeArray (int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            if(i %2 != 0 && j %2 != 0) 
            array[i,j] = array[i,j] * array[i,j]; 
        } 
    } 
} 
 
 void PrintArray(int[,] array) 
{ 
    for (int i=0; i<array.GetLength(0);i++) 
        { 
        for (int j=0; j<array.GetLength(1);j++) 
            System.Console.Write($"{array[i,j],3}    "); 
        System.Console.WriteLine(); 
        } 
} 
 
Console.Clear(); 
Console.WriteLine("Введите количество строк"); 
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов"); 
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] array = new int [rows, cols]; 
FillArray(array); 
PrintArray(array); 
System.Console.WriteLine(); 
ChangeArray(array); 
PrintArray(array);
*/


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и и отдельно сумму элементов обратной диагонали 
// Например, задан массив: 
// 1 4 7  
// 5 9 2  
// 8 4 2  
// Сумма элементов главной диагонали: 1+9+2 = 12 
// сумма элементов обратной диагонали 8 + 9 + 7 = 24 
 
 
void FillArray(int[,] array) 
{ 
    for (int i=0; i<array.GetLength(0);i++) 
        for (int j=0; j<array.GetLength(1);j++) 
            array[i,j] = new Random().Next(-30,30); 
} 
 
void PrintArray(int[,] array) 
{ 
    for (int i=0; i<array.GetLength(0);i++) 
        { 
        for (int j=0; j<array.GetLength(1);j++) 
            System.Console.Write($"{array[i,j],3}    "); 
        System.Console.WriteLine(); 
        } 
} 
 
 
int SummDiagonalMain(int [,] array) 
{ 
    int result = 0; 
    for (int i=0; i<array.GetLength(0);i++) 
        for (int j=0; j<array.GetLength(1);j++) 
        {     
            if (i==j) 
                result+=array[i,j]; 
        } 
    return result; 
} 
 
int SummDiagonalReverse(int [,] array) 
{ 
    int result = 0; 
    for (int i=0; i<array.GetLength(0);i++) 
        for (int j=0; j<array.GetLength(1);j++) 
        {     
            if (j+i==array.GetLength(0)-1) 
                result+=array[i,j]; 
        } 
    return result; 
} 
 
Console.Clear(); 
Console.WriteLine("Введите количество строк"); 
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов"); 
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] array = new int [rows, cols]; 
FillArray(array); 
PrintArray(array); 
Console.WriteLine(); 
Console.WriteLine(SummDiagonalMain(array)); 
Console.WriteLine(SummDiagonalReverse(array));


