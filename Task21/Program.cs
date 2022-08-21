// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Ведите коодинаты по оси Хa");
double Xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты по оси Ya");
double Ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите коодинаты по оси Za");
double Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите коодинаты по оси Хb");
double Xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты по оси Yb");
double Yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите коодинаты по оси Zb");
double Zb = Convert.ToInt32(Console.ReadLine());

double Z = Math.Sqrt(Math.Pow(Xb -Xa,2)+Math.Pow(Yb-Ya,2)+Math.Pow(Za-Zb,2));



Console.WriteLine($"{Z:f2}");

