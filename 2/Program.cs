// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
char[] array = number.ToArray();
int n = array.Length;

if (n <= 2)
{
Console.WriteLine("Третьей цифры в числе нет");
}
else 
Console.WriteLine(array[2]);