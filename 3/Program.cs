// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным

int num = new Random().Next(1, 8);      // [1 ; 8)

// Console.WriteLine(num);              // Для проверки

if ( num == 6 || num == 7)
{
    Console.WriteLine("Выходной");
}
else 
{
    Console.WriteLine("Будний день");
}