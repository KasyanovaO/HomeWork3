// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        if (numbers.ToString()[0] == numbers.ToString()[4] & numbers.ToString()[1] == numbers.ToString()[3])
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
}

