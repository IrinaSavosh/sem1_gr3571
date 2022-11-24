//Напишите программу, 
// которая на вход принимает двачисла и проверяет, является ли
//первоечислоквадратом вторго

//а = 25, b = 5  - да
// а = 2, b = 10  - нет
// а = 9, b = 3  - да
//а = 8, b = 6  - нет


Console.WriteLine("Введите число a:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB*numberB)
{
   Console.WriteLine("Да!");
}
else
{
   Console.WriteLine("Нет!");
}