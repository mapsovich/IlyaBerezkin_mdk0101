﻿Console.Write("Введите имя: ");
string? name = Console.ReadLine();

Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height} м  Зарплата: {salary} руб.");
