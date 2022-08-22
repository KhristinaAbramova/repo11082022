Console.Clear(); //очистка терминала
Console.WriteLine("Ввод любого целого числа");
int a = int.Parse(Console.ReadLine()); //создается целочисленная переменная a, в которую заносится число, введенное в консоли. Все, что вводится в консоли, по умолчанию имеет тип string(строка), и чтобы преобразовать строку в целое число используется метод int.Parse.
int count=1; //задание "с 1 до N"
Console.WriteLine("Целые числа");
while (count <=a)
{
    if (count%2==0)
    Console.WriteLine(count);
count ++; //прибавляю шаг
}

