//Напишите программу , которая будет выдавать название дня недели по заданному
//номеру
//1 - понедельник
//3- среда

Console.WriteLine("Введите число от 1 до 7, чтобы узнать, какой это день недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
   Console.WriteLine("Понедельник");
}
if (number == 2)
{
   Console.WriteLine("Вторник");
}
if (number == 3)
{
   Console.WriteLine("Среда");
}
if (number == 4)
{
   Console.WriteLine("Четверг");
}
if (number == 5)
{
   Console.WriteLine("Пятница");
}
if (number == 6)
{
   Console.WriteLine("Суббота");
}
if (number == 7)
{
   Console.WriteLine("Воскресенье");
}
if (number > 7)
{
   Console.WriteLine("Хватит баловаться, нет такого дня недели! Но для тебя онбудет называтся ЖОПНИК");
}
if (number < 1)
{
   Console.WriteLine("Ой, ну ты программист! Или тестировщик? Нет, нет такого дня недели");
}