﻿int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
int key = 102; //Пусть это будет ключ - в двоичной форме 1100110

int encrypt = x ^ key; //Результатом будет число 1001011 или 75
Console.WriteLine($"Зашифрованное число: {encrypt}");

int decrypt = encrypt ^ key; // Результатом будет исходное число 45
Console.WriteLine($"Расшифрованное число: {decrypt}");
