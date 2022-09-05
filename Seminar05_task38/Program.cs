// Задача 38: Задайте массив вещественных чисел (вещественные числа – дабл). Найдите разницу между максимальным и инимальным элементов массива. [3 7 22 2 78] -> 76

Console.Clear(); //очистка терминала 
Console.Write("Введите размер массива  ");
int size = int.Parse(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.Write("В массиве -> " );
PrintArray(numbers); 
double min = int.MaxValue;
double max = int.MinValue; 
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,100);;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"Максимальное число = {max}, минимальное число = {min}, разница между ними = {max - min}");
