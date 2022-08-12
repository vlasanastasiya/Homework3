// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты первой точки");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки");
int xc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int yc = Convert.ToInt32(Console.ReadLine());
void distance(int xa, int xb, int xc, int ya, int yb, int yc) 
{
      Console.WriteLine(Math.Sqrt((ya-xa) * (ya-xa) + (yb-xb) * (yb-xb) + (yc-xc) * (yc-xc)));

}

distance(xa, xb, xc, ya, yb, yc);
