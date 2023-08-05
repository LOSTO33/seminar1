// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти координатной плоскости");
int numCoord = v

if(numCoord==1)
{
    Console.WriteLine("Возможные координаты:x>0 and y>0");
}
if(numCoord==2)
{
    Console.WriteLine("Возможные координаты:x<0 and y>0");
}
if(numCoord==3)
{
    Console.WriteLine("Возможные координаты:x<0 and y<0");
}
if(numCoord==4)
{
    Console.WriteLine("Возможные координаты:x>0 and y<0");
}
else
{
    Console.WriteLine("Такой плоскости нет");
}