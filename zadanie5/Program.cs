//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8
Console.WriteLine ("enter num");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
if(num>99&&num>1000);
{
    int num1=num%10;
    Console.WriteLine(num1);
}
