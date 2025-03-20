int value1 = 3;  // 0b0000_0011
int value2 = 2;  // 0b0000_0010
int value3 = 1;  // 0b0000_0001
int result = 0b0000_0000;
// сохраняем в result значения из value1
result = result | value1; // 0b0000_0011
// сдвигаем разряды в result на 2 разряда влево
result = result << 2;   // 0b0000_1100
// сохраняем в result значения из value2
result = result | value2;  // 0b0000_1110
// сдвигаем разряды в result на 2 разряда влево
result = result << 2;   // 0b0011_1000
// сохраняем в result значения из value3
result = result | value3;  // 0b0011_1001

Console.WriteLine(result);  // 57
