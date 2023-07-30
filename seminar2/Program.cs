// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


Random rand = new Random ();

int num =rand.Next(10,100);

int num1 = num/10;

int num2 = num % 10;

int max = num1;

if(max < num2 )
{
    max = num2;
}
Console.WriteLine($"num = {num}; max = {max}");