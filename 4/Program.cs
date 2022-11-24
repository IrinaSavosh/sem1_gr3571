// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число a:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c:");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
{
Console.Write("max = ");
   Console.WriteLine(numberA);
}
if (numberB > numberA && numberB > numberC)
{
   Console.Write("max = ");
   Console.WriteLine(numberB);
}
if (numberC > numberA && numberC > numberB)
{
   Console.Write("max = ");
   Console.WriteLine(numberC);
}
Console.WriteLine("Из этой задачи я вынесла то, что очень важен синтаксис и внимательность.");
Console.WriteLine("Я пересмотрела несколько форумов, переделывала алгоритм... ");
Console.WriteLine("А нужно было всего лишь поставить латинскую С вместо кирилицы и пару запятых");