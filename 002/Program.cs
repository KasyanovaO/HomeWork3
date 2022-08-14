﻿// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.5

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки A ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        int z1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        int z2 = Convert.ToInt32(Console.ReadLine());
        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine("расстояние между двумя точками d = ");
        Console.WriteLine(Math.Round(d, 2));
    }
}











