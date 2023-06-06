// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 30);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


void ChangeArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        (array[0, j], array[array.GetLength(0) - 1, j]) = (array[array.GetLength(0) - 1, j], array[0, j]);
    }
}

// 2 3 4 5 
// 2 5 5 6
// 3 3 3 3
// 3 2 2 2


Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);



// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на
// столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 30);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ChangeAr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            // int temp =array[i,j];
            // array[i,j] =array[j,i];

            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);

        }

    }
}





Console.Clear();
Console.WriteLine("Введите количество строк и столбцов");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, rows];
FillArray(array);
PrintArray(array);
ChangeAr(array);
PrintArray(array);

*/


// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] Quant(int [,] array)
{
    int [] arrayOne = new int [10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // if(array[i,j]==0)
            // arrayOne[0]++;
            // if(array[i,j]==1)
            // arrayOne[1]++;
            // if(array[i,j]==2)
            // arrayOne[2]++;
            // if(array[i,j]==3)
            // arrayOne[3]++;

            arrayOne[array[i, j]]++;
        }
    }
return arrayOne;
}


void PrintAr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i]!=0)
            System.Console.Write($"в данном массиве число {i} встречается : {array[i],3} раз    ");
        
    }
    System.Console.WriteLine();
}

// int[] CountPosition(int[,] array)
// {
//     int[] count = new int[10];
  
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         for (int k = 0; k < count.Length; k++)
//         {
//             if (k == array[i, j])
//                 {count[k]++;
//                 k++;}  
//         }
            
//     }
//     return count;

// }
Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
int [] myarray = Quant(array);
PrintAr(myarray);

