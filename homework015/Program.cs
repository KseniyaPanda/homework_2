/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number < 6)
{
   Console.WriteLine("Рабочий день");
}
else if (number == 6 || number == 7)
{
   Console.WriteLine("Выходной день");
}
else
{
   Console.WriteLine("Введен не номер дня недели. Необходимо число от 1 до 7");
}
