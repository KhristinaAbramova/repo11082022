/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

Console.Clear(); //очистка терминала
void FArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index<lenght)
    {
        collection[index] = new Random() .Next(1,10);
        index++; 
    }
}
void PArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position] + ",");
        position++;
    }
} 
int[] array = new int[8];
Console.Write("Масив данных из 8 элементов "); 
FArray(array);
PArray(array); 


