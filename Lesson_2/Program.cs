// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10,100);
// Console.WriteLine($"Было сгенерировано число {num}");
// // Console.WriteLine("Было сгенерировано число "+num);
// int num1 = num/10;
// int num2 = num % 10;
// if (num1>num2) 
//     Console.WriteLine($"Наибольшая цифра это {num1}");
// else if (num1<num2)
//     Console.WriteLine($"Наибольшая цифра это {num2}");
// else
//     Console.WriteLine("Обе цифры этого числа равны");

// for (int i=1; i<=num; i=i+3)
//     Console.Write($"{i} ");


// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100,1000);
// Console.WriteLine($"Было сгенерировано число {num}");
// int num2 = num/100*10 + num % 10;
// Console.WriteLine($"Новое число {num2}");


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// IntNum:
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int div = num2 % num1;
// if (num1 > num2)
// {
//     Console.WriteLine("Второе число должно быть больше первого. Пожалуйста введите числа заново");
//     goto IntNum;
// }
// if (div == 0)
// {
//     Console.WriteLine($"Число {num2} кратно числу {num1}");
// }
// else
// {
//     int num4 = div - num2;
//     Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток {div}");
// }