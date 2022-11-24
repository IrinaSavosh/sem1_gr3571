// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число больше 1");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i += 2)
{
   Console.WriteLine(i);
}
Console.WriteLine("Вот и магии конец)))");