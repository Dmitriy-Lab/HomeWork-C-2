//  Напишите программу, которая принимает 
//  на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Длинное решение:
// int num2 = number % 100;
// int num3 = number % 10;

// int answer = (num2 - num3) / 10;

// Console.WriteLine(answer);


// Короткое решение:
 int num2 = (number % 100) / 10;
Console.WriteLine(num2);