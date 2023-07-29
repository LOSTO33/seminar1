//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
//на само себя).
//
//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49

Console.WriteLine("Enter num : ");

string strNum = Console.ReadLine();

int num = int.Parse(strNum);

int square = num * num ;

Console.WriteLine($"square = {square}");