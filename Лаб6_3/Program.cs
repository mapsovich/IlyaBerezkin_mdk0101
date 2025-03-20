using System;

namespace Лаб6_3 // Замените YourNamespace на имя вашего пространства имен
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:"); // Запрашиваем ввод числа
            string input = Console.ReadLine(); // Читаем введенное значение

            // Пытаемся преобразовать введенное значение в число
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Вы ввели число: {number}"); // Выводим сообщение с числом
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число."); // Обработка некорректного ввода
            }
        }
    }
}
