/* Задача 19: Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - Не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
*/

/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите посследовательность координат: ");
Console.Write("aX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("aZ: ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("bX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("bZ: ");
int bZ = Convert.ToInt32(Console.ReadLine());


double L = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);

Console.WriteLine($"Расстояние равно: {L}");
*/

//Задача 23: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++) Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine(" ");