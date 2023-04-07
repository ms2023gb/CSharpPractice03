/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

Console.WriteLine("Введите координаты для точки A");
int ax = Prompt("X: ");
int ay = Prompt("Y: ");
int az = Prompt("Z: ");
Console.WriteLine();

Console.WriteLine("Введите координаты для точки B");
int bx = Prompt("X: ");
int by = Prompt("Y: ");
int bz = Prompt("Z: ");
Console.WriteLine();

int axbx2 = (ax - bx) * (ax - bx);
int ayby2 = (ay - by) * (ay - by);
int azbz2 = (az - bz) * (az - bz);

double number = Math.Round(Math.Sqrt(axbx2 + ayby2 + azbz2), 2);

Console.WriteLine($"Растояние между двух точек A({ax},{ay},{az}); B({bx},{by},{bz}) -> {number}");
Console.ReadKey();