// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:
// AB = √(xb - xa)2 + (yb - ya)2

Console.WriteLine("Введите координаты Xa:");
int numCoordXa = int.Parse (Console.ReadLine());
Console.WriteLine("Введите координаты Ya:");
int numCoordYa = int.Parse (Console.ReadLine());
Console.WriteLine("Введите координаты Xb:");
int numCoordXb = int.Parse (Console.ReadLine());
Console.WriteLine("Введите координаты Yb:");
int numCoordYb = int.Parse (Console.ReadLine());
double numCoordAB = Math.Sqrt(Math.Pow(numCoordXb -numCoordXa,2) + Math.Pow(numCoordYb -numCoordYa,2));
System.Console.WriteLine($"Расстояние {numCoordAB}");
