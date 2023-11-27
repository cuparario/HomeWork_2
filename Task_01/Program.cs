/* Задача 1: Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 7 и 23. */

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
string result = (num % 7 == 0 && num % 23 == 0) ? "да" : "нет";
System.Console.WriteLine(result);
