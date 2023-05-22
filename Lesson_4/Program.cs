// Задача 24. Напишите программу, которая принимает на вход число (А) и выводит 
// сумму чисел от 1 до А


/*
int Summa(int num)
{
    int res = 0;
    for (int i = 1; i <= num; i++)
        res += i;
    return res;
}

try
{
    System.Console.WriteLine("Ввведите натуральное число:");
    int num = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {Summa(num)}");
}
catch
{
    System.Console.WriteLine("Надо вводить именно целое число!");
}


// Задача 26. Напишите программу, которая принимает на вход число и выдает количество 
// числ в числе

int Result(int x)
{
    int count = 0;

    while (x > 0)
    {
        x = x / 10;
        count++;
    }
    return count;
}

System.Console.WriteLine("Введите любое число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Колличество цифр в числе {num}: {Result(num)}");


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N

int Product(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
        result *= i;
    return result;
}

System.Console.WriteLine("Ввведите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение всех чисел от 1 до {num} равно: {Product(num)}");

*/

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] CreateArray()
{
    Random random = new Random();
    int[] numbers = new int[8];
    System.Console.Write("Массив:");
    for (int x = 0; x < numbers.Length; x++)
        numbers[x] = random.Next(0, 2);
    return numbers;
}

void PrintArray(int [] numbers)
{
    for (int x = 0; x < numbers.Length; x++)
    System.Console.Write($" {numbers[x]}");
    Console.WriteLine();
}

double Result(int [] numbers)
{
    double summ = 0;
    for (int x = 0; x < numbers.Length; x++)
        summ = summ + numbers[x];
    return summ / 8;    
} 


int [] numbers = CreateArray();
PrintArray(numbers);
Console.WriteLine($"Среднне арифмитическое массива: {Result(numbers)}");