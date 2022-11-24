// Напишите программ, которая принмает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
// 456->6
// 458->8
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
   Console.WriteLine(number % 10);
}
else
{
  Console.WriteLine("Введено не трехзначное число");
}
