// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Таблица кубов чисел от 1 до {number} представлена ниже");
for (int i = 0; i <= number; i++)
{
    Console.WriteLine($"{Math.Pow(i, 3)}");
}
