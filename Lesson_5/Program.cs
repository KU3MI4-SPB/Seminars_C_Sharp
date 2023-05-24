// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

/*
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int[] FindSums(int[] array)
{
    int sum_p = 0;
    int sum_n = 0;
    foreach (int item in array)
        if (item > 0)
            sum_p += item;
        else
            sum_n += item;
    int[] result = { sum_p, sum_n };
    return result;
}


Console.Clear();
int[] array = new int[12];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(array);
int[] rez = FindSums(array);
//PrintArray(FindSums(array));
System.Console.WriteLine($"Сумма положительных элементов равна {rez[0]}");
System.Console.WriteLine($"Сумма отрицательных элементов равна {rez[1]}");
*/

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

/*
 void FillArray(int[] array)
{
    for (int i =0; i<array.Length;i++)
        array[i] = new Random().Next(-9,10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int [] ChengArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= array[i]*(-1);
    }
    return array;
}

int [] array = new int[4];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(array);
ChengArray(array);
System.Console.WriteLine("Изменили знаки массива");
PrintArray(array);

*/

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


/*
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

void Search(int[] array, int num)
{
    foreach (int item in array)
        if (item == num)
        {
            System.Console.WriteLine("да");
            return;
        }
        else
            System.Console.WriteLine("нет");
}

int [] array = new int[4];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(array);

System.Console.WriteLine("ведите проверяемое число");
int num = Convert.ToInt32(Console.ReadLine());

Search(array,num);

*/

/*

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

bool Search(int[] array, int num)
{
    foreach (int item in array)
        if (item == num)
            return true;
    return false;
}

int [] array = new int[5];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив:");
PrintArray(array);

System.Console.WriteLine("Введите проверяемое число:");
int num = Convert.ToInt32(Console.ReadLine());

if (Search(array,num))
    System.Console.WriteLine($"Число {num} присутствует в массиве");
else
    System.Console.WriteLine($"Число {num} отсутствует в массиве");

*/

// Задача 35: Задайте одномерный массив из 15 случайных чисел в диапазоне от -100 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 15 элементов. В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

/*

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int SearchNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        count++;
    }
    return count;
}

int [] array = new int[15];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Число: {SearchNumbers(array)}");

*/
/*

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int SearchNumbers(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item >= 10 && item <= 99)
            count++;
    }
    return count;
}

int[] array = new int[15];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Чисел от 10 до 99 в массиве: {SearchNumbers(array)}");

*/

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int[] MultiArray(int[] array)
{

     int[] result = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length/2; i++)
    {
        result [i]= array[i]*array[array.Length-1-i];
    }
    if (array.Length%2!= 0)
        result[^1]= array[array.Length/2];
return result;

}


Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);
PrintArray(MultiArray(array));