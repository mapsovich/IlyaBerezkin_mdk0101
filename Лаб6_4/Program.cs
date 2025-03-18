using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число с клавиатуры: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine(number + " - вот какое число Вы ввели");
        }
        else
        {
            Console.WriteLine("Ошибка: Введено некорректное число.");
        }
    }
}