//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница
Console.WriteLine ("Введите число : ");
string strNum1 = Console.ReadLine();
Console.WriteLine ("Enter num : ");
int num1 = int.Parse(strNum1);
if (num1 == 1)
{
    Console.WriteLine("Поинидельник");
}
else if ( num1 == 2)
{
    Console.WriteLine("Вторник");
}
else if ( num1 == 2)
{
    Console.WriteLine("Вторник");
}
else if ( num1 == 3)
{
    Console.WriteLine("Cреда");
}
else if ( num1 == 4)
{
    Console.WriteLine("Четверг");
}
else if ( num1 == 5)
{
    Console.WriteLine("Пятница");
}
else if ( num1 == 6)
{
    Console.WriteLine("Суббота");
}
