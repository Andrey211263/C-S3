//==== Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int count = number.Length - 1;
// int sign = 1; // признак полидрома

// for( int i = 0; i < count; i++)
// if(number[i] == number[count]) count = count - 1;
// else
// {
// sign = 0;
// break;
// }
// if(sign == 0) Console.WriteLine("Не палиндром");
// else
// {
// Console.WriteLine("Палиндром");
// }

//====Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//  Console.WriteLine("Введите координату первой точки по оси X...");
//  double Xa = Convert.ToDouble(Console.ReadLine());

//  Console.WriteLine("Введите координату первой точки по оси Y...");
//  double Ya = Convert.ToDouble(Console.ReadLine());

//  Console.WriteLine("Введите координату первой точки по оси Z...");
//  double Za = Convert.ToDouble(Console.ReadLine());

//  Console.WriteLine("Введите координату второй точки по оси X...");
//  double Xb = Convert.ToDouble(Console.ReadLine());

//  Console.WriteLine("Введите координату второй точки по оси Y...");
//  double Yb = Convert.ToDouble(Console.ReadLine());

//  Console.WriteLine("Введите координату второй точки по оси Z...");
//  double Zb = Convert.ToDouble(Console.ReadLine());

//  double Distance = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));
//  //Console.WriteLine("Расстояние между двумя точками равно: " + Distance);
//  Console.WriteLine($"Расстояние между двумя точками равно: {Distance}");
//
//====Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for( int i = 1; i <= number; i++)
{
    Console.Write($" {i*i}");
}