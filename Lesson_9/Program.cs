// посчитать сумму целых чисел от 1 до N, где N вводится пользователем

// int Summa(int num)
// {
//     int res = 0;
//     while (true)
//         {
//             res+=num;
//             num--;
//             if (num==0)
//                 break;
//         }
//     return res;
// }

// int SummaRec(int num)
// {
//     if (num==0) return 0;  // тумблер выключения
//     return num + SummaRec(num-1);   // и суммирование и уменьшение счетчика на 1
// }

// //SummaRec (5)
// //5 + ( 4 + ( 3 + (2 + (1 + 0))))



// Console.Clear();
// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Искомая сумма равна {Summa(num)}");
// System.Console.WriteLine($"Искомая сумма рекурсией равна {SummaRec(num)}");

// string PrintNum(int num1, int num2)
// {
//     if (num2 == num1) return $"{num1}";  // тумблер выключения
//     return PrintNum(num1, num2 - 1) + "," + num2;
// }

// Console.Clear();
// System.Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Натуральные числа в промежутке от {num1} до {num2}: ");
// System.Console.WriteLine(PrintNum(num1, num2));


// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// string PrintNum(int num)
// {
//     if (num == 1) return "1";  // тумблер выключения
//                               //return num + PrintNum(num-1);   // и суммирование и уменьшение счетчика на 1

//     return PrintNum(num - 1) + "," + num;
// }

// Console.Clear();
// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Натуральные числа в промежутке от 1 до {num}: ");
// System.Console.WriteLine(PrintNum(num));

// string PrintNum(int num1, int num2)
// {
//     if (num2 == num1) return $"{num1}";  // тумблер выключения
//     return PrintNum(num1, num2 - 1) + "," + $"{num2, 3}";
// }

// Console.Clear();
// System.Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Натуральные числа в промежутке от {num1} до {num2}: ");
// System.Console.WriteLine(PrintNum(num1, num2));


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SummNum(int num)
// {
//     if (num == 0) return 0;  // тумблер выключения
//     return num%10 + SummNum(num/10);
// }

// Console.Clear();
// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма цифр числа {num}: {SummNum(num)}");

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int DegreeNum(int num1, int num2)
// {
//     if (num2 == 0) return 1;  // тумблер выключения
//     return num1 * DegreeNum(num1, num2 - 1);
// }

// Console.Clear();
// System.Console.WriteLine("Введите целое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите показатель степени числа");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Число {num1} в степени {num2} = {DegreeNum(num1, num2)}");

// Создать последовательность Фибоначчи рекурсией. 
 
int Fibonacchi(int n) 
{ 
    if (n==2) return 1; 
    if (n==1) return 0; 
    return Fibonacchi(n-1) + Fibonacchi(n-2); 
} 
 
void PrintFibonacchi(int num) 
{ 
    for (int i = 1 ; i<num; i++) 
        Console.Write($"{Fibonacchi(i)}, "); 
    Console.WriteLine(Fibonacchi(num)); 
} 
 
 
 
Console.Write("Введите целое число n: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
PrintFibonacchi(n);