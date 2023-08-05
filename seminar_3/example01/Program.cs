// Напишите программу, которая принимает на вход координаты 
// точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.

Console.WriteLine("int x:");
int numberX = int.Parse (Console.ReadLine());

Console.WriteLine("int y:");
int numberY = int.Parse (Console.ReadLine());

// if (numberX != 0 && numberY != 0)

if ( numberX > 0 && numberY > 0)
{
    System.Console.WriteLine("Первая Четверть");
}
else if (numberX < 0 && numberY > 0)
{
    System.Console.WriteLine("Вторая четверть ");
}
else if (numberX < 0 && numberY < 0)
{
    System.Console.WriteLine("Третья четверть ");
}
else if (numberX > 0 && numberY < 0)
{
    System.Console.WriteLine("Четвертая  четверть ");
}
else {
    System.Console.WriteLine("- ");
}