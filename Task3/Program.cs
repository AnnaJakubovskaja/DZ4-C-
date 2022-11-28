/*Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]*/


Console.Write("Введите размер массива: ");
int s = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[s];

FillArrayRandomNumbers(numbers, 0, 10);
WriteArray(numbers);


void FillArrayRandomNumbers(int[] array, int a, int b)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(a, b);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}