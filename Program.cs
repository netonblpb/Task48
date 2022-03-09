// Показать двумерный массив размером m×n заполненный целыми числами.

Console.Clear();

Console.Write("Задайте размер массива по X: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте арзмер массива по Y: ");
int n = int.Parse(Console.ReadLine());
Random rnd = new Random();
int[,] mass = new int[m, n];

void Fillmass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10, 100);
        }
    }
}

void Printmass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Fillmass(mass);
Printmass(mass);