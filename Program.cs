// //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] NewArray = new int [size];
    for(int i =0; i < size; i++)
    {
        NewArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return NewArray;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array [i] + " ");
    }
}
Console.Write("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
void positive (int [] array)
{
    int check = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0 ) check = check +1;
    }
    Console.WriteLine($"-> {check}");
}
positive(myArray);

// //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] NewArray = new int [size];
    for(int i =0; i < size; i++)
    {
        NewArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return NewArray;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array [i] + " ");
    }
}
Console.Write("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
void sumOfNegative (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0) sum = sum + array[i];
    }
    Console.Write ($"-> {sum}");
}
sumOfNegative (myArray);

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] NewArray = new int [size];
    for(int i =0; i < size; i++)
    {
        NewArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return NewArray;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array [i] + " ");
    }
}
Console.Write("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
void raz(int[] array)
{
    int x=0;
    int min = array[0];
    int max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max<array[i])
        max = array[i];
        if (min>array[i])
        min = array[i];
        i = i + 1;
    }
    x = max - min;
    Console.Write ($" <- разница между максимальным и минимальным {x}");
}
raz (myArray);
