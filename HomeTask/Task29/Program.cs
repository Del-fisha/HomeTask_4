// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.Write("Введите нижнюю границу массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнюю границу массива: ");
int b = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(a, b+1);
    Console.Write($"{array[i]} ");
}