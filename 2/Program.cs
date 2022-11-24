// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9
Console.WriteLine("Введите число a:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA != numberB)
{
   if (numberA > numberB)

   {
      Console.Write("min = ");
      Console.WriteLine(numberB);
      Console.Write("max = ");
      Console.WriteLine(numberA);
   }
   else
   {
      Console.Write("min = ");
      Console.WriteLine(numberA);
      Console.Write("max = ");
      Console.WriteLine(numberB);
   }

}
else
{
   Console.WriteLine("Число A не должно равняться числу B");
}