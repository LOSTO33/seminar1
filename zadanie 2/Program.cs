//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.WriteLine ("Enter num : ");
string strNum1 = Console.ReadLine();
Console.WriteLine ("Enter num : ");
string strNum2 = Console.ReadLine();
int num1 = int.Parse(strNum1);
int num2 = int.Parse(strNum2);
int square = num2 * num2 ;
if(square== num1)
{
Console.WriteLine($"Да число {num1} является квадратом {square}");    
}
else
{
Console.WriteLine($"Нет число {num1} не является квадратом {square}");    
}