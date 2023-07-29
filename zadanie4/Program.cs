//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"
Console.WriteLine ("Введите число : ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
int num1 = num*-1;
while(num1<=num)
{
    Console.WriteLine(num1);
    num1= num1+1;
}
