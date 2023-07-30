// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


// Console.WriteLine ("Enter num : ");
// string number = Console.ReadLine();
// int num1 = int.Parse(number);

// Console.WriteLine ("Enter num : ");
//  number = Console.ReadLine();

// int num2 = int.Parse(number);
// int square1 = num1 *num1 ;
// int square2 = num2* num2;
// if ( num2 == square1)
// {
// Console.WriteLine(" Первое число является квадратом второго");
// }
// else if(num1 == square2)
// {
//     Console.WriteLine("Первое число не является квадратом второго");
// }





// if(strNum1==Num2*Num2&&strNum2==Num1*Num1) Console.WriteLine("Да, первое число - это квадрат второго");
// else Console.WriteLine($"Нет, это не квадрат второго.");
// Console.WriteLine("Enter num1 : ");
// string strNum1 = Console.ReadLine();
// int num1 = int.Parse(strNum1);

// Console.WriteLine("Enter num2 : ");
// string strNum2 = Console.ReadLine();
// int num2 = int.Parse(strNum2);
// int sq1 = num1 * num1;
// int sq2 = num2 * num2;
// if (sq1 == num2)
// {
//     Console.WriteLine($"Да, число {num2} является квадратом {num1}");
// }
// else
// {
//     if (sq2 == num1)
//     {
//         Console.WriteLine($"Да, число {num1} является квадратом {num2}");
//     }
//     else
//         Console.WriteLine($"Числа {num1} , {num2} не являеются квадратами друг друга");
// }

Console.WriteLine("Enter num1 : ");
int strNum1 = Convert.ToInt32(Console.ReadLine());
//int num1 = int.Parse(strNum1);

Console.WriteLine("Enter num2 : ");
int strNum2 = Convert.ToInt32(Console.ReadLine());




if(strNum1==strNum2*strNum2 || strNum2==strNum1*strNum1) Console.WriteLine("Да, одно число - это квадрат другого");
else Console.WriteLine($"Нет, это не квадрат второго.");