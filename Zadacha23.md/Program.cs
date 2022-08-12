// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите  число");
// int number = Convert.ToInt32(Console.ReadLine());
// void cube(int num) 
// {
//      int count = 1;
//      while (count <= num) {
//        Console.WriteLine(count * count * count); 
//        count++;      
// }
// }
// cube(number);

// ИЛИ

Console.WriteLine("Введите  число");
int number = Convert.ToInt32(Console.ReadLine());
void cube(int num) 
{
     int count = 1;
     while (count <= num) {
          double result = Math.Pow((count), 3);
          count++; 
          Console.WriteLine($"{result}");      
}
}
cube(number);

