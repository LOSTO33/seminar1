// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random ();

int num =rand.Next(10,1000);

int num1 = num/100;
int num2 = num%100;
int result = num*10+num2;
Console.WriteLine($"Рандомное число {result},результат {num}");