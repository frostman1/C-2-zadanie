// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();


if (numberS.Length > 2)
{
    Console.WriteLine($"{number} -> {numberS[2]}");
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}