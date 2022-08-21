// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int num2= 0;
int num3= 0;
if (num < 10000 | num > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число"); 
}

num2 = num % 10;
num3 = num;
num /= 10000;
if (num == num2)
{
   num = num3; 
   num3 /= 10;
   num3 %= 10;
   num /= 1000;
   num %= 10;
   if (num == num3)
   {
      Console.WriteLine("Да");
   }
}
else
{
    Console.WriteLine("Нет");
}