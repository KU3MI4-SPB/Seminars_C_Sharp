// // Напишите программу, которая на вход принимает число и выдает его квадрат
// //  (число умноженное  на само себя).

// // Например:
// // 4 -> 16 
// // -3 -> 9 
// // -7 -> 49

// Console.WriteLine("введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine(result);

// if (num>0)
// {
//     Console.WriteLine("было введено положительное число");
// }
// else if (num==0)
// Console.WriteLine("был введен ноль");
// else
// Console.WriteLine("ведено отрицательное число");




// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("введите первое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num == num2 * num2)
// {
//     Console.WriteLine("первое число - квадрат второго");
// }
// else
// {
//     Console.WriteLine("первое число - не квадрат");
// }





// Console.WriteLine("введите номер дня недели (1-7)");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 1)
// {
//     Console.WriteLine("понедельник");

// }
// else if (num == 2)
// {
//     Console.WriteLine("вторник");

// }
// else if (num == 3)
// {
//     Console.WriteLine("среда");

// }
// else if (num == 4)
// {
//     Console.WriteLine("четверг");

// }
// else if (num == 5)
// {
//     Console.WriteLine("пятница");

// }
// else if (num == 6)
// {
//     Console.WriteLine("суббота");

// }
// else if (num == 7)
// {
//     Console.WriteLine("воскресенье");

// }
// else 
// {
//     Console.WriteLine("ошибка");
// }





// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8







// Console.WriteLine("введите положительное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = - num;
// while (num1 <= num)
// {
//     Console.Write(num1 + " ");
//     num1 = num1 + 1;
// }

// Console.WriteLine("введите трехзначное положительное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 & num < 1000)
// {
//     Console.WriteLine(num % 10);
// }





// теперь на входе целое число любой разрядности, надо вывести третью справа цифру




// Console.WriteLine("введите трехзначное положительное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99)
// {
//     Console.WriteLine(num % 1000 / 100);
// // }
// Console.WriteLine("введите трехзначное положительное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99)
// {
//     while (num >= 1000)
//     {
//         num = num / 10;
//     }
// }
// Console.WriteLine(num % 10);

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99) {
    while (num > 999) {
        num = num / 10;
    }
}
Console.WriteLine(num % 10);
