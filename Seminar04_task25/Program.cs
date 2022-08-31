/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


Console.Clear(); //очистка терминала
Console.Write("Введите первое число: " );
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: " );
int b = int.Parse(Console.ReadLine());

double c = Math.Pow(a,b);
Console.WriteLine("Число " + a + " в степени " + b + " равно " + c );


