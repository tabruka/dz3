// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
int firstDigit = -1;
int secondDigit = -1;
int fourthDigit = -1;
int lastDigit = -1;

if(GetFirstDigit(number) == GetLastDigit(number) && GetSecondDigit(number) == GetFourthDigit(number))
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}

int GetFirstDigit(int number)
{
    int firstDigit = number/10000;
    return firstDigit;
}
int GetSecondDigit(int number)
{
    int secondDigit = number/1000%10;
    return secondDigit;
}
int GetFourthDigit(int number)
{
    int fourthDigit = number/10%10;
    return fourthDigit;
}
int GetLastDigit(int number)
{
    int lastDigit = number%10;
    return lastDigit;
}