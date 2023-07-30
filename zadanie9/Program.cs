// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Enter num1 : ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

if (num1 % 23 == 0 && num1 % 7 == 0) Console.WriteLine("Кратное");
else Console.WriteLine("Не кратное");