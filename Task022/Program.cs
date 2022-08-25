// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите целое число... ");
int Number = Convert.ToInt32(Console.ReadLine());

//int Count = 1;

Console.WriteLine("Квадраты чисел от 1 до данного числа:");

// while (Count <= Number)
// {
//     Console.Write(Math.Pow(Count, 2) + " ");
//     ++Count;
// }
for (int Count = 1; Count < Number; Count++)
{
    Console.Write(Math.Pow(Count, 2) + " ");
}
Console.Write(Math.Pow(Number, 2) + " ");
