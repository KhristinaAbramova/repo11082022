Console.Clear(); //очистка терминала
Console.WriteLine("Ввод первого числа"); //WriteLine – вывести, перейти на новую строку
int a = int.Parse(Console.ReadLine()); 
//создается целочисленная переменная a, в которую заносится число, введенное в консоли. Все, что вводится в консоли, по умолчанию имеет тип string(строка), и чтобы преобразовать строку в целое число используется метод int.Parse. 
Console.WriteLine("Ввод второго числа");
int b = int.Parse(Console.ReadLine()); 
Console.WriteLine("Ввод третьего числа");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b>max) max=b;
if (c>max) max=c;

Console.Write ("Максимальное число ");
Console.WriteLine(max);

