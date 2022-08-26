/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear(); //очистка терминала
Console.Write("Введите число: ");
double a = double.Parse(Console.ReadLine());
a = Math.Abs(a);
 Console.Write("Ответ: ");
 for(int i=1; i<=a; i++)
 {
    Console.Write(Math.Pow(i,3)+" , ");
 }