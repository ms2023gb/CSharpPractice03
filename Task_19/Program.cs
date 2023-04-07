/*

Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNumber(int number)
{
    if (number > 10000 && number <= 99999)
    {
        return true;
    }
    Console.WriteLine("Это число не пятизначное");
    return false;
}

// Console.WriteLine("Введите пятизначное число для проверки на полиндром");
int num = Prompt("Введите пятизначное число для проверки на полиндром: ");

if (ValidateNumber(num))
{
    int oneNum = num / 10000;
    int twoNum = num / 1000 % 10;
    int fourNum = num / 10 % 10;
    int fiveNum = num % 10;
    
    if (oneNum == fiveNum && twoNum == fourNum)
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
}
Console.ReadKey();