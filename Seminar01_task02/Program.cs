Console.Clear(); //очистка терминала
Console.WriteLine("Ввод первого числа"); //WriteLine – вывести, перейти на новую строку
int a = int.Parse(Console.ReadLine()); 
//создается целочисленная переменная a, в которую заносится число, введенное в консоли. Все, что вводится в консоли, по умолчанию имеет тип string(строка), и чтобы преобразовать строку в целое число используется метод int.Parse. 
Console.WriteLine("Ввод второго числа");
int b = int.Parse(Console.ReadLine()); //ReadLine – считать строку из терминала

if (a>b)
{
        Console.Write ("Максимальное число "); //Write вывести в одной строке
        Console.WriteLine(a);
        Console.Write ("Минимальное число ");
        Console.WriteLine(b);
}
else if (b>a)
{
        Console.Write ("Максимальное число ");
        Console.WriteLine(b);
        Console.Write ("Минимальное число ");
        Console.WriteLine(a);
}
if (a==b)
        Console.WriteLine("Числа равны, повторите попытку");
