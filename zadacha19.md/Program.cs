// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int Onenumber = number%10;
int Secondnumber = number/10%10;
int Thirdnumber = number/1000%10;
int Fourthnumber = number/10000;

if (Onenumber == Fourthnumber && Secondnumber == Thirdnumber){ Console.WriteLine("Это число является палиндромом");}
else {Console.WriteLine("Это число не является палиндромом");}
