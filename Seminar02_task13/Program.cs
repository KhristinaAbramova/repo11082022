/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear(); //очистка терминала
Console.WriteLine("Введите трехзначное число " );
string a = Console.ReadLine();
int n = a.Length;
if (n>2) 
{
        Console.Write("Третья цифра введенного числа -> ");
        Console.WriteLine(a [2]);
}
else 
{
    Console.WriteLine("Третья цифра отсутствует. Повторите попытку. ");
}