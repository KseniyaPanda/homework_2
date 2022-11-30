/*
Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
   Console.WriteLine($"в числе {number} нет третьей цифры");
   return;
}
else if (number > 999)
{
   while (number > 999)
   {
      number = number / 10;
   }
}
int result = number % 10;
Console.WriteLine($"третье число {result}");
