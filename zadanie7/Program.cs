﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Enter num1 : ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

Console.WriteLine("Enter num2 : ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);


int res = num1%num2;

if(res==0) Console.WriteLine("Кратное");
else Console.WriteLine($"Остаток {res}");