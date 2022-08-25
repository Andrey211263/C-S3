// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// AB = sqrt((Xb - Xa)^2 + (Ya - Yb)^2)

// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// AB = sqrt((Xb - Xa)^2 + (Ya - Yb)^2

 Console.WriteLine("Введите координату первой точки по оси X...");
 double Xa = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Введите координату первой точки по оси Y...");
 double Ya = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Введите координату второй точки по оси X...");
 double Xb = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Введите координату второй точки по оси Y...");
 double Yb = Convert.ToDouble(Console.ReadLine());

 double Distance = Math.Sqrt((Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2)));
 Console.WriteLine("Расстояние между двумя точками равно: " + Distance);




// Console.WriteLine("Введите координаты 1 точ x");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координаты 1 точ y");
// double xa = Convert.ToDouble(Console.ReadLine());
// double xa = Convert.ToDouble(Console.ReadLine());
//  ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координаты 2 точ x");
// int xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координаты 2 точ y");
// int yb = Convert.ToDoublee(Console.ReadLine());

// double Distance = Math.Sqrt((Math.Pow((xa - xb), 2) + Math.Pow(Math.Pow((ya - yb), 2))));
// Console.WriteLine("Расстояние : "+Distance);