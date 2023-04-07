/*
    Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите число больше 1: ");

if (number < 1)
{
    Console.WriteLine("Вы ввели число менее 1, пожалуйста повторите ввод");
    return;
}

Console.Write($"Таблица кубов от 1 до {number} -> ");

for (int i = 1; i < number; i++)
{
    // Console.Write($"{i * i * i}, "); 
    Console.Write($"{Math.Pow(i, 3)}, "); // Выводим таблицу кубов до последнего числа, через запятую 
}

// Console.Write($"{number * number * number}"); 
Console.Write($"{Math.Pow(number, 3)}"); // Выводим последний куб числа, чтобы последней запятой не было
Console.ReadKey();